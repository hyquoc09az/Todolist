namespace Todolist
{
    public partial class Todolist : Form
    {
        private string FilePath = "Task.txt";
        public Todolist()
        {
            InitializeComponent();
            LoadTasks();
        }
        private bool IsDuplicateTask(string task)
        {
            foreach (ListViewItem item in lsvTask.Items)
            {
                if (item.Text == task)
                {
                    return true;
                }
            }
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
                        if (parts.Length == 4)
                        {
                            ListViewItem item = new ListViewItem(parts[0]);
                            item.SubItems.Add(parts[1]);
                            item.SubItems.Add(parts[2]);
                            item.SubItems.Add(parts[3]);
                            lsvTask.Items.Add(item);
                        }
                    }
                }
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsDuplicateTask(txtTask.Text))
            {
                MessageBox.Show("Task already avaiable", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            ListViewItem item = new ListViewItem(txtTask.Text);
            item.SubItems.Add(txtDeadline.Text);
            item.SubItems.Add(txtNotes.Text);
            item.SubItems.Add(rbtUrgent.Checked ? "Urgent" : rbtDone.Checked ? "Done" : "Pending");
            lsvTask.Items.Add(item);
            txtTask.Clear();
            txtDeadline.Clear();
            txtNotes.Clear();
            rbtDone.Checked = false;
            rbtUrgent.Checked = false;
        }

        private void lsvTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTask.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvTask.SelectedItems[0];
                txtTask.Text = selectedItem.Text;
                txtDeadline.Text = selectedItem.SubItems[1].Text;
                txtNotes.Text = selectedItem.SubItems[2].Text;
                if (selectedItem.SubItems[3].Text == "Urgent")
                {
                    rbtUrgent.Checked = true;
                    rbtDone.Checked = false;
                }
                else if (selectedItem.SubItems[3].Text == "Done")
                {
                    rbtDone.Checked = true;
                    rbtUrgent.Checked = false;
                }
                else
                {
                    rbtDone.Checked = false;
                    rbtUrgent.Checked = false;
                }
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (lsvTask.SelectedItems.Count > 0)
            {
                var selectedItem = lsvTask.SelectedItems[0];
                if (selectedItem.Text != txtTask.Text && IsDuplicateTask(txtTask.Text))
                {
                    MessageBox.Show("Task already avaiable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                selectedItem.Text = txtTask.Text;
                selectedItem.SubItems[1].Text = txtDeadline.Text;
                selectedItem.SubItems[2].Text = txtNotes.Text;
                selectedItem.SubItems[3].Text = rbtUrgent.Checked ? "Urgent" : rbtDone.Checked ? "Done" : "Pending";
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvTask.SelectedItems)
            {
                lsvTask.Items.Remove(item);
            }
            txtTask.Text = null;
            txtDeadline.Text = null;
            txtNotes.Text = null;
            rbtUrgent.Checked = false;
            rbtDone.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                foreach (ListViewItem item in lsvTask.Items)
                {
                    string line = $"{item.Text}|{item.SubItems[1].Text}|{item.SubItems[2].Text}|{item.SubItems[3].Text}";
                    writer.WriteLine(line);
                }
            }
            MessageBox.Show("Tasks saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void Todolist_Load(object sender, EventArgs e)
        {

        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }
    }
}