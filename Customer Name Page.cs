using System.Diagnostics;

namespace capstone_MealMate
{
    public partial class Form1 : Form
    {
        public String orderType = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            align_Components();
        }
        private void align_Components()
        {
            lblGreeting.Left = (this.ClientSize.Width - lblGreeting.Width) / 2;
            tbxName.Left = (this.ClientSize.Width - tbxName.Width) / 2;
            tbxName.Top = lblGreeting.Top + 100;
            btnBeginOrder.Left = lblGreeting.Left;
            btnBeginOrder.Top = lblGreeting.Top + 350;
            btnDineIn.Left = lblGreeting.Left;
            btnDineIn.Top = lblGreeting.Top + 225;
            btnAdminPanel.Left = (this.ClientSize.Width - btnAdminPanel.Width) / 2;
            btnAdminPanel.Top = lblGreeting.Top + 475;
            btnTakeout.Left = lblGreeting.Right - btnTakeout.Width;
            btnTakeout.Top = btnDineIn.Top;
        }

        #region Button Click Events
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            var adminPanelLogin = new Admin_Panel_Login_Page();
            adminPanelLogin.Show();
        }

        // The two below button click events are to select an order type.
        // When one button is clicked, it's background color is changed to
        // gray to indicate it's selected. It will also set the background
        // color of the other button back to default. Lastly, it will set the
        // string "orderType" to be the same as the button pressed. This will be
        // for database purposes later down the line.
        private void btnDineIn_Click(object sender, EventArgs e)
        {
            // reset other ordertype button
            btnTakeout.BackColor = SystemColors.Control;
            // set color of pressed button
            btnDineIn.BackColor = Color.Gray;
            // set string "orderType"
            orderType = "DineIn";
        }
        private void btnTakeout_Click(object sender, EventArgs e)
        {
            // reset other ordertype button
            btnDineIn.BackColor = SystemColors.Control;
            // set color of pressed button
            btnTakeout.BackColor = Color.Gray;
            // set string "orderType"
            orderType = "Takeout";
        }

        // This code checks to make sure an orderType is selected. If not, a messagebox
        // is shown that blocks the user from proceeding further until one is selected.
        // If an orderType is selected, the user will proceed to the "Customer Menu"
        // page.
        private void btnBeginOrder_Click(object sender, EventArgs e)
        {
            if (orderType == "")
            {
                MessageBox.Show("Please specify how the order will be fulfilled");
            }
            else {
                MessageBox.Show("orderType is: " + orderType);
                // ^ Debug Message (Delete before production build)
                // Code for showing customer menu page, etc.
            }
        }
        #endregion



    }
}
