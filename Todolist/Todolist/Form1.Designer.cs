namespace Todolist
{
    partial class frmToDo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lsvTask = new ListView();
            columnTask = new ColumnHeader();
            columnDeadline = new ColumnHeader();
            columnNotes = new ColumnHeader();
            columnStatus = new ColumnHeader();
            lblTask = new Label();
            lblDeadline = new Label();
            lblNotes = new Label();
            txtTask = new TextBox();
            txtDeadline = new TextBox();
            txtNotes = new TextBox();
            btnAdd = new Button();
            btnFix = new Button();
            btnDelete = new Button();
            rbtUrgent = new RadioButton();
            btnSave = new Button();
            groupBoxAddTask = new GroupBox();
            rbtDone = new RadioButton();
            label1 = new Label();
            groupBoxAddTask.SuspendLayout();
            SuspendLayout();
            // 
            // lsvTask
            // 
            lsvTask.Columns.AddRange(new ColumnHeader[] { columnTask, columnDeadline, columnNotes, columnStatus });
            lsvTask.FullRowSelect = true;
            lsvTask.Location = new Point(12, 168);
            lsvTask.Name = "lsvTask";
            lsvTask.Size = new Size(560, 156);
            lsvTask.TabIndex = 1;
            lsvTask.UseCompatibleStateImageBehavior = false;
            lsvTask.View = View.Details;
            lsvTask.SelectedIndexChanged += lsvTask_SelectedIndexChanged;
            // 
            // columnTask
            // 
            columnTask.Text = "Task";
            columnTask.Width = 100;
            // 
            // columnDeadline
            // 
            columnDeadline.Text = "Deadline";
            columnDeadline.Width = 100;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 250;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 100;
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Location = new Point(6, 24);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(32, 15);
            lblTask.TabIndex = 0;
            lblTask.Text = "Task";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(6, 52);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(54, 15);
            lblDeadline.TabIndex = 4;
            lblDeadline.Text = "Deadline";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(6, 80);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(39, 15);
            lblNotes.TabIndex = 6;
            lblNotes.Text = "Notes";
            // 
            // txtTask
            // 
            txtTask.Location = new Point(66, 21);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(195, 22);
            txtTask.TabIndex = 1;
            // 
            // txtDeadline
            // 
            txtDeadline.Location = new Point(66, 49);
            txtDeadline.Name = "txtDeadline";
            txtDeadline.Size = new Size(195, 22);
            txtDeadline.TabIndex = 5;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(66, 77);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(195, 22);
            txtNotes.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 105);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFix
            // 
            btnFix.Location = new Point(87, 105);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(75, 23);
            btnFix.TabIndex = 9;
            btnFix.Text = "Fix";
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(168, 105);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // rbtUrgent
            // 
            rbtUrgent.AutoSize = true;
            rbtUrgent.Location = new Point(267, 24);
            rbtUrgent.Name = "rbtUrgent";
            rbtUrgent.Size = new Size(62, 19);
            rbtUrgent.TabIndex = 2;
            rbtUrgent.TabStop = true;
            rbtUrgent.Text = "Urgent";
            rbtUrgent.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(479, 105);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // groupBoxAddTask
            // 
            groupBoxAddTask.Controls.Add(rbtDone);
            groupBoxAddTask.Controls.Add(btnSave);
            groupBoxAddTask.Controls.Add(rbtUrgent);
            groupBoxAddTask.Controls.Add(btnDelete);
            groupBoxAddTask.Controls.Add(btnFix);
            groupBoxAddTask.Controls.Add(btnAdd);
            groupBoxAddTask.Controls.Add(txtNotes);
            groupBoxAddTask.Controls.Add(txtDeadline);
            groupBoxAddTask.Controls.Add(txtTask);
            groupBoxAddTask.Controls.Add(lblNotes);
            groupBoxAddTask.Controls.Add(lblDeadline);
            groupBoxAddTask.Controls.Add(lblTask);
            groupBoxAddTask.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxAddTask.Location = new Point(12, 12);
            groupBoxAddTask.Name = "groupBoxAddTask";
            groupBoxAddTask.Size = new Size(560, 150);
            groupBoxAddTask.TabIndex = 0;
            groupBoxAddTask.TabStop = false;
            groupBoxAddTask.Text = "ADD TASK";
            // 
            // rbtDone
            // 
            rbtDone.AutoSize = true;
            rbtDone.Location = new Point(335, 24);
            rbtDone.Name = "rbtDone";
            rbtDone.Size = new Size(54, 19);
            rbtDone.TabIndex = 12;
            rbtDone.TabStop = true;
            rbtDone.Text = "Done";
            rbtDone.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // frmToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 336);
            Controls.Add(lsvTask);
            Controls.Add(groupBoxAddTask);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmToDo";
            Text = "To Do List";
            groupBoxAddTask.ResumeLayout(false);
            groupBoxAddTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lsvTask;
        private ColumnHeader columnTask;
        private ColumnHeader columnDeadline;
        private ColumnHeader columnNotes;
        private ColumnHeader columnStatus;
        private Label lblTask;
        private Label lblDeadline;
        private Label lblNotes;
        private TextBox txtTask;
        private TextBox txtDeadline;
        private TextBox txtNotes;
        private Button btnAdd;
        private Button btnFix;
        private Button btnDelete;
        private RadioButton rbtUrgent;
        private Button btnSave;
        private GroupBox groupBoxAddTask;
        private Label label1;
        private RadioButton rbtDone;
    }
}