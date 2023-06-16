namespace To_Do_App
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.newTaskBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tasksBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taskCheckBox = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newTaskBox
            // 
            this.newTaskBox.Location = new System.Drawing.Point(31, 53);
            this.newTaskBox.Name = "newTaskBox";
            this.newTaskBox.Size = new System.Drawing.Size(532, 20);
            this.newTaskBox.TabIndex = 1;
            this.newTaskBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Task";
            // 
            // tasksBox
            // 
            this.tasksBox.Location = new System.Drawing.Point(31, 173);
            this.tasksBox.Multiline = true;
            this.tasksBox.Name = "tasksBox";
            this.tasksBox.Size = new System.Drawing.Size(740, 219);
            this.tasksBox.TabIndex = 3;
            this.tasksBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasks";
            // 
            // taskCheckBox
            // 
            this.taskCheckBox.CheckOnClick = true;
            this.taskCheckBox.FormattingEnabled = true;
            this.taskCheckBox.Location = new System.Drawing.Point(31, 173);
            this.taskCheckBox.Name = "taskCheckBox";
            this.taskCheckBox.Size = new System.Drawing.Size(740, 229);
            this.taskCheckBox.TabIndex = 5;
            this.taskCheckBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(682, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 61);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove Task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.taskCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tasksBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTaskBox);
            this.Controls.Add(this.button1);
            this.Name = "form1";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newTaskBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tasksBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox taskCheckBox;
        private System.Windows.Forms.Button button2;
    }
}

