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
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            button4 = new Button();
            radioButton1 = new RadioButton();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            columnTask = new ColumnHeader();
            columnDeadline = new ColumnHeader();
            columnNotes = new ColumnHeader();
            columnPriority = new ColumnHeader();
            columnStatus = new ColumnHeader();
            checkBox2 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(565, 181);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADD TASK";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(392, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 21);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Done?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(484, 149);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(289, 39);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 21);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Urgent?";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(230, 149);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(125, 149);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Fix";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 149);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 25);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(71, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 25);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 25);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 2;
            label4.Text = "Notes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(59, 17);
            label3.TabIndex = 1;
            label3.Text = "Deadline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 41);
            label2.Name = "label2";
            label2.Size = new Size(33, 17);
            label2.TabIndex = 0;
            label2.Text = "Task";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnTask, columnDeadline, columnNotes, columnPriority, columnStatus });
            listView1.Location = new Point(3, 188);
            listView1.Name = "listView1";
            listView1.Size = new Size(566, 139);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(314, 82);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 21);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Todolist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 338);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Todolist";
            Text = "To do list";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListView listView1;
        private RadioButton radioButton1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ColumnHeader columnTask;
        private ColumnHeader columnDeadline;
        private ColumnHeader columnNotes;
        private CheckBox checkBox1;
        private Button button4;
        private ColumnHeader columnPriority;
        private ColumnHeader columnStatus;
        private CheckBox checkBox2;
    }
}