
namespace WinFormsApp_EmployeeManagement
{
    partial class FrmLogin
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
            LbUsername = new System.Windows.Forms.Label();
            LbPassword = new System.Windows.Forms.Label();
            TxtUsername = new System.Windows.Forms.TextBox();
            TxtPassword = new System.Windows.Forms.TextBox();
            BtnLogin = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.Location = new System.Drawing.Point(247, 102);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new System.Drawing.Size(79, 19);
            LbUsername.TabIndex = 0;
            LbUsername.Text = "Username:";
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.Location = new System.Drawing.Point(247, 185);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new System.Drawing.Size(75, 19);
            LbPassword.TabIndex = 1;
            LbPassword.Text = "Password:";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new System.Drawing.Point(389, 94);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new System.Drawing.Size(299, 27);
            TxtUsername.TabIndex = 2;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new System.Drawing.Point(389, 168);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new System.Drawing.Size(299, 27);
            TxtPassword.TabIndex = 3;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new System.Drawing.Point(389, 243);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new System.Drawing.Size(113, 38);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(850, 331);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LbPassword);
            Controls.Add(LbUsername);
            Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}

