using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_MealMate
{
    public partial class Admin_Panel_Login_Page : Form
    {
        public Admin_Panel_Login_Page()
        {
            InitializeComponent();
        }

        private void Admin_Panel_Login_Page_Load(object sender, EventArgs e)
        {
            alignComponents();
        }
        private void alignComponents()
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
            pnlLoginControls.Left = (this.ClientSize.Width - pnlLoginControls.Width) / 2;
            pnlLoginControls.Top = (this.ClientSize.Height - pnlLoginControls.Height) / 2;
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // This code is for temporary navigation to the "Admin Panel" page.
            // Once the database is integrated this code will change.
            if (tbxUsername.Text == String.Empty || tbxPassword.Text == String.Empty)
            {
                MessageBox.Show("No username or password entered");
            }
            else { 
                var adminPanel = new Admin_Panel();
                adminPanel.Show();
            }
        }
    }
}
