namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            ItemsTabPage = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            customerTab1 = new ObjectOrientedPractics.View.Tabs.CustomerTab();
            CartTabPage = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            OrdersTabPage = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabControl1.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            CartTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTabPage);
            tabControl1.Controls.Add(CustomersTabPage);
            tabControl1.Controls.Add(CartTabPage);
            tabControl1.Controls.Add(OrdersTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(992, 571);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Margin = new Padding(3, 2, 3, 2);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3, 2, 3, 2);
            ItemsTabPage.Size = new Size(984, 543);
            ItemsTabPage.TabIndex = 1;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 2);
            itemsTab1.Margin = new Padding(3, 2, 3, 2);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(978, 539);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customerTab1);
            CustomersTabPage.Location = new Point(4, 24);
            CustomersTabPage.Margin = new Padding(3, 2, 3, 2);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3, 2, 3, 2);
            CustomersTabPage.Size = new Size(984, 543);
            CustomersTabPage.TabIndex = 2;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customerTab1
            // 
            customerTab1.Dock = DockStyle.Fill;
            customerTab1.Location = new Point(3, 2);
            customerTab1.Margin = new Padding(3, 2, 3, 2);
            customerTab1.Name = "customerTab1";
            customerTab1.Size = new Size(978, 539);
            customerTab1.TabIndex = 0;
            // 
            // CartTabPage
            // 
            CartTabPage.Controls.Add(cartsTab1);
            CartTabPage.Location = new Point(4, 24);
            CartTabPage.Margin = new Padding(3, 2, 3, 2);
            CartTabPage.Name = "CartTabPage";
            CartTabPage.Size = new Size(984, 543);
            CartTabPage.TabIndex = 3;
            CartTabPage.Text = "Cart";
            CartTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Customers = null;
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Items = null;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Margin = new Padding(3, 2, 3, 2);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(984, 543);
            cartsTab1.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(ordersTab1);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Margin = new Padding(3, 2, 3, 2);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Size = new Size(984, 543);
            OrdersTabPage.TabIndex = 4;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Customers = null;
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Margin = new Padding(3, 2, 3, 2);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(984, 543);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 571);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(702, 610);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            CartTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private View.Tabs.CustomerTab customerTab1;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage CartTabPage;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage OrdersTabPage;
        private View.Tabs.OrdersTab ordersTab1;
    }
}

