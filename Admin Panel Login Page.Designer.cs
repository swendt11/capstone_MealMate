namespace capstone_MealMate
{
    partial class Admin_Panel_Login_Page
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
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            pnlLoginControls = new Panel();
            btnCloseLogin = new Button();
            pnlLoginControls.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(323, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(416, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Panel Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 15F);
            lblUsername.Location = new Point(3, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(183, 47);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15F);
            lblPassword.Location = new Point(12, 60);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(174, 47);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // tbxUsername
            // 
            tbxUsername.Font = new Font("Segoe UI", 15F);
            tbxUsername.Location = new Point(189, -3);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(332, 54);
            tbxUsername.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 15F);
            tbxPassword.Location = new Point(189, 57);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(332, 54);
            tbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(0, 117);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(523, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlLoginControls
            // 
            pnlLoginControls.Controls.Add(btnLogin);
            pnlLoginControls.Controls.Add(lblUsername);
            pnlLoginControls.Controls.Add(lblPassword);
            pnlLoginControls.Controls.Add(tbxPassword);
            pnlLoginControls.Controls.Add(tbxUsername);
            pnlLoginControls.Location = new Point(275, 228);
            pnlLoginControls.Name = "pnlLoginControls";
            pnlLoginControls.Size = new Size(523, 160);
            pnlLoginControls.TabIndex = 6;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.Location = new Point(12, 590);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(131, 40);
            btnCloseLogin.TabIndex = 7;
            btnCloseLogin.Text = "Close Login ";
            btnCloseLogin.UseVisualStyleBackColor = true;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // Admin_Panel_Login_Page
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 642);
            ControlBox = false;
            Controls.Add(btnCloseLogin);
            Controls.Add(pnlLoginControls);
            Controls.Add(lblTitle);
            Name = "Admin_Panel_Login_Page";
            Text = "MealMate v0.1 - Admin Login";
            Load += Admin_Panel_Login_Page_Load;
            pnlLoginControls.ResumeLayout(false);
            pnlLoginControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private GroupBox gbxLoginControls;
        private Button btnLogin;
        private Panel pnlLoginControls;
        private Button btnCloseLogin;
    }
}