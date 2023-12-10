namespace ccms
{
    partial class addForm
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
            txt_name = new TextBox();
            txt_id = new TextBox();
            txt_time = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_addstudent = new Button();
            box_lvl = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.MenuBar;
            txt_name.Location = new Point(97, 118);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(156, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_id
            // 
            txt_id.BackColor = SystemColors.MenuBar;
            txt_id.Location = new Point(97, 184);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(156, 23);
            txt_id.TabIndex = 2;
            // 
            // txt_time
            // 
            txt_time.BackColor = SystemColors.MenuBar;
            txt_time.Location = new Point(97, 258);
            txt_time.Name = "txt_time";
            txt_time.Size = new Size(156, 23);
            txt_time.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 94);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 160);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(97, 234);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 11;
            label3.Text = "Date - Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(97, 307);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 12;
            label4.Text = "Level";
            // 
            // btn_addstudent
            // 
            btn_addstudent.BackColor = Color.FromArgb(255, 192, 192);
            btn_addstudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addstudent.Location = new Point(270, 391);
            btn_addstudent.Name = "btn_addstudent";
            btn_addstudent.Size = new Size(119, 36);
            btn_addstudent.TabIndex = 13;
            btn_addstudent.Text = "Add Student";
            btn_addstudent.UseVisualStyleBackColor = false;
            btn_addstudent.Click += button1_Click;
            // 
            // box_lvl
            // 
            box_lvl.BackColor = SystemColors.MenuBar;
            box_lvl.FormattingEnabled = true;
            box_lvl.Items.AddRange(new object[] { "Year 1", "Year 2", "Year 3", "Year 4" });
            box_lvl.Location = new Point(97, 331);
            box_lvl.Name = "box_lvl";
            box_lvl.Size = new Size(156, 23);
            box_lvl.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(24, 391);
            button1.Name = "button1";
            button1.Size = new Size(90, 36);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // addForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(button1);
            Controls.Add(box_lvl);
            Controls.Add(btn_addstudent);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_time);
            Controls.Add(txt_id);
            Controls.Add(txt_name);
            Cursor = Cursors.IBeam;
            Name = "addForm";
            Style = MetroFramework.MetroColorStyle.Black;
            Text = "New Student";
            Load += addForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_id;
        private TextBox txt_time;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_addstudent;
        private ComboBox box_lvl;
        private Button button1;
    }
}