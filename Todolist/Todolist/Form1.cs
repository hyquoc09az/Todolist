namespace Todolist
{
    public partial class frmToDoList : Form
    {
        private string FilePath = "Task.txt";
        public frmToDoList()
        {
            InitializeComponent();
            LoadTasks();
        }

        private bool IsTaskEmpty()
        {
            return string.IsNullOrWhiteSpace(txtTask.Text);
        }

        private bool IsDuplicateTask(string task)
        {
            foreach (ListViewItem item in lsvTask.Items)
                if (item.Text == task) return true;
            return false;
        }

        private void LoadTasks()
        {
            if (File.Exists(FilePath))
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length >= 5)
                        {
                            ListViewItem item = new ListViewItem(parts[0]);
                            item.SubItems.Add(parts[1]);
                            item.SubItems.Add(parts[2]);
                            item.SubItems.Add(parts[3]);
                            item.SubItems.Add(parts[4]);
                            lsvTask.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsTaskEmpty())
            {
                MessageBox.Show("Please fill in task fields before adding a task", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsDuplicateTask(txtTask.Text))
            {
                MessageBox.Show("Task already available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ListViewItem item = new ListViewItem(txtTask.Text);
            item.SubItems.Add(txtDeadline.Text);
            item.SubItems.Add(txtNotes.Text);
            item.SubItems.Add(rbtUrgent.Checked ? "Urgent" : rbtTrivial.Checked ? "Trivial" : "Normal");
            item.SubItems.Add(chkDone.Checked ? "Done" : "Pending");
            lsvTask.Items.Add(item);
            txtTask.Clear();
            txtDeadline.Clear();
            txtNotes.Clear();
            rbtTrivial.Checked = false;
            rbtUrgent.Checked = false;
            chkDone.Checked = false;
        }

        private void lsvTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTask.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvTask.SelectedItems[0];
                txtTask.Text = selectedItem.Text;
                txtDeadline.Text = selectedItem.SubItems[1].Text;
                txtNotes.Text = selectedItem.SubItems[2].Text;
                rbtUrgent.Checked = selectedItem.SubItems[3].Text == "Urgent";
                rbtTrivial.Checked = selectedItem.SubItems[3].Text == "Trivial";
                chkDone.Checked = selectedItem.SubItems[4].Text == "Done";
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (IsTaskEmpty())
            {
                MessageBox.Show("Please fill in task fields before adding a task", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lsvTask.SelectedItems.Count > 0)
            {
                var selectedItem = lsvTask.SelectedItems[0];
                if (selectedItem.Text != txtTask.Text && IsDuplicateTask(txtTask.Text))
                {
                    MessageBox.Show("Task already available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedItem.Text = txtTask.Text;
                selectedItem.SubItems[1].Text = txtDeadline.Text;
                selectedItem.SubItems[2].Text = txtNotes.Text;
                selectedItem.SubItems[3].Text = rbtUrgent.Checked ? "Urgent" : rbtTrivial.Checked ? "Trivial" : "Normal";
                selectedItem.SubItems[4].Text = chkDone.Checked ? "Done" : "Pending";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvTask.SelectedItems)
                lsvTask.Items.Remove(item);
            txtTask.Clear();
            txtDeadline.Clear();
            txtNotes.Clear();
            rbtUrgent.Checked = false;
            rbtTrivial.Checked = false;
            chkDone.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (ListViewItem item in lsvTask.Items)
                {
                    string line = $"{item.Text}|{item.SubItems[1].Text}|{item.SubItems[2].Text}|{item.SubItems[3].Text}|{item.SubItems[4].Text}";
                    writer.WriteLine(line);
                }
            }
            MessageBox.Show("Tasks saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}