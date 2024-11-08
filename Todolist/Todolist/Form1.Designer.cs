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
            ckbDone = new CheckBox();
            btnSave = new Button();
            rbtnUrgent = new RadioButton();
            btnDelete = new Button();
            btnFix = new Button();
            btnAdd = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txtTask = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listView = new ListView();
            columnTask = new ColumnHeader();
            columnDeadline = new ColumnHeader();
            columnNotes = new ColumnHeader();
            columnPriority = new ColumnHeader();
            columnStatus = new ColumnHeader();
            label5 = new Label();
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
            // ckbDone
            // 
            ckbDone.AutoSize = true;
            ckbDone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ckbDone.ForeColor = Color.DarkSeaGreen;
            ckbDone.Location = new Point(103, 163);
            ckbDone.Name = "ckbDone";
            ckbDone.Size = new Size(65, 21);
            ckbDone.TabIndex = 11;
            ckbDone.Text = "Done?";
            ckbDone.UseVisualStyleBackColor = true;
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
            // rbtnUrgent
            // 
            rbtnUrgent.AutoSize = true;
            rbtnUrgent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbtnUrgent.ForeColor = Color.DarkSeaGreen;
            rbtnUrgent.Location = new Point(12, 162);
            rbtnUrgent.Name = "rbtnUrgent";
            rbtnUrgent.Size = new Size(74, 21);
            rbtnUrgent.TabIndex = 9;
            rbtnUrgent.TabStop = true;
            rbtnUrgent.Text = "Urgent?";
            rbtnUrgent.UseVisualStyleBackColor = true;
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
            // textBox3
            // 
            textBox3.Location = new Point(75, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 4;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(75, 43);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(207, 23);
            txtTask.TabIndex = 3;
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
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { columnTask, columnDeadline, columnNotes, columnPriority, columnStatus });
            listView.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listView.ForeColor = SystemColors.ControlText;
            listView.Location = new Point(299, 9);
            listView.Name = "listView";
            listView.Size = new Size(549, 265);
            listView.TabIndex = 4;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
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
            // Todolist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(852, 286);
            Controls.Add(label5);
            Controls.Add(listView);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(rbtnUrgent);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(ckbDone);
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtTask;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView;
        private RadioButton rbtnUrgent;
        private Button btnDelete;
        private Button btnFix;
        private Button btnAdd;
        private ColumnHeader columnTask;
        private ColumnHeader columnDeadline;
        private ColumnHeader columnNotes;
        private CheckBox ckbDone;
        private Button btnSave;
        private ColumnHeader columnPriority;
        private ColumnHeader columnStatus;
        private Label label5;
    }
}