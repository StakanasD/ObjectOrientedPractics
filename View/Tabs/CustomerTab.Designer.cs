namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            CustomersGroupBox = new GroupBox();
            CustomersRemoveBtn = new Button();
            CustomersAddBtn = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            addressControl1 = new AddressControl();
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
            CustomersGroupBox.Size = new Size(394, 610);
            CustomersGroupBox.TabIndex = 2;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            CustomersGroupBox.Enter += CustomersGroupBox_Enter;
            // 
            // CustomersRemoveBtn
            // 
            CustomersRemoveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersRemoveBtn.Location = new Point(258, 538);
            CustomersRemoveBtn.Margin = new Padding(3, 2, 3, 2);
            CustomersRemoveBtn.Name = "CustomersRemoveBtn";
            CustomersRemoveBtn.Size = new Size(136, 63);
            CustomersRemoveBtn.TabIndex = 2;
            CustomersRemoveBtn.Text = "Remove";
            CustomersRemoveBtn.UseVisualStyleBackColor = true;
            CustomersRemoveBtn.Click += CustomersRemoveBtn_Click;
            // 
            // CustomersAddBtn
            // 
            CustomersAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersAddBtn.Location = new Point(5, 538);
            CustomersAddBtn.Margin = new Padding(3, 2, 3, 2);
            CustomersAddBtn.Name = "CustomersAddBtn";
            CustomersAddBtn.Size = new Size(136, 63);
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
            CustomersListBox.Size = new Size(384, 514);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(addressControl1);
            SelectedCustomerGroupBox.Controls.Add(NameCustomerTextBox);
            SelectedCustomerGroupBox.Controls.Add(label3);
            SelectedCustomerGroupBox.Controls.Add(IDCustomerTextBox);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Location = new Point(402, 2);
            SelectedCustomerGroupBox.Margin = new Padding(3, 2, 3, 2);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Padding = new Padding(3, 2, 3, 2);
            SelectedCustomerGroupBox.Size = new Size(632, 573);
            SelectedCustomerGroupBox.TabIndex = 3;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Item";
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
            addressControl1.Location = new Point(0, 118);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(636, 254);
            addressControl1.TabIndex = 6;
            // 
            // NameCustomerTextBox
            // 
            NameCustomerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameCustomerTextBox.Location = new Point(15, 82);
            NameCustomerTextBox.Margin = new Padding(3, 2, 3, 2);
            NameCustomerTextBox.Name = "NameCustomerTextBox";
            NameCustomerTextBox.Size = new Size(612, 23);
            NameCustomerTextBox.TabIndex = 5;
            NameCustomerTextBox.TextChanged += NameCustomerTextBox_TextChanged;
            NameCustomerTextBox.Leave += NameCustomerTextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 64);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Full Name:";
            // 
            // IDCustomerTextBox
            // 
            IDCustomerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDCustomerTextBox.Location = new Point(67, 34);
            IDCustomerTextBox.Margin = new Padding(3, 2, 3, 2);
            IDCustomerTextBox.Name = "IDCustomerTextBox";
            IDCustomerTextBox.ReadOnly = true;
            IDCustomerTextBox.Size = new Size(422, 23);
            IDCustomerTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersGroupBox);
            Controls.Add(SelectedCustomerGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerTab";
            Size = new Size(1072, 610);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox CostTextBox;
        private GroupBox CustomersGroupBox;
        private Button CustomersRemoveBtn;
        private Button CustomersAddBtn;
        private ListBox CustomersListBox;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox NameCustomerTextBox;
        private Label label3;
        private Label label2;
        private TextBox IDCustomerTextBox;
        private Label label1;
        private AddressControl addressControl1;
    }
}
