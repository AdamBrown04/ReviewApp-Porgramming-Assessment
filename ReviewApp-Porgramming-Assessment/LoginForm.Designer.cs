namespace ReviewApp_Porgramming_Assessment
{
    partial class LoginForm
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
            txbUsername = new TextBox();
            txbPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(134, 12);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(203, 27);
            txbUsername.TabIndex = 0;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(134, 69);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(203, 27);
            txbPassword.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(9, 12);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(76, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(10, 72);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(10, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(327, 60);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(10, 215);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(327, 57);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Create account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 284);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txbPassword);
            Controls.Add(txbUsername);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUsername;
        private TextBox txbPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnCreateAccount;
    }
}