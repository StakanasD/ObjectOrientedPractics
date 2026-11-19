namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            CustomersGroupBox = new GroupBox();
            CustomersRemoveBtn = new Button();
            CustomersAddBtn = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            RemoveDiscountBtn = new Button();
            AddDiscountBtn = new Button();
            DiscountsListBox = new ListBox();
            DiscountsLabel = new Label();
            IsPriorityCheckBox = new CheckBox();
            addressControl1 = new Controls.AddressControl();
            NameCustomerTextBox = new TextBox();
            label3 = new Label();
            IDCustomerTextBox = new TextBox();
            label1 = new Label();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(CustomersRemoveBtn);
            CustomersGroupBox.Controls.Add(CustomersAddBtn);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Left;
            CustomersGroupBox.Location = new Point(0, 0);
            CustomersGroupBox.Margin = new Padding(3, 2, 3, 2);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Padding = new Padding(3, 2, 3, 2);
            CustomersGroupBox.Size = new Size(394, 540);
            CustomersGroupBox.TabIndex = 2;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // CustomersRemoveBtn
            // 
            CustomersRemoveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersRemoveBtn.Location = new Point(253, 476);
            CustomersRemoveBtn.Margin = new Padding(3, 2, 3, 2);
            CustomersRemoveBtn.Name = "CustomersRemoveBtn";
            CustomersRemoveBtn.Size = new Size(136, 55);
            CustomersRemoveBtn.TabIndex = 2;
            CustomersRemoveBtn.Text = "Remove";
            CustomersRemoveBtn.UseVisualStyleBackColor = true;
            CustomersRemoveBtn.Click += CustomersRemoveBtn_Click;
            // 
            // CustomersAddBtn
            // 
            CustomersAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersAddBtn.Location = new Point(5, 476);
            CustomersAddBtn.Margin = new Padding(3, 2, 3, 2);
            CustomersAddBtn.Name = "CustomersAddBtn";
            CustomersAddBtn.Size = new Size(136, 55);
            CustomersAddBtn.TabIndex = 1;
            CustomersAddBtn.Text = "Add";
            CustomersAddBtn.UseVisualStyleBackColor = true;
            CustomersAddBtn.Click += CustomersAddBtn_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(5, 20);
            CustomersListBox.Margin = new Padding(3, 2, 3, 2);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(384, 454);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(RemoveDiscountBtn);
            SelectedCustomerGroupBox.Controls.Add(AddDiscountBtn);
            SelectedCustomerGroupBox.Controls.Add(DiscountsListBox);
            SelectedCustomerGroupBox.Controls.Add(DiscountsLabel);
            SelectedCustomerGroupBox.Controls.Add(IsPriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(addressControl1);
            SelectedCustomerGroupBox.Controls.Add(NameCustomerTextBox);
            SelectedCustomerGroupBox.Controls.Add(label3);
            SelectedCustomerGroupBox.Controls.Add(IDCustomerTextBox);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Location = new Point(402, 0);
            SelectedCustomerGroupBox.Margin = new Padding(3, 2, 3, 2);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Padding = new Padding(3, 2, 3, 2);
            SelectedCustomerGroupBox.Size = new Size(576, 540);
            SelectedCustomerGroupBox.TabIndex = 3;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // IDCustomerTextBox
            // 
            IDCustomerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDCustomerTextBox.Location = new Point(67, 24);
            IDCustomerTextBox.Margin = new Padding(3, 2, 3, 2);
            IDCustomerTextBox.Name = "IDCustomerTextBox";
            IDCustomerTextBox.ReadOnly = true;
            IDCustomerTextBox.Size = new Size(200, 23);
            IDCustomerTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 53);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Full Name:";
            // 
            // NameCustomerTextBox
            // 
            NameCustomerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameCustomerTextBox.Location = new Point(15, 71);
            NameCustomerTextBox.Margin = new Padding(3, 2, 3, 2);
            NameCustomerTextBox.Name = "NameCustomerTextBox";
            NameCustomerTextBox.Size = new Size(545, 23);
            NameCustomerTextBox.TabIndex = 5;
            NameCustomerTextBox.TextChanged += NameCustomerTextBox_TextChanged;
            NameCustomerTextBox.Leave += NameCustomerTextBox_Leave;
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(15, 99);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(76, 19);
            IsPriorityCheckBox.TabIndex = 7;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // addressControl1
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            addressControl1.Address = address1;
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Location = new Point(3, 122);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.ReadOnly = false;
            addressControl1.Size = new Size(568, 195);
            addressControl1.TabIndex = 6;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountsLabel.Location = new Point(15, 324);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(61, 15);
            DiscountsLabel.TabIndex = 8;
            DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 15;
            DiscountsListBox.Location = new Point(15, 344);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(430, 184);
            DiscountsListBox.TabIndex = 9;
            // 
            // AddDiscountBtn
            // 
            AddDiscountBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDiscountBtn.Location = new Point(455, 344);
            AddDiscountBtn.Name = "AddDiscountBtn";
            AddDiscountBtn.Size = new Size(105, 36);
            AddDiscountBtn.TabIndex = 10;
            AddDiscountBtn.Text = "Add";
            AddDiscountBtn.UseVisualStyleBackColor = true;
            AddDiscountBtn.Click += AddDiscountBtn_Click;
            // 
            // RemoveDiscountBtn
            // 
            RemoveDiscountBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveDiscountBtn.Location = new Point(455, 388);
            RemoveDiscountBtn.Name = "RemoveDiscountBtn";
            RemoveDiscountBtn.Size = new Size(105, 36);
            RemoveDiscountBtn.TabIndex = 11;
            RemoveDiscountBtn.Text = "Remove";
            RemoveDiscountBtn.UseVisualStyleBackColor = true;
            RemoveDiscountBtn.Click += RemoveDiscountBtn_Click;
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersGroupBox);
            Controls.Add(SelectedCustomerGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerTab";
            Size = new Size(984, 540);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private Button CustomersRemoveBtn;
        private Button CustomersAddBtn;
        private ListBox CustomersListBox;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox NameCustomerTextBox;
        private Label label3;
        private TextBox IDCustomerTextBox;
        private Label label1;
        private Controls.AddressControl addressControl1;
        private CheckBox IsPriorityCheckBox;
        private Label DiscountsLabel;
        private ListBox DiscountsListBox;
        private Button AddDiscountBtn;
        private Button RemoveDiscountBtn;
    }
}