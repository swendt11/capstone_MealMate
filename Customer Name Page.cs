using System.Diagnostics;

namespace capstone_MealMate
{
    public partial class Form1 : Form
    {
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
    }
}
