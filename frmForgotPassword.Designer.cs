namespace FinalProject
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.lblPleaseEnterYourUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnShowSecurityQuestions = new System.Windows.Forms.Button();
            this.lblSecurityQuestion1 = new System.Windows.Forms.Label();
            this.lblSecurityQuestion2 = new System.Windows.Forms.Label();
            this.lblSecurityQuestion3 = new System.Windows.Forms.Label();
            this.tbxAnswer1 = new System.Windows.Forms.TextBox();
            this.tbxAnswer2 = new System.Windows.Forms.TextBox();
            this.tbxAnswer3 = new System.Windows.Forms.TextBox();
            this.btnCheckAnswers = new System.Windows.Forms.Button();
            this.lblPleaseEnterYourNewPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTogglePasswordVisibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPleaseEnterYourUsername
            // 
            this.lblPleaseEnterYourUsername.AutoSize = true;
            this.lblPleaseEnterYourUsername.Location = new System.Drawing.Point(12, 23);
            this.lblPleaseEnterYourUsername.Name = "lblPleaseEnterYourUsername";
            this.lblPleaseEnterYourUsername.Size = new System.Drawing.Size(252, 24);
            this.lblPleaseEnterYourUsername.TabIndex = 0;
            this.lblPleaseEnterYourUsername.Text = "Please enter your username:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(270, 23);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.ShortcutsEnabled = false;
            this.tbxUsername.Size = new System.Drawing.Size(365, 29);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // btnShowSecurityQuestions
            // 
            this.btnShowSecurityQuestions.Location = new System.Drawing.Point(641, 9);
            this.btnShowSecurityQuestions.Name = "btnShowSecurityQuestions";
            this.btnShowSecurityQuestions.Size = new System.Drawing.Size(154, 58);
            this.btnShowSecurityQuestions.TabIndex = 2;
            this.btnShowSecurityQuestions.Text = "Show Security &Questions";
            this.btnShowSecurityQuestions.UseVisualStyleBackColor = true;
            this.btnShowSecurityQuestions.Click += new System.EventHandler(this.btnShowSecurityQuestions_Click);
            // 
            // lblSecurityQuestion1
            // 
            this.lblSecurityQuestion1.AutoSize = true;
            this.lblSecurityQuestion1.Location = new System.Drawing.Point(12, 87);
            this.lblSecurityQuestion1.Name = "lblSecurityQuestion1";
            this.lblSecurityQuestion1.Size = new System.Drawing.Size(0, 24);
            this.lblSecurityQuestion1.TabIndex = 3;
            // 
            // lblSecurityQuestion2
            // 
            this.lblSecurityQuestion2.AutoSize = true;
            this.lblSecurityQuestion2.Location = new System.Drawing.Point(12, 175);
            this.lblSecurityQuestion2.Name = "lblSecurityQuestion2";
            this.lblSecurityQuestion2.Size = new System.Drawing.Size(0, 24);
            this.lblSecurityQuestion2.TabIndex = 4;
            // 
            // lblSecurityQuestion3
            // 
            this.lblSecurityQuestion3.AutoSize = true;
            this.lblSecurityQuestion3.Location = new System.Drawing.Point(12, 255);
            this.lblSecurityQuestion3.Name = "lblSecurityQuestion3";
            this.lblSecurityQuestion3.Size = new System.Drawing.Size(0, 24);
            this.lblSecurityQuestion3.TabIndex = 5;
            // 
            // tbxAnswer1
            // 
            this.tbxAnswer1.Enabled = false;
            this.tbxAnswer1.Location = new System.Drawing.Point(16, 126);
            this.tbxAnswer1.MaxLength = 20;
            this.tbxAnswer1.Name = "tbxAnswer1";
            this.tbxAnswer1.ShortcutsEnabled = false;
            this.tbxAnswer1.Size = new System.Drawing.Size(365, 29);
            this.tbxAnswer1.TabIndex = 3;
            this.tbxAnswer1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAnswer1_KeyPress);
            // 
            // tbxAnswer2
            // 
            this.tbxAnswer2.Enabled = false;
            this.tbxAnswer2.Location = new System.Drawing.Point(16, 213);
            this.tbxAnswer2.MaxLength = 20;
            this.tbxAnswer2.Name = "tbxAnswer2";
            this.tbxAnswer2.ShortcutsEnabled = false;
            this.tbxAnswer2.Size = new System.Drawing.Size(365, 29);
            this.tbxAnswer2.TabIndex = 4;
            this.tbxAnswer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAnswer2_KeyPress);
            // 
            // tbxAnswer3
            // 
            this.tbxAnswer3.Enabled = false;
            this.tbxAnswer3.Location = new System.Drawing.Point(16, 300);
            this.tbxAnswer3.MaxLength = 20;
            this.tbxAnswer3.Name = "tbxAnswer3";
            this.tbxAnswer3.ShortcutsEnabled = false;
            this.tbxAnswer3.Size = new System.Drawing.Size(365, 29);
            this.tbxAnswer3.TabIndex = 5;
            this.tbxAnswer3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAnswer3_KeyPress);
            // 
            // btnCheckAnswers
            // 
            this.btnCheckAnswers.Enabled = false;
            this.btnCheckAnswers.Location = new System.Drawing.Point(399, 199);
            this.btnCheckAnswers.Name = "btnCheckAnswers";
            this.btnCheckAnswers.Size = new System.Drawing.Size(154, 58);
            this.btnCheckAnswers.TabIndex = 6;
            this.btnCheckAnswers.Text = "Check &Answers";
            this.btnCheckAnswers.UseVisualStyleBackColor = true;
            this.btnCheckAnswers.Click += new System.EventHandler(this.btnCheckAnswers_Click);
            // 
            // lblPleaseEnterYourNewPassword
            // 
            this.lblPleaseEnterYourNewPassword.AutoSize = true;
            this.lblPleaseEnterYourNewPassword.Enabled = false;
            this.lblPleaseEnterYourNewPassword.Location = new System.Drawing.Point(12, 353);
            this.lblPleaseEnterYourNewPassword.Name = "lblPleaseEnterYourNewPassword";
            this.lblPleaseEnterYourNewPassword.Size = new System.Drawing.Size(289, 24);
            this.lblPleaseEnterYourNewPassword.TabIndex = 10;
            this.lblPleaseEnterYourNewPassword.Text = "Please enter your new password:";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Enabled = false;
            this.tbxNewPassword.Location = new System.Drawing.Point(16, 391);
            this.tbxNewPassword.MaxLength = 20;
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PasswordChar = '*';
            this.tbxNewPassword.ShortcutsEnabled = false;
            this.tbxNewPassword.Size = new System.Drawing.Size(365, 29);
            this.tbxNewPassword.TabIndex = 7;
            this.tbxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNewPassword_KeyPress);
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(559, 379);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(154, 58);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "&Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(12, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 58);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(176, 426);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(154, 58);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnTogglePasswordVisibility
            // 
            this.btnTogglePasswordVisibility.Enabled = false;
            this.btnTogglePasswordVisibility.Location = new System.Drawing.Point(383, 375);
            this.btnTogglePasswordVisibility.Name = "btnTogglePasswordVisibility";
            this.btnTogglePasswordVisibility.Size = new System.Drawing.Size(170, 62);
            this.btnTogglePasswordVisibility.TabIndex = 8;
            this.btnTogglePasswordVisibility.Text = "&Toggle Password Visibility";
            this.btnTogglePasswordVisibility.UseVisualStyleBackColor = true;
            this.btnTogglePasswordVisibility.Click += new System.EventHandler(this.btnTogglePasswordVisibility_Click);
            // 
            // frmForgotPassword
            // 
            this.AcceptButton = this.btnShowSecurityQuestions;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(809, 501);
            this.Controls.Add(this.btnTogglePasswordVisibility);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblPleaseEnterYourNewPassword);
            this.Controls.Add(this.btnCheckAnswers);
            this.Controls.Add(this.tbxAnswer3);
            this.Controls.Add(this.tbxAnswer2);
            this.Controls.Add(this.tbxAnswer1);
            this.Controls.Add(this.lblSecurityQuestion3);
            this.Controls.Add(this.lblSecurityQuestion2);
            this.Controls.Add(this.lblSecurityQuestion1);
            this.Controls.Add(this.btnShowSecurityQuestions);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPleaseEnterYourUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmForgotPassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmForgotPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseEnterYourUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnShowSecurityQuestions;
        private System.Windows.Forms.Label lblSecurityQuestion1;
        private System.Windows.Forms.Label lblSecurityQuestion2;
        private System.Windows.Forms.Label lblSecurityQuestion3;
        private System.Windows.Forms.TextBox tbxAnswer1;
        private System.Windows.Forms.TextBox tbxAnswer2;
        private System.Windows.Forms.TextBox tbxAnswer3;
        private System.Windows.Forms.Button btnCheckAnswers;
        private System.Windows.Forms.Label lblPleaseEnterYourNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTogglePasswordVisibility;
    }
}