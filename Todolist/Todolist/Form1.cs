using System.Diagnostics;
using System;
using System.Collections;

namespace Todolist
{
    public partial class frmToDoList : Form
    {
        private string FilePath = "Task.txt";
        private bool isSaved = true;

        public frmToDoList()
        {
            InitializeComponent();
            LoadTasks();
            deadlineDate.MinDate = DateTime.Now;
            handleStatus();
            sortTasks();
        }

        private void handleStatus()
        {
            foreach (ListViewItem item in lsvTask.Items)
            {
                if (item.SubItems[item.SubItems.Count - 1].Text == "Done")
                {
                    item.BackColor = Color.Green;
                    item.ForeColor = Color.White;
                }
                else if (item.SubItems[item.SubItems.Count - 1].Text == "Overdue")
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
                else
                {
                    string date = item.SubItems[1].ToString().Split('-')[0].Split("{")[1];
                    string time = item.SubItems[1].ToString().Split('-')[1].Split("}")[0];
                    string hour = time.Split(':')[0];
                    string minute = time.Split(':')[1];
                    DateTime deadline = new DateTime(Convert.ToInt32(date.Split('/')[2]), Convert.ToInt32(date.Split('/')[1]), Convert.ToInt32(date.Split('/')[0]), Convert.ToInt32(hour), Convert.ToInt32(minute), 0);
                    if (deadline < DateTime.Now)
                    {
                        item.BackColor = Color.Red;
                        item.ForeColor = Color.White;
                        item.SubItems[item.SubItems.Count - 1].Text = "Overdue";
                        btnSave.PerformClick();
                    }
                    else
                    {
                        if (item.SubItems[3].Text == "Urgent")
                        {
                            item.BackColor = Color.Orange;
                            item.ForeColor = Color.White;
                        }
                        else
                        {
                            item.BackColor = Color.White;
                            item.ForeColor = Color.Black;
                        }
                    }
                }
            }
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
            item.SubItems.Add(deadlineDate.Text);
            item.SubItems.Add(txtNotes.Text);
            item.SubItems.Add(rbtUrgent.Checked ? "Urgent" : rbtTrivial.Checked ? "Trivial" : "Normal");
            item.SubItems.Add(chkDone.Checked ? "Done" : "Pending");
            if (chkDone.Checked)
            {
                item.BackColor = Color.Green;
                item.ForeColor = Color.White;
            }
            else
            {
                if(rbtUrgent.Checked)
                {
                    item.BackColor = Color.Orange;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
            }
            lsvTask.Items.Add(item);
            txtTask.Clear();
            deadlineDate.Value = DateTime.Now;
            txtNotes.Clear();
            rbtTrivial.Checked = true;
            rbtUrgent.Checked = false;
            chkDone.Checked = false;
            sortTasks();
            isSaved = false;
        }

        private void lsvTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTask.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsvTask.SelectedItems[0];
                txtTask.Text = selectedItem.Text;
                DateTime deadline = convertToDateTime(selectedItem.SubItems[1].Text);
                deadlineDate.MinDate = DateTime.Now;
                if (selectedItem.SubItems[selectedItem.SubItems.Count - 1].Text != "Overdue" && deadline > deadlineDate.Value)
                {
                    deadlineDate.Value = deadline;
                }
                else
                    deadlineDate.Value = DateTime.Now;
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
                selectedItem.SubItems[1].Text = deadlineDate.Text;
                selectedItem.SubItems[2].Text = txtNotes.Text;
                selectedItem.SubItems[3].Text = rbtUrgent.Checked ? "Urgent" : rbtTrivial.Checked ? "Trivial" : "Normal";
                selectedItem.SubItems[4].Text = chkDone.Checked ? "Done" : "Pending";
                if(chkDone.Checked)
                {
                    selectedItem.BackColor = Color.Green;
                    selectedItem.ForeColor = Color.White;
                }
                else
                {
                    if (rbtUrgent.Checked)
                    {
                        selectedItem.BackColor = Color.Orange;
                        selectedItem.ForeColor = Color.White;
                    }
                    else
                    {
                        selectedItem.BackColor = Color.White;
                        selectedItem.ForeColor = Color.Black;
                    }
                }
                sortTasks();
                isSaved = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvTask.SelectedItems)
                lsvTask.Items.Remove(item);
            txtTask.Clear();
            deadlineDate.Value = DateTime.Now;
            txtNotes.Clear();
            rbtUrgent.Checked = false;
            rbtTrivial.Checked = true;
            chkDone.Checked = false;
            isSaved = false;
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
            isSaved = true;
            MessageBox.Show("Tasks saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void onMouseHoverEffect(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Width == 82)
            {
                btn.Location = new Point(btn.Location.X - 10, btn.Location.Y);
                btn.Size = new Size(95, 95);
                btn.BringToFront();
            }
        }

        private void onMouseLeaveEffect(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Width == 95)
            {
                btn.Location = new Point(btn.Location.X + 10, btn.Location.Y);
                btn.Size = new Size(82, 82);
                btn.SendToBack();
            }
        }

        private void frmToDoList_Leave(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) btnSave.PerformClick();
            }
        }

        private void frmToDoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult result = MessageBox.Show("Do you want to save the changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) btnSave.PerformClick();
            }
        }

        private void sortTasks()
        {
            if (lsvTask.Items.Count > 0)
            {
                lsvTask.ListViewItemSorter = new TaskComparer();
                lsvTask.Sort();
            }
        }

        private DateTime convertToDateTime(string unformatedDateTime)
        {
            string date = unformatedDateTime.Split('-')[0];
            string time = unformatedDateTime.Split('-')[1];
            string hour = time.Split(':')[0];
            string minute = time.Split(':')[1];
            DateTime convertedDateTime = new DateTime(Convert.ToInt32(date.Split('/')[2]), Convert.ToInt32(date.Split('/')[1]), Convert.ToInt32(date.Split('/')[0]), Convert.ToInt32(hour), Convert.ToInt32(minute), 0);
            return convertedDateTime;
        }
    }
}

public class TaskComparer : IComparer
{
    private DateOnly convertToDate(string unformatedDate)
    {
        string date = unformatedDate.Split('-')[0];
        DateOnly dateOnly = DateOnly.Parse(date);
        return dateOnly;
    }

    private TimeOnly convertToTime(string unformatedTime)
    {
        string time = unformatedTime.Split('-')[1];
        string hour = time.Split(':')[0];
        string minute = time.Split(':')[1];
        TimeOnly timeOnly = TimeOnly.Parse($"{hour}:{minute}");
        return timeOnly;
    }

    public int Compare(object x, object y)
    {
        ListViewItem item1 = (ListViewItem)x;
        ListViewItem item2 = (ListViewItem)y;

        DateOnly date1 = convertToDate(item1.SubItems[1].Text);
        DateOnly date2 = convertToDate(item2.SubItems[1].Text);

        int compareDate = date1.CompareTo(date2);
        if (compareDate == 0)
        {
            int status1 = GetStatusValue(item1.SubItems[4].Text);
            int status2 = GetStatusValue(item2.SubItems[4].Text);

            int compareStatus = status1.CompareTo(status2);

            if(compareStatus == 0)
            {
                int priority1 = GetPriorityValue(item1.SubItems[3].Text);
                int priority2 = GetPriorityValue(item2.SubItems[3].Text);

                int comparePriority = priority1.CompareTo(priority2);

                if (comparePriority == 0)
                {
                    TimeOnly time1 = convertToTime(item1.SubItems[1].Text);
                    TimeOnly time2 = convertToTime(item2.SubItems[1].Text);

                    return time1.CompareTo(time2);
                }
                else
                {
                    return comparePriority;
                }
            }
            else
            {
                return compareStatus;
            }
        }
        else
        {
            return compareDate;
        }
    }

    private int GetPriorityValue(string priority)
    {
        if (priority == "Urgent") return 1;
        if (priority == "Normal") return 2;
        return 3;
    }

    private int GetStatusValue(string status)
    {
        if (status == "Done") return 3;
        if (status == "Pending") return 1;
        return 2;
    }
}