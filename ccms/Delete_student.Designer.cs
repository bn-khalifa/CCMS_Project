namespace ccms
{
    partial class Delete_student
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
            btn_delete = new Button();
            label1 = new Label();
            button1 = new Button();
            txt_idd = new TextBox();
            txt_timeout = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Red;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(185, 299);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(114, 34);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Remove Student";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 125);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 21;
            label1.Text = "Enter Student ID";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(23, 391);
            button1.Name = "button1";
            button1.Size = new Size(90, 36);
            button1.TabIndex = 23;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_idd
            // 
            txt_idd.BackColor = Color.FromArgb(255, 224, 192);
            txt_idd.Location = new Point(100, 148);
            txt_idd.Name = "txt_idd";
            txt_idd.Size = new Size(199, 23);
            txt_idd.TabIndex = 24;
            // 
            // txt_timeout
            // 
            txt_timeout.BackColor = Color.FromArgb(255, 224, 192);
            txt_timeout.Location = new Point(100, 237);
            txt_timeout.Name = "txt_timeout";
            txt_timeout.Size = new Size(199, 23);
            txt_timeout.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(100, 214);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 25;
            label2.Text = "Out Time";
            label2.Click += label2_Click;
            // 
            // Delete_student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 450);
            Controls.Add(txt_timeout);
            Controls.Add(label2);
            Controls.Add(txt_idd);
            Controls.Add(button1);
            Controls.Add(btn_delete);
            Controls.Add(label1);
            Name = "Delete_student";
            Text = "Student Out";
            Load += Delete_student_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Label label1;
        private Button button1;
        private TextBox txt_idd;
        private TextBox txt_timeout;
        private Label label2;
    }
}