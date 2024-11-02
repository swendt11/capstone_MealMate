namespace capstone_MealMate
{
    partial class Admin_Panel
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
            tabControl1 = new TabControl();
            tpOrders = new TabPage();
            lblOrderType = new Label();
            lblNumberOfDishes = new Label();
            lbxOrders = new ListBox();
            btnOrdersCloseAdminPanel = new Button();
            btnServeOrder = new Button();
            tpMenuItems = new TabPage();
            btnMenuItemsCloseAdminPanel = new Button();
            tbxAllergensAdd = new TextBox();
            tbxItemNameAdd = new TextBox();
            lblAllergensAdd = new Label();
            lblItemNameAdd = new Label();
            btnAddItem = new Button();
            btnDeleteItem = new Button();
            lblAllergensRemove = new Label();
            lblItemNameRemove = new Label();
            lbxMenuItems = new ListBox();
            tpUserManagement = new TabPage();
            tbxPasswordAdd = new TextBox();
            tbxUsernameAdd = new TextBox();
            lblPasswordRemove = new Label();
            lblUsernameRemove = new Label();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            lblPassword = new Label();
            lblUsername = new Label();
            btnUsersCloseAdminPanel = new Button();
            lbxUsers = new ListBox();
            tabControl1.SuspendLayout();
            tpOrders.SuspendLayout();
            tpMenuItems.SuspendLayout();
            tpUserManagement.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpOrders);
            tabControl1.Controls.Add(tpMenuItems);
            tabControl1.Controls.Add(tpUserManagement);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 643);
            tabControl1.TabIndex = 0;
            // 
            // tpOrders
            // 
            tpOrders.Controls.Add(lblOrderType);
            tpOrders.Controls.Add(lblNumberOfDishes);
            tpOrders.Controls.Add(lbxOrders);
            tpOrders.Controls.Add(btnOrdersCloseAdminPanel);
            tpOrders.Controls.Add(btnServeOrder);
            tpOrders.Location = new Point(4, 39);
            tpOrders.Name = "tpOrders";
            tpOrders.Padding = new Padding(3);
            tpOrders.Size = new Size(1063, 600);
            tpOrders.TabIndex = 0;
            tpOrders.Text = "Orders";
            tpOrders.UseVisualStyleBackColor = true;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Location = new Point(564, 36);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(120, 30);
            lblOrderType.TabIndex = 4;
            lblOrderType.Text = "Order Type:";
            // 
            // lblNumberOfDishes
            // 
            lblNumberOfDishes.AutoSize = true;
            lblNumberOfDishes.Location = new Point(564, 6);
            lblNumberOfDishes.Name = "lblNumberOfDishes";
            lblNumberOfDishes.Size = new Size(186, 30);
            lblNumberOfDishes.TabIndex = 3;
            lblNumberOfDishes.Text = "Number of Dishes:";
            // 
            // lbxOrders
            // 
            lbxOrders.FormattingEnabled = true;
            lbxOrders.ItemHeight = 30;
            lbxOrders.Location = new Point(8, 6);
            lbxOrders.Name = "lbxOrders";
            lbxOrders.Size = new Size(550, 484);
            lbxOrders.TabIndex = 2;
            // 
            // btnOrdersCloseAdminPanel
            // 
            btnOrdersCloseAdminPanel.Location = new Point(8, 554);
            btnOrdersCloseAdminPanel.Name = "btnOrdersCloseAdminPanel";
            btnOrdersCloseAdminPanel.Size = new Size(197, 40);
            btnOrdersCloseAdminPanel.TabIndex = 1;
            btnOrdersCloseAdminPanel.Text = "Close Admin Panel";
            btnOrdersCloseAdminPanel.UseVisualStyleBackColor = true;
            btnOrdersCloseAdminPanel.Click += btnOrdersCloseAdminPanel_Click;
            // 
            // btnServeOrder
            // 
            btnServeOrder.Location = new Point(8, 508);
            btnServeOrder.Name = "btnServeOrder";
            btnServeOrder.Size = new Size(197, 40);
            btnServeOrder.TabIndex = 0;
            btnServeOrder.Text = "Serve Order";
            btnServeOrder.UseVisualStyleBackColor = true;
            // 
            // tpMenuItems
            // 
            tpMenuItems.Controls.Add(btnMenuItemsCloseAdminPanel);
            tpMenuItems.Controls.Add(tbxAllergensAdd);
            tpMenuItems.Controls.Add(tbxItemNameAdd);
            tpMenuItems.Controls.Add(lblAllergensAdd);
            tpMenuItems.Controls.Add(lblItemNameAdd);
            tpMenuItems.Controls.Add(btnAddItem);
            tpMenuItems.Controls.Add(btnDeleteItem);
            tpMenuItems.Controls.Add(lblAllergensRemove);
            tpMenuItems.Controls.Add(lblItemNameRemove);
            tpMenuItems.Controls.Add(lbxMenuItems);
            tpMenuItems.Location = new Point(4, 39);
            tpMenuItems.Name = "tpMenuItems";
            tpMenuItems.Padding = new Padding(3);
            tpMenuItems.Size = new Size(1063, 600);
            tpMenuItems.TabIndex = 1;
            tpMenuItems.Text = "Manage Menu Items";
            tpMenuItems.UseVisualStyleBackColor = true;
            // 
            // btnMenuItemsCloseAdminPanel
            // 
            btnMenuItemsCloseAdminPanel.Location = new Point(8, 552);
            btnMenuItemsCloseAdminPanel.Name = "btnMenuItemsCloseAdminPanel";
            btnMenuItemsCloseAdminPanel.Size = new Size(197, 40);
            btnMenuItemsCloseAdminPanel.TabIndex = 10;
            btnMenuItemsCloseAdminPanel.Text = "Close Admin Panel";
            btnMenuItemsCloseAdminPanel.UseVisualStyleBackColor = true;
            btnMenuItemsCloseAdminPanel.Click += btnMenuItemsCloseAdminPanel_Click;
            // 
            // tbxAllergensAdd
            // 
            tbxAllergensAdd.Location = new Point(684, 164);
            tbxAllergensAdd.Name = "tbxAllergensAdd";
            tbxAllergensAdd.Size = new Size(370, 35);
            tbxAllergensAdd.TabIndex = 9;
            // 
            // tbxItemNameAdd
            // 
            tbxItemNameAdd.Location = new Point(684, 123);
            tbxItemNameAdd.Name = "tbxItemNameAdd";
            tbxItemNameAdd.Size = new Size(370, 35);
            tbxItemNameAdd.TabIndex = 8;
            // 
            // lblAllergensAdd
            // 
            lblAllergensAdd.AutoSize = true;
            lblAllergensAdd.Location = new Point(574, 167);
            lblAllergensAdd.Name = "lblAllergensAdd";
            lblAllergensAdd.Size = new Size(104, 30);
            lblAllergensAdd.TabIndex = 7;
            lblAllergensAdd.Text = "Allergens:";
            // 
            // lblItemNameAdd
            // 
            lblItemNameAdd.AutoSize = true;
            lblItemNameAdd.Location = new Point(556, 126);
            lblItemNameAdd.Name = "lblItemNameAdd";
            lblItemNameAdd.Size = new Size(122, 30);
            lblItemNameAdd.TabIndex = 6;
            lblItemNameAdd.Text = "Item Name:";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(556, 205);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(504, 40);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += button2_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(553, 69);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(507, 40);
            btnDeleteItem.TabIndex = 4;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // lblAllergensRemove
            // 
            lblAllergensRemove.AutoSize = true;
            lblAllergensRemove.Location = new Point(574, 36);
            lblAllergensRemove.Name = "lblAllergensRemove";
            lblAllergensRemove.Size = new Size(104, 30);
            lblAllergensRemove.TabIndex = 3;
            lblAllergensRemove.Text = "Allergens:";
            // 
            // lblItemNameRemove
            // 
            lblItemNameRemove.AutoSize = true;
            lblItemNameRemove.Location = new Point(556, 6);
            lblItemNameRemove.Name = "lblItemNameRemove";
            lblItemNameRemove.Size = new Size(122, 30);
            lblItemNameRemove.TabIndex = 1;
            lblItemNameRemove.Text = "Item Name:";
            // 
            // lbxMenuItems
            // 
            lbxMenuItems.FormattingEnabled = true;
            lbxMenuItems.ItemHeight = 30;
            lbxMenuItems.Location = new Point(8, 6);
            lbxMenuItems.Name = "lbxMenuItems";
            lbxMenuItems.Size = new Size(542, 544);
            lbxMenuItems.TabIndex = 0;
            // 
            // tpUserManagement
            // 
            tpUserManagement.Controls.Add(tbxPasswordAdd);
            tpUserManagement.Controls.Add(tbxUsernameAdd);
            tpUserManagement.Controls.Add(lblPasswordRemove);
            tpUserManagement.Controls.Add(lblUsernameRemove);
            tpUserManagement.Controls.Add(btnAddUser);
            tpUserManagement.Controls.Add(btnDeleteUser);
            tpUserManagement.Controls.Add(lblPassword);
            tpUserManagement.Controls.Add(lblUsername);
            tpUserManagement.Controls.Add(btnUsersCloseAdminPanel);
            tpUserManagement.Controls.Add(lbxUsers);
            tpUserManagement.Location = new Point(4, 39);
            tpUserManagement.Name = "tpUserManagement";
            tpUserManagement.Size = new Size(1063, 600);
            tpUserManagement.TabIndex = 2;
            tpUserManagement.Text = "User Management";
            tpUserManagement.UseVisualStyleBackColor = true;
            // 
            // tbxPasswordAdd
            // 
            tbxPasswordAdd.Location = new Point(673, 162);
            tbxPasswordAdd.Name = "tbxPasswordAdd";
            tbxPasswordAdd.Size = new Size(381, 35);
            tbxPasswordAdd.TabIndex = 20;
            // 
            // tbxUsernameAdd
            // 
            tbxUsernameAdd.Location = new Point(673, 121);
            tbxUsernameAdd.Name = "tbxUsernameAdd";
            tbxUsernameAdd.Size = new Size(381, 35);
            tbxUsernameAdd.TabIndex = 19;
            // 
            // lblPasswordRemove
            // 
            lblPasswordRemove.AutoSize = true;
            lblPasswordRemove.Location = new Point(563, 165);
            lblPasswordRemove.Name = "lblPasswordRemove";
            lblPasswordRemove.Size = new Size(104, 30);
            lblPasswordRemove.TabIndex = 18;
            lblPasswordRemove.Text = "Password:";
            // 
            // lblUsernameRemove
            // 
            lblUsernameRemove.AutoSize = true;
            lblUsernameRemove.Location = new Point(556, 124);
            lblUsernameRemove.Name = "lblUsernameRemove";
            lblUsernameRemove.Size = new Size(111, 30);
            lblUsernameRemove.TabIndex = 17;
            lblUsernameRemove.Text = "Username:";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(556, 203);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(507, 40);
            btnAddUser.TabIndex = 16;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(556, 72);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(507, 40);
            btnDeleteUser.TabIndex = 15;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(563, 39);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(104, 30);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(556, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(111, 30);
            lblUsername.TabIndex = 13;
            lblUsername.Text = "Username:";
            // 
            // btnUsersCloseAdminPanel
            // 
            btnUsersCloseAdminPanel.Location = new Point(3, 552);
            btnUsersCloseAdminPanel.Name = "btnUsersCloseAdminPanel";
            btnUsersCloseAdminPanel.Size = new Size(197, 40);
            btnUsersCloseAdminPanel.TabIndex = 12;
            btnUsersCloseAdminPanel.Text = "Close Admin Panel";
            btnUsersCloseAdminPanel.UseVisualStyleBackColor = true;
            btnUsersCloseAdminPanel.Click += btnUsersCloseAdminPanel_Click;
            // 
            // lbxUsers
            // 
            lbxUsers.FormattingEnabled = true;
            lbxUsers.ItemHeight = 30;
            lbxUsers.Location = new Point(8, 3);
            lbxUsers.Name = "lbxUsers";
            lbxUsers.Size = new Size(542, 544);
            lbxUsers.TabIndex = 11;
            // 
            // Admin_Panel
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 642);
            ControlBox = false;
            Controls.Add(tabControl1);
            Name = "Admin_Panel";
            Text = "MealMate v0.1 - Admin Panel";
            tabControl1.ResumeLayout(false);
            tpOrders.ResumeLayout(false);
            tpOrders.PerformLayout();
            tpMenuItems.ResumeLayout(false);
            tpMenuItems.PerformLayout();
            tpUserManagement.ResumeLayout(false);
            tpUserManagement.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpOrders;
        private TabPage tpMenuItems;
        private TabPage tpUserManagement;
        private Button btnOrdersCloseAdminPanel;
        private Button btnServeOrder;
        private ListBox lbxOrders;
        private Label lblNumberOfDishes;
        private Label lblOrderType;
        private Label lblAllergensRemove;
        private Label lblItemNameRemove;
        private ListBox lbxMenuItems;
        private Label lblItemNameAdd;
        private Button btnAddItem;
        private Button btnDeleteItem;
        private Label lblAllergensAdd;
        private TextBox tbxAllergensAdd;
        private TextBox tbxItemNameAdd;
        private Button btnMenuItemsCloseAdminPanel;
        private Button btnUsersCloseAdminPanel;
        private ListBox lbxUsers;
        private TextBox tbxPasswordAdd;
        private TextBox tbxUsernameAdd;
        private Label lblPasswordRemove;
        private Label lblUsernameRemove;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Label lblPassword;
        private Label lblUsername;
    }
}