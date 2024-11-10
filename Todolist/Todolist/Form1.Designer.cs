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
            panel1 = new Panel();
            deadlineDate = new DateTimePicker();
            panel2 = new Panel();
            label6 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.DarkSeaGreen;
            btnSave.Location = new Point(270, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 82);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            btnSave.MouseLeave += onMouseLeaveEffect;
            btnSave.MouseHover += onMouseHoverEffect;
            // 
            // rbtUrgent
            // 
            rbtUrgent.AutoSize = true;
            rbtUrgent.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtUrgent.ForeColor = Color.DarkSeaGreen;
            rbtUrgent.Location = new Point(112, 251);
            rbtUrgent.Name = "rbtUrgent";
            rbtUrgent.Size = new Size(82, 23);
            rbtUrgent.TabIndex = 9;
            rbtUrgent.Text = "Urgent";
            rbtUrgent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkSeaGreen;
            btnDelete.Location = new Point(97, 286);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 82);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseLeave += onMouseLeaveEffect;
            btnDelete.MouseHover += onMouseHoverEffect;
            // 
            // btnFix
            // 
            btnFix.BackgroundImage = (Image)resources.GetObject("btnFix.BackgroundImage");
            btnFix.BackgroundImageLayout = ImageLayout.Zoom;
            btnFix.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFix.ForeColor = Color.DarkSeaGreen;
            btnFix.Location = new Point(182, 286);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(82, 82);
            btnFix.TabIndex = 7;
            btnFix.Text = "Fix";
            btnFix.TextAlign = ContentAlignment.BottomCenter;
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            btnFix.MouseLeave += onMouseLeaveEffect;
            btnFix.MouseHover += onMouseHoverEffect;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DarkSeaGreen;
            btnAdd.Location = new Point(4, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 82);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            btnAdd.MouseLeave += onMouseLeaveEffect;
            btnAdd.MouseHover += onMouseHoverEffect;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(78, 210);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(274, 26);
            txtNotes.TabIndex = 5;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(78, 136);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(274, 26);
            txtTask.TabIndex = 3;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.ForeColor = Color.DarkSeaGreen;
            lblNotes.Location = new Point(4, 217);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(51, 19);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notes";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDeadline.ForeColor = Color.DarkSeaGreen;
            lblDeadline.Location = new Point(4, 176);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(75, 19);
            lblDeadline.TabIndex = 1;
            lblDeadline.Text = "Deadline";
            // 
            // lblTask
            // 
            lblTask.AutoSize = true;
            lblTask.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTask.ForeColor = Color.MediumSeaGreen;
            lblTask.Location = new Point(4, 143);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(41, 19);
            lblTask.TabIndex = 0;
            lblTask.Text = "Task";
            // 
            // lsvTask
            // 
            lsvTask.Columns.AddRange(new ColumnHeader[] { columnTask, columnDeadline, columnNotes, columnPriority, columnStatus });
            lsvTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lsvTask.ForeColor = SystemColors.ControlText;
            lsvTask.FullRowSelect = true;
            lsvTask.Location = new Point(380, 12);
            lsvTask.Name = "lsvTask";
            lsvTask.Size = new Size(815, 385);
            lsvTask.TabIndex = 4;
            lsvTask.UseCompatibleStateImageBehavior = false;
            lsvTask.View = View.Details;
            lsvTask.SelectedIndexChanged += lsvTask_SelectedIndexChanged;
            // 
            // columnTask
            // 
            columnTask.Text = "Task";
            columnTask.Width = 200;
            // 
            // columnDeadline
            // 
            columnDeadline.Text = "Deadline";
            columnDeadline.Width = 200;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 200;
            // 
            // columnPriority
            // 
            columnPriority.Text = "Priority";
            columnPriority.Width = 120;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 120;
            // 
            // lblAddYourTasks
            // 
            lblAddYourTasks.AutoSize = true;
            lblAddYourTasks.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddYourTasks.ForeColor = Color.DarkSeaGreen;
            lblAddYourTasks.Location = new Point(4, 93);
            lblAddYourTasks.Name = "lblAddYourTasks";
            lblAddYourTasks.Size = new Size(231, 29);
            lblAddYourTasks.TabIndex = 12;
            lblAddYourTasks.Text = "ADD YOUR TASKS";
            lblAddYourTasks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbtTrivial
            // 
            rbtTrivial.AutoSize = true;
            rbtTrivial.Checked = true;
            rbtTrivial.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtTrivial.ForeColor = Color.DarkSeaGreen;
            rbtTrivial.Location = new Point(11, 251);
            rbtTrivial.Name = "rbtTrivial";
            rbtTrivial.Size = new Size(81, 23);
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
            chkDone.Location = new Point(215, 251);
            chkDone.Name = "chkDone";
            chkDone.Size = new Size(69, 23);
            chkDone.TabIndex = 14;
            chkDone.Text = "Done";
            chkDone.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(deadlineDate);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(chkDone);
            panel1.Controls.Add(lblNotes);
            panel1.Controls.Add(btnFix);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(rbtTrivial);
            panel1.Controls.Add(lblDeadline);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblTask);
            panel1.Controls.Add(rbtUrgent);
            panel1.Controls.Add(lblAddYourTasks);
            panel1.Controls.Add(txtTask);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 385);
            panel1.TabIndex = 15;
            // 
            // deadlineDate
            // 
            deadlineDate.CustomFormat = "dd/MM/yyyy-HH:mm";
            deadlineDate.Format = DateTimePickerFormat.Custom;
            deadlineDate.Location = new Point(78, 170);
            deadlineDate.Name = "deadlineDate";
            deadlineDate.Size = new Size(274, 26);
            deadlineDate.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(52, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(252, 77);
            panel2.TabIndex = 24;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(118, 10);
            label6.Name = "label6";
            label6.Size = new Size(31, 58);
            label6.TabIndex = 20;
            label6.Text = "l";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MediumTurquoise;
            label9.Location = new Point(207, 9);
            label9.Name = "label9";
            label9.Size = new Size(36, 45);
            label9.TabIndex = 23;
            label9.Text = "t";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.HotPink;
            label3.Location = new Point(33, 9);
            label3.Name = "label3";
            label3.Size = new Size(29, 59);
            label3.TabIndex = 17;
            label3.Text = "o";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(4, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 59);
            label2.TabIndex = 16;
            label2.Text = "t";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LawnGreen;
            label4.Location = new Point(60, 9);
            label4.Name = "label4";
            label4.Size = new Size(41, 59);
            label4.TabIndex = 18;
            label4.Text = "d";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(176, 9);
            label8.Name = "label8";
            label8.Size = new Size(36, 45);
            label8.TabIndex = 22;
            label8.Text = "s";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.HotPink;
            label5.Location = new Point(91, 9);
            label5.Name = "label5";
            label5.Size = new Size(41, 59);
            label5.TabIndex = 19;
            label5.Text = "o";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Bradley Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(145, 10);
            label7.Name = "label7";
            label7.Size = new Size(31, 45);
            label7.TabIndex = 21;
            label7.Text = "i";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1207, 404);
            Controls.Add(panel1);
            Controls.Add(lsvTask);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmToDoList";
            Text = "To Do List";
            FormClosing += frmToDoList_FormClosing;
            Leave += frmToDoList_Leave;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNotes;
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
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label label9;
        private DateTimePicker deadlineDate;
    }
}