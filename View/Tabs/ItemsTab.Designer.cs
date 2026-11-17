namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            ItemsRemoveBtn = new Button();
            ItemsAddBtn = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            CategoryComboBox = new ComboBox();
            label5 = new Label();
            InfoTextBox = new TextBox();
            label4 = new Label();
            NameTextBox = new TextBox();
            label3 = new Label();
            CostTextBox = new TextBox();
            label2 = new Label();
            IDTextBox = new TextBox();
            label1 = new Label();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(ItemsRemoveBtn);
            ItemsGroupBox.Controls.Add(ItemsAddBtn);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Margin = new Padding(3, 2, 3, 2);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Padding = new Padding(3, 2, 3, 2);
            ItemsGroupBox.Size = new Size(394, 556);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // ItemsRemoveBtn
            // 
            ItemsRemoveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsRemoveBtn.Location = new Point(253, 492);
            ItemsRemoveBtn.Margin = new Padding(3, 2, 3, 2);
            ItemsRemoveBtn.Name = "ItemsRemoveBtn";
            ItemsRemoveBtn.Size = new Size(136, 55);
            ItemsRemoveBtn.TabIndex = 2;
            ItemsRemoveBtn.Text = "Remove";
            ItemsRemoveBtn.UseVisualStyleBackColor = true;
            ItemsRemoveBtn.Click += ItemsRemoveBtn_Click;
            // 
            // ItemsAddBtn
            // 
            ItemsAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsAddBtn.Location = new Point(5, 492);
            ItemsAddBtn.Margin = new Padding(3, 2, 3, 2);
            ItemsAddBtn.Name = "ItemsAddBtn";
            ItemsAddBtn.Size = new Size(136, 55);
            ItemsAddBtn.TabIndex = 1;
            ItemsAddBtn.Text = "Add";
            ItemsAddBtn.UseVisualStyleBackColor = true;
            ItemsAddBtn.Click += ItemsAddBtn_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(5, 20);
            ItemsListBox.Margin = new Padding(3, 2, 3, 2);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(384, 469);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(CategoryComboBox);
            SelectedItemGroupBox.Controls.Add(label5);
            SelectedItemGroupBox.Controls.Add(InfoTextBox);
            SelectedItemGroupBox.Controls.Add(label4);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(label3);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(label2);
            SelectedItemGroupBox.Controls.Add(IDTextBox);
            SelectedItemGroupBox.Controls.Add(label1);
            SelectedItemGroupBox.Location = new Point(402, 0);
            SelectedItemGroupBox.Margin = new Padding(3, 2, 3, 2);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Padding = new Padding(3, 2, 3, 2);
            SelectedItemGroupBox.Size = new Size(350, 556);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(91, 108);
            CategoryComboBox.Margin = new Padding(3, 2, 3, 2);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(243, 23);
            CategoryComboBox.TabIndex = 9;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 111);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Category:";
            // 
            // InfoTextBox
            // 
            InfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InfoTextBox.Location = new Point(15, 290);
            InfoTextBox.Margin = new Padding(3, 2, 3, 2);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(319, 255);
            InfoTextBox.TabIndex = 7;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            InfoTextBox.Leave += InfoTextBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 268);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(15, 175);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(319, 74);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 153);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.Location = new Point(91, 71);
            CostTextBox.Margin = new Padding(3, 2, 3, 2);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(243, 23);
            CostTextBox.TabIndex = 3;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            CostTextBox.Leave += CostTextBox_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Cost:";
            // 
            // IDTextBox
            // 
            IDTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IDTextBox.Location = new Point(91, 34);
            IDTextBox.Margin = new Padding(3, 2, 3, 2);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(243, 23);
            IDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ItemsTab";
            Size = new Size(752, 556);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button ItemsAddBtn;
        private ListBox ItemsListBox;
        private Button ItemsRemoveBtn;
        private GroupBox SelectedItemGroupBox;
        private Label label1;
        private TextBox IDTextBox;
        private TextBox CostTextBox;
        private Label label2;
        private Label label3;
        private TextBox InfoTextBox;
        private Label label4;
        private TextBox NameTextBox;
        private Label label5;
        private ComboBox CategoryComboBox;
    }
}