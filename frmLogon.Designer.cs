
namespace FinalProject
{
    partial class frmLogon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogon));
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogOn = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTogglePasswordVisibility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(13, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 24);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(126, 12);
            this.tbxUsername.MaxLength = 20;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(341, 29);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxUsername_KeyPress);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(126, 47);
            this.tbxPassword.MaxLength = 20;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(341, 29);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 47);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password: ";
            // 
            // btnLogOn
            // 
            this.btnLogOn.Location = new System.Drawing.Point(16, 82);
            this.btnLogOn.Name = "btnLogOn";
            this.btnLogOn.Size = new System.Drawing.Size(148, 51);
            this.btnLogOn.TabIndex = 3;
            this.btnLogOn.Text = "&Log On";
            this.btnLogOn.UseVisualStyleBackColor = true;
            this.btnLogOn.Click += new System.EventHandler(this.btnLogOn_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(170, 82);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(130, 51);
            this.btnNewUser.TabIndex = 4;
            this.btnNewUser.Text = "&New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(306, 82);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(161, 51);
            this.btnForgotPassword.TabIndex = 5;
            this.btnForgotPassword.Text = "&Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(473, 82);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(165, 51);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnTogglePasswordVisibility
            // 
            this.btnTogglePasswordVisibility.Location = new System.Drawing.Point(473, 12);
            this.btnTogglePasswordVisibility.Name = "btnTogglePasswordVisibility";
            this.btnTogglePasswordVisibility.Size = new System.Drawing.Size(165, 64);
            this.btnTogglePasswordVisibility.TabIndex = 7;
            this.btnTogglePasswordVisibility.Text = "&Toggle Password Visibility";
            this.btnTogglePasswordVisibility.UseVisualStyleBackColor = true;
            this.btnTogglePasswordVisibility.Click += new System.EventHandler(this.btnTogglePasswordVisibility_Click);
            // 
            // frmLogon
            // 
            this.AcceptButton = this.btnLogOn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 143);
            this.Controls.Add(this.btnTogglePasswordVisibility);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLogOn);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "frmLogon";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2022.01.01";
            this.Text = "Paged Adventures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogOn;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTogglePasswordVisibility;
    }
}

