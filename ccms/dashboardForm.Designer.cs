namespace ccms
{
    partial class dashboardForm
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            initialMigrationBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)initialMigrationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(23, 386);
            button1.Name = "button1";
            button1.Size = new Size(90, 36);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // initialMigrationBindingSource
            // 
            initialMigrationBindingSource.DataSource = typeof(Migrations.InitialMigration);
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 445);
            Controls.Add(button1);
            Name = "dashboardForm";
            Text = "dashboardForm";
            Load += dashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)initialMigrationBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private BindingSource initialMigrationBindingSource;
    }
}