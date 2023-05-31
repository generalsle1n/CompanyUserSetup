namespace CompanyUserSetup
{
    partial class MainMenu
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
            CreateNewUser = new Button();
            SuspendLayout();
            // 
            // CreateNewUser
            // 
            CreateNewUser.Location = new Point(10, 40);
            CreateNewUser.Name = "CreateNewUser";
            CreateNewUser.Size = new Size(410, 30);
            CreateNewUser.TabIndex = 0;
            CreateNewUser.Text = "Create New User";
            CreateNewUser.UseVisualStyleBackColor = true;
            CreateNewUser.Click += CreateNewUser_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(432, 403);
            Controls.Add(CreateNewUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainMenu";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateNewUser;
    }
}