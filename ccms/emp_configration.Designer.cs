namespace ccms
{
    partial class emp_configration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_configration));
            label1 = new Label();
            txt_emp_email = new TextBox();
            txt_emp_pass = new TextBox();
            label2 = new Label();
            btn_sign_in = new Button();
            pic_emp_photo = new PictureBox();
            btn_browse = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_emp_photo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 113);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Type your Email";
            // 
            // txt_emp_email
            // 
            txt_emp_email.BackColor = Color.FromArgb(224, 224, 224);
            txt_emp_email.Location = new Point(83, 136);
            txt_emp_email.Name = "txt_emp_email";
            txt_emp_email.Size = new Size(208, 23);
            txt_emp_email.TabIndex = 1;
            // 
            // txt_emp_pass
            // 
            txt_emp_pass.BackColor = Color.FromArgb(224, 224, 224);
            txt_emp_pass.Location = new Point(83, 234);
            txt_emp_pass.Name = "txt_emp_pass";
            txt_emp_pass.Size = new Size(208, 23);
            txt_emp_pass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(83, 211);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 2;
            label2.Text = "Type your Password";
            // 
            // btn_sign_in
            // 
            btn_sign_in.BackColor = Color.SeaGreen;
            btn_sign_in.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sign_in.Location = new Point(157, 316);
            btn_sign_in.Name = "btn_sign_in";
            btn_sign_in.Size = new Size(107, 35);
            btn_sign_in.TabIndex = 4;
            btn_sign_in.Text = "Sign In";
            btn_sign_in.UseVisualStyleBackColor = false;
            btn_sign_in.Click += btn_sign_in_Click;
            // 
            // pic_emp_photo
            // 
            pic_emp_photo.BackgroundImage = (Image)resources.GetObject("pic_emp_photo.BackgroundImage");
            pic_emp_photo.BackgroundImageLayout = ImageLayout.Stretch;
            pic_emp_photo.Location = new Point(373, 136);
            pic_emp_photo.Name = "pic_emp_photo";
            pic_emp_photo.Size = new Size(128, 120);
            pic_emp_photo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_emp_photo.TabIndex = 5;
            pic_emp_photo.TabStop = false;
            // 
            // btn_browse
            // 
            btn_browse.BackColor = Color.MistyRose;
            btn_browse.Location = new Point(399, 273);
            btn_browse.Name = "btn_browse";
            btn_browse.Size = new Size(75, 23);
            btn_browse.TabIndex = 6;
            btn_browse.Text = "Browse";
            btn_browse.UseVisualStyleBackColor = false;
            btn_browse.Click += btn_browse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 118);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 7;
            label3.Text = "Enter photo";
            // 
            // emp_configration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 399);
            Controls.Add(label3);
            Controls.Add(btn_browse);
            Controls.Add(pic_emp_photo);
            Controls.Add(btn_sign_in);
            Controls.Add(txt_emp_pass);
            Controls.Add(label2);
            Controls.Add(txt_emp_email);
            Controls.Add(label1);
            Name = "emp_configration";
            Text = "Employee Configiration";
            Load += emp_configration_Load;
            ((System.ComponentModel.ISupportInitialize)pic_emp_photo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_emp_email;
        private TextBox txt_emp_pass;
        private Label label2;
        private Button btn_sign_in;
        private PictureBox pic_emp_photo;
        private Button btn_browse;
        private Label label3;
    }
}