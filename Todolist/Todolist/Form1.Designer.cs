namespace Todolist
{
    partial class Todolist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Todolist));
            label1 = new Label();
            btnSave = new Button();
            rbtUrgent = new RadioButton();
            btnDelete = new Button();
            btnFix = new Button();
            btnAdd = new Button();
            txtNotes = new TextBox();
            txtDeadline = new TextBox();
            txtTask = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lsvTask = new ListView();
            columnTask = new ColumnHeader();
            columnDeadline = new ColumnHeader();
            columnNotes = new ColumnHeader();
            columnPriority = new ColumnHeader();
            columnStatus = new ColumnHeader();
            label5 = new Label();
            rbtDone = new RadioButton();
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
            btnSave.Location = new Point(152, 198);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 76);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // rbtUrgent
            // 
            rbtUrgent.AutoSize = true;
            rbtUrgent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtUrgent.ForeColor = Color.DarkSeaGreen;
            rbtUrgent.Location = new Point(12, 162);
            rbtUrgent.Name = "rbtUrgent";
            rbtUrgent.Size = new Size(74, 21);
            rbtUrgent.TabIndex = 9;
            rbtUrgent.TabStop = true;
            rbtUrgent.Text = "Urgent?";
            rbtUrgent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.DarkSeaGreen;
            btnDelete.Location = new Point(223, 198);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 76);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            btnFix.BackgroundImage = (Image)resources.GetObject("btnFix.BackgroundImage");
            btnFix.BackgroundImageLayout = ImageLayout.Zoom;
            btnFix.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFix.ForeColor = Color.DarkSeaGreen;
            btnFix.Location = new Point(81, 198);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(65, 76);
            btnFix.TabIndex = 7;
            btnFix.Text = "Fix";
            btnFix.TextAlign = ContentAlignment.BottomCenter;
            btnFix.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.DarkSeaGreen;
            btnAdd.Location = new Point(10, 198);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 76);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.BottomCenter;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(75, 121);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(207, 23);
            txtNotes.TabIndex = 5;
            // 
            // txtDeadline
            // 
            txtDeadline.Location = new Point(75, 82);
            txtDeadline.Name = "txtDeadline";
            txtDeadline.Size = new Size(207, 23);
            txtDeadline.TabIndex = 4;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(75, 43);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(207, 23);
            txtTask.TabIndex = 3;
            txtTask.TextChanged += txtTask_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSeaGreen;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 2;
            label4.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSeaGreen;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 1;
            label3.Text = "Deadline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 0;
            label2.Text = "Task";
            // 
            // lsvTask
            // 
            lsvTask.Columns.AddRange(new ColumnHeader[] { columnTask, columnDeadline, columnNotes, columnPriority, columnStatus });
            lsvTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lsvTask.ForeColor = SystemColors.ControlText;
            lsvTask.Location = new Point(299, 9);
            lsvTask.Name = "lsvTask";
            lsvTask.Size = new Size(549, 265);
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
            columnDeadline.Width = 80;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 250;
            // 
            // columnPriority
            // 
            columnPriority.Text = "Prioriry";
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSeaGreen;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 12;
            label5.Text = "ADD YOUR TASKS";
            // 
            // rbtDone
            // 
            rbtDone.AutoSize = true;
            rbtDone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtDone.ForeColor = Color.DarkSeaGreen;
            rbtDone.Location = new Point(106, 162);
            rbtDone.Name = "rbtDone";
            rbtDone.Size = new Size(64, 21);
            rbtDone.TabIndex = 13;
            rbtDone.TabStop = true;
            rbtDone.Text = "Done?";
            rbtDone.UseVisualStyleBackColor = true;
            // 
            // Todolist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 286);
            Controls.Add(rbtDone);
            Controls.Add(label5);
            Controls.Add(lsvTask);
            Controls.Add(label4);
            Controls.Add(txtNotes);
            Controls.Add(label3);
            Controls.Add(rbtUrgent);
            Controls.Add(label2);
            Controls.Add(txtDeadline);
            Controls.Add(txtTask);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnFix);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "Todolist";
            Text = "To do list";
            Load += Todolist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNotes;
        private TextBox txtDeadline;
        private TextBox txtTask;
        private Label label4;
        private Label label3;
        private Label label2;
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
        private Label label5;
        private RadioButton rbtDone;
    }
}