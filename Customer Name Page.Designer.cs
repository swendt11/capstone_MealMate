namespace capstone_MealMate
{
    partial class Form1
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
            lblGreeting = new Label();
            btnDineIn = new Button();
            tbxName = new TextBox();
            btnTakeout = new Button();
            btnBeginOrder = new Button();
            btnAdminPanel = new Button();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.AutoSize = true;
            lblGreeting.Font = new Font("Segoe UI", 20F);
            lblGreeting.Location = new Point(69, 6);
            lblGreeting.Margin = new Padding(5, 0, 5, 0);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(930, 62);
            lblGreeting.TabIndex = 0;
            lblGreeting.Text = "Hello! Please specify a name for your order:";
            lblGreeting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDineIn
            // 
            btnDineIn.Font = new Font("Segoe UI", 15F);
            btnDineIn.Location = new Point(69, 270);
            btnDineIn.Margin = new Padding(5, 6, 5, 6);
            btnDineIn.Name = "btnDineIn";
            btnDineIn.Size = new Size(453, 100);
            btnDineIn.TabIndex = 1;
            btnDineIn.Text = "Dine-In";
            btnDineIn.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            tbxName.Font = new Font("Segoe UI", 25F);
            tbxName.Location = new Point(278, 124);
            tbxName.Margin = new Padding(5, 6, 5, 6);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(496, 85);
            tbxName.TabIndex = 2;
            tbxName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTakeout
            // 
            btnTakeout.Font = new Font("Segoe UI", 15F);
            btnTakeout.Location = new Point(523, 270);
            btnTakeout.Margin = new Padding(5, 6, 5, 6);
            btnTakeout.Name = "btnTakeout";
            btnTakeout.Size = new Size(453, 100);
            btnTakeout.TabIndex = 3;
            btnTakeout.Text = "Takeout";
            btnTakeout.UseVisualStyleBackColor = true;
            // 
            // btnBeginOrder
            // 
            btnBeginOrder.Font = new Font("Segoe UI", 15F);
            btnBeginOrder.Location = new Point(69, 382);
            btnBeginOrder.Margin = new Padding(5, 6, 5, 6);
            btnBeginOrder.Name = "btnBeginOrder";
            btnBeginOrder.Size = new Size(907, 100);
            btnBeginOrder.TabIndex = 4;
            btnBeginOrder.Text = "Begin Order";
            btnBeginOrder.UseVisualStyleBackColor = true;
            // 
            // btnAdminPanel
            // 
            btnAdminPanel.Location = new Point(450, 491);
            btnAdminPanel.Name = "btnAdminPanel";
            btnAdminPanel.Size = new Size(141, 40);
            btnAdminPanel.TabIndex = 5;
            btnAdminPanel.Text = "Admin Panel";
            btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 642);
            ControlBox = false;
            Controls.Add(btnAdminPanel);
            Controls.Add(btnBeginOrder);
            Controls.Add(btnTakeout);
            Controls.Add(tbxName);
            Controls.Add(btnDineIn);
            Controls.Add(lblGreeting);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "MealMate v0.1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGreeting;
        private Button btnDineIn;
        private TextBox textBox1;
        private Button btnTakeout;
        private TextBox tbxName;
        private Button btnBeginOrder;
        private Button btnAdminPanel;
    }
}
