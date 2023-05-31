namespace CompanyUserSetup.SubForms.CreateNewUser
{
    partial class CreateNewUserMain
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            firstNameText = new TextBox();
            tokenIDText = new TextBox();
            costCenterText = new TextBox();
            managerUserText = new TextBox();
            tempalteUserText = new TextBox();
            lastNameText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 40);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 240);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Token ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 200);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "Cost Center";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 160);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 5;
            label6.Text = "Manager User (UPN)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 120);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 6;
            label7.Text = "Template User (UPN)";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(200, 40);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(209, 27);
            firstNameText.TabIndex = 7;
            // 
            // tokenIDText
            // 
            tokenIDText.Location = new Point(200, 240);
            tokenIDText.Name = "tokenIDText";
            tokenIDText.Size = new Size(209, 27);
            tokenIDText.TabIndex = 8;
            // 
            // costCenterText
            // 
            costCenterText.Location = new Point(200, 200);
            costCenterText.Name = "costCenterText";
            costCenterText.Size = new Size(209, 27);
            costCenterText.TabIndex = 9;
            // 
            // managerUserText
            // 
            managerUserText.Location = new Point(200, 160);
            managerUserText.Name = "managerUserText";
            managerUserText.Size = new Size(209, 27);
            managerUserText.TabIndex = 10;
            // 
            // tempalteUserText
            // 
            tempalteUserText.Location = new Point(200, 120);
            tempalteUserText.Name = "tempalteUserText";
            tempalteUserText.Size = new Size(209, 27);
            tempalteUserText.TabIndex = 11;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(200, 80);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(209, 27);
            lastNameText.TabIndex = 12;
            // 
            // CreateNewUserMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lastNameText);
            Controls.Add(tempalteUserText);
            Controls.Add(managerUserText);
            Controls.Add(costCenterText);
            Controls.Add(tokenIDText);
            Controls.Add(firstNameText);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateNewUserMain";
            Text = "CreateNewUserUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox firstNameText;
        private TextBox tokenIDText;
        private TextBox costCenterText;
        private TextBox managerUserText;
        private TextBox tempalteUserText;
        private TextBox lastNameText;
    }
}