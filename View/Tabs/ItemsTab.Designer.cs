namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            ItemsListBox = new ListBox();
            OrderByLabel = new Label();
            OrderByComboBox = new ComboBox();
            AddItemBtn = new Button();
            RemoveItemBtn = new Button();
            SelectedItemGroupBox = new GroupBox();
            IdLabel = new Label();
            IDItemTextBox = new TextBox();
            CostLabel = new Label();
            CostItemTextBox = new TextBox();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            NameLabel = new Label();
            NameItemTextBox = new TextBox();
            DescriptionLabel = new Label();
            DescriptionItemTextBox = new TextBox();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(RemoveItemBtn);
            ItemsGroupBox.Controls.Add(AddItemBtn);
            ItemsGroupBox.Controls.Add(OrderByComboBox);
            ItemsGroupBox.Controls.Add(OrderByLabel);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Controls.Add(FindTextBox);
            ItemsGroupBox.Controls.Add(FindLabel);
            ItemsGroupBox.Dock = DockStyle.Left;
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Margin = new Padding(3, 2, 3, 2);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Padding = new Padding(3, 2, 3, 2);
            ItemsGroupBox.Size = new Size(394, 540);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(8, 25);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 0;
            FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(52, 22);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(334, 23);
            FindTextBox.TabIndex = 1;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(8, 52);
            ItemsListBox.Margin = new Padding(3, 2, 3, 2);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(378, 379);
            ItemsListBox.TabIndex = 2;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // OrderByLabel
            // 
            OrderByLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrderByLabel.AutoSize = true;
            OrderByLabel.Location = new Point(8, 444);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(55, 15);
            OrderByLabel.TabIndex = 3;
            OrderByLabel.Text = "Order by:";
            // 
            // OrderByComboBox
            // 
            OrderByComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrderByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OrderByComboBox.FormattingEnabled = true;
            OrderByComboBox.Location = new Point(72, 441);
            OrderByComboBox.Name = "OrderByComboBox";
            OrderByComboBox.Size = new Size(314, 23);
            OrderByComboBox.TabIndex = 4;
            OrderByComboBox.SelectedIndexChanged += OrderByComboBox_SelectedIndexChanged;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemBtn.Location = new Point(8, 476);
            AddItemBtn.Margin = new Padding(3, 2, 3, 2);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(136, 55);
            AddItemBtn.TabIndex = 5;
            AddItemBtn.Text = "Add";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // RemoveItemBtn
            // 
            RemoveItemBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemBtn.Location = new Point(250, 476);
            RemoveItemBtn.Margin = new Padding(3, 2, 3, 2);
            RemoveItemBtn.Name = "RemoveItemBtn";
            RemoveItemBtn.Size = new Size(136, 55);
            RemoveItemBtn.TabIndex = 6;
            RemoveItemBtn.Text = "Remove";
            RemoveItemBtn.UseVisualStyleBackColor = true;
            RemoveItemBtn.Click += RemoveItemBtn_Click;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(DescriptionItemTextBox);
            SelectedItemGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemGroupBox.Controls.Add(NameItemTextBox);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CategoryComboBox);
            SelectedItemGroupBox.Controls.Add(CategoryLabel);
            SelectedItemGroupBox.Controls.Add(CostItemTextBox);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IDItemTextBox);
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Location = new Point(402, 0);
            SelectedItemGroupBox.Margin = new Padding(3, 2, 3, 2);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Padding = new Padding(3, 2, 3, 2);
            SelectedItemGroupBox.Size = new Size(576, 540);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(15, 27);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // IDItemTextBox
            // 
            IDItemTextBox.Location = new Point(85, 24);
            IDItemTextBox.Name = "IDItemTextBox";
            IDItemTextBox.ReadOnly = true;
            IDItemTextBox.Size = new Size(235, 23);
            IDItemTextBox.TabIndex = 1;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(15, 57);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 2;
            CostLabel.Text = "Cost:";
            // 
            // CostItemTextBox
            // 
            CostItemTextBox.Location = new Point(85, 54);
            CostItemTextBox.Name = "CostItemTextBox";
            CostItemTextBox.Size = new Size(235, 23);
            CostItemTextBox.TabIndex = 3;
            CostItemTextBox.TextChanged += CostItemTextBox_TextChanged;
            CostItemTextBox.Leave += CostItemTextBox_Leave;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(15, 87);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 4;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(85, 84);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(235, 23);
            CategoryComboBox.TabIndex = 5;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(15, 117);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // NameItemTextBox
            // 
            NameItemTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameItemTextBox.Location = new Point(85, 114);
            NameItemTextBox.Name = "NameItemTextBox";
            NameItemTextBox.Size = new Size(475, 23);
            NameItemTextBox.TabIndex = 7;
            NameItemTextBox.TextChanged += NameItemTextBox_TextChanged;
            NameItemTextBox.Leave += NameItemTextBox_Leave;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(15, 147);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 8;
            DescriptionLabel.Text = "Description:";
            // 
            // DescriptionItemTextBox
            // 
            DescriptionItemTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionItemTextBox.Location = new Point(85, 144);
            DescriptionItemTextBox.Multiline = true;
            DescriptionItemTextBox.Name = "DescriptionItemTextBox";
            DescriptionItemTextBox.Size = new Size(475, 140);
            DescriptionItemTextBox.TabIndex = 9;
            DescriptionItemTextBox.TextChanged += DescriptionItemTextBox_TextChanged;
            DescriptionItemTextBox.Leave += DescriptionItemTextBox_Leave;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ItemsTab";
            Size = new Size(984, 540);
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Label FindLabel;
        private TextBox FindTextBox;
        private ListBox ItemsListBox;
        private Label OrderByLabel;
        private ComboBox OrderByComboBox;
        private Button AddItemBtn;
        private Button RemoveItemBtn;
        private GroupBox SelectedItemGroupBox;
        private Label IdLabel;
        private TextBox IDItemTextBox;
        private Label CostLabel;
        private TextBox CostItemTextBox;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Label NameLabel;
        private TextBox NameItemTextBox;
        private Label DescriptionLabel;
        private TextBox DescriptionItemTextBox;
    }
}