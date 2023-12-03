namespace ProjectManagementWinApp_NguyenCongDanh
{
    partial class frmLogin
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
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btLogin = new System.Windows.Forms.Button();
            btRest = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(95, 102);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(95, 142);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(184, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(260, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(184, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(260, 27);
            txtPassword.TabIndex = 3;
            // 
            // btLogin
            // 
            btLogin.Location = new System.Drawing.Point(184, 200);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(94, 29);
            btLogin.TabIndex = 4;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btRest
            // 
            btRest.Location = new System.Drawing.Point(350, 200);
            btRest.Name = "btRest";
            btRest.Size = new System.Drawing.Size(94, 29);
            btRest.TabIndex = 5;
            btRest.Text = "Rest";
            btRest.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            ClientSize = new System.Drawing.Size(552, 286);
            Controls.Add(btRest);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRest;
    }
}