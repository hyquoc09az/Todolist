namespace Todolist
{
    partial class frmToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToDoList));
            label1 = new Label();
            btnSave = new Button();
            rbtUrgent = new RadioButton();
            btnDelete = new Button();
            btnFix = new Button();
            btnAdd = new Button();
            txtNotes = new TextBox();
            txtDeadline = new TextBox();
            txtTask = new TextBox();
            lblNotes = new Label();
            lblDeadline = new Label();
            lblTask = new Label();
            lsvTask = new ListView();
            columnTask = new ColumnHeader();
            columnDeadline = new ColumnHeader();
            columnNotes = new ColumnHeader();
            columnPriority = new ColumnHeader();
            columnStatus = new ColumnHeader();
            lblAddYourTasks = new Label();
            rbtTrivial = new RadioButton();
            chkDone = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DarkSeaGreen;
            btnSave.Location = new Point(154, 144);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 76);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // rbtUrgent
            // 
            rbtUrgent.AutoSize = true;
            rbtUrgent.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtUrgent.ForeColor = Color.DarkSeaGreen;
            rbtUrgent.Location = new Point(12, 119);
            rbtUrgent.Name = "rbtUrgent";
            rbtUrgent.Size = new Size(63, 19);
            rbtUrgent.TabIndex = 9;
            rbtUrgent.TabStop = true;
            rbtUrgent.Text = "Urgent";
            rbtUrgent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkSeaGreen;
            btnDelete.Location = new Point(223, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 76);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFix
            // 
            btnFix.BackgroundImage = (Image)resources.GetObject("btnFix.BackgroundImage");
            btnFix.BackgroundImageLayout = ImageLayout.Zoom;
            btnFix.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFix.ForeColor = Color.DarkSeaGreen;
            btnFix.Location = new Point(83, 144);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(65, 76);
            btnFix.TabIndex = 7;
            btnFix.Text = "Fix";
            btnFix.TextAlign = ContentAlignment.BottomCenter;
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DarkSeaGreen;
            btnAdd.Location = new Point(12, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 76);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(71, 91);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(217, 22);
            txtNotes.TabIndex = 5;
            // 
            // txtDeadline
            // 
            txtDeadline.Location = new Point(71, 63);
            txtDeadline.Name = "txtDeadline";
            txtDeadline.Size = new Size(217, 22);
            txtDeadline.TabIndex = 4;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(71, 35);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(217, 22);
            txtTask.TabIndex = 3;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.ForeColor = Color.DarkSeaGreen;
            lblNotes.Location = new Point(12, 92);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notes";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeadline.ForeColor = Color.DarkSeaGreen;
            lblDeadline.Location = new Point(10, 64);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(55, 15);
            lblDeadline.TabIndex = 1;
            lblDeadline.Text = "Deadline";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTask.ForeColor = Color.MediumSeaGreen;
            lblTask.Location = new Point(12, 36);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(34, 15);
            lblTask.TabIndex = 0;
            lblTask.Text = "Task";
            // 
            // lsvTask
            // 
            lsvTask.Columns.AddRange(new ColumnHeader[] { columnTask, columnDeadline, columnNotes, columnPriority, columnStatus });
            lsvTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lsvTask.ForeColor = SystemColors.ControlText;
            lsvTask.FullRowSelect = true;
            lsvTask.Location = new Point(294, 9);
            lsvTask.Name = "lsvTask";
            lsvTask.Size = new Size(553, 211);
            lsvTask.TabIndex = 4;
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
            columnDeadline.Width = 75;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 250;
            // 
            // columnPriority
            // 
            columnPriority.Text = "Priority";
            columnPriority.Width = 75;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 50;
            // 
            // lblAddYourTasks
            // 
            lblAddYourTasks.AutoSize = true;
            lblAddYourTasks.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddYourTasks.ForeColor = Color.DarkSeaGreen;
            lblAddYourTasks.Location = new Point(12, 9);
            lblAddYourTasks.Name = "lblAddYourTasks";
            lblAddYourTasks.Size = new Size(180, 23);
            lblAddYourTasks.TabIndex = 12;
            lblAddYourTasks.Text = "ADD YOUR TASKS";
            // 
            // rbtTrivial
            // 
            rbtTrivial.AutoSize = true;
            rbtTrivial.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtTrivial.ForeColor = Color.DarkSeaGreen;
            rbtTrivial.Location = new Point(81, 119);
            rbtTrivial.Name = "rbtTrivial";
            rbtTrivial.Size = new Size(61, 19);
            rbtTrivial.TabIndex = 13;
            rbtTrivial.TabStop = true;
            rbtTrivial.Text = "Trivial";
            rbtTrivial.UseVisualStyleBackColor = true;
            // 
            // chkDone
            // 
            chkDone.AutoSize = true;
            chkDone.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkDone.ForeColor = Color.DarkSeaGreen;
            chkDone.Location = new Point(234, 120);
            chkDone.Name = "chkDone";
            chkDone.Size = new Size(54, 19);
            chkDone.TabIndex = 14;
            chkDone.Text = "Done";
            chkDone.UseVisualStyleBackColor = true;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(859, 236);
            Controls.Add(chkDone);
            Controls.Add(rbtTrivial);
            Controls.Add(lblAddYourTasks);
            Controls.Add(lsvTask);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(lblDeadline);
            Controls.Add(rbtUrgent);
            Controls.Add(lblTask);
            Controls.Add(txtDeadline);
            Controls.Add(txtTask);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnFix);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmToDoList";
            Text = "To Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNotes;
        private TextBox txtDeadline;
        private TextBox txtTask;
        private Label lblNotes;
        private Label lblDeadline;
        private Label lblTask;
        private ListView lsvTask;
        private RadioButton rbtUrgent;
        private Button btnDelete;
        private Button btnFix;
        private Button btnAdd;
        private ColumnHeader columnTask;
        private ColumnHeader columnDeadline;
        private ColumnHeader columnNotes;
        private Button btnSave;
        private ColumnHeader columnPriority;
        private ColumnHeader columnStatus;
        private Label lblAddYourTasks;
        private RadioButton rbtTrivial;
        private CheckBox chkDone;
    }
}