namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            label1 = new Label();
            CartItemsListBox = new ListBox();
            CartAddBtn = new Button();
            label2 = new Label();
            CartCustomerComboBox = new ComboBox();
            label3 = new Label();
            CartListBox = new ListBox();
            label4 = new Label();
            AmountLabel = new Label();
            CreateOrderBtn = new Button();
            RemoveItemBtn = new Button();
            ClearBtn = new Button();
            DiscountsCaptionLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            DiscountAmountCaptionLabel = new Label();
            DiscountAmountLabel = new Label();
            TotalCaptionLabel = new Label();
            TotalLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // CartItemsListBox
            // 
            CartItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CartItemsListBox.FormattingEnabled = true;
            CartItemsListBox.ItemHeight = 15;
            CartItemsListBox.Location = new Point(3, 29);
            CartItemsListBox.Margin = new Padding(3, 2, 3, 2);
            CartItemsListBox.Name = "CartItemsListBox";
            CartItemsListBox.Size = new Size(311, 469);
            CartItemsListBox.TabIndex = 1;
            // 
            // CartAddBtn
            // 
            CartAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CartAddBtn.Location = new Point(3, 502);
            CartAddBtn.Margin = new Padding(3, 2, 3, 2);
            CartAddBtn.Name = "CartAddBtn";
            CartAddBtn.Size = new Size(94, 37);
            CartAddBtn.TabIndex = 2;
            CartAddBtn.Text = "Add to Cart";
            CartAddBtn.UseVisualStyleBackColor = true;
            CartAddBtn.Click += CartAddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 29);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Customer:";
            // 
            // CartCustomerComboBox
            // 
            CartCustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartCustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CartCustomerComboBox.FormattingEnabled = true;
            CartCustomerComboBox.Location = new Point(406, 26);
            CartCustomerComboBox.Margin = new Padding(3, 2, 3, 2);
            CartCustomerComboBox.Name = "CartCustomerComboBox";
            CartCustomerComboBox.Size = new Size(566, 23);
            CartCustomerComboBox.TabIndex = 4;
            CartCustomerComboBox.SelectedIndexChanged += CartCustomerComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 62);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Cart:";
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(335, 80);
            CartListBox.Margin = new Padding(3, 2, 3, 2);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(637, 169);
            CartListBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(914, 254);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(890, 272);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(48, 22);
            AmountLabel.TabIndex = 8;
            AmountLabel.Text = "0,00";
            // 
            // CreateOrderBtn
            // 
            CreateOrderBtn.Location = new Point(335, 304);
            CreateOrderBtn.Margin = new Padding(3, 2, 3, 2);
            CreateOrderBtn.Name = "CreateOrderBtn";
            CreateOrderBtn.Size = new Size(118, 36);
            CreateOrderBtn.TabIndex = 9;
            CreateOrderBtn.Text = "Create Order";
            CreateOrderBtn.UseVisualStyleBackColor = true;
            CreateOrderBtn.Click += CreateOrderBtn_Click;
            // 
            // RemoveItemBtn
            // 
            RemoveItemBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemBtn.Location = new Point(726, 304);
            RemoveItemBtn.Margin = new Padding(3, 2, 3, 2);
            RemoveItemBtn.Name = "RemoveItemBtn";
            RemoveItemBtn.Size = new Size(118, 36);
            RemoveItemBtn.TabIndex = 10;
            RemoveItemBtn.Text = "Remove Item";
            RemoveItemBtn.UseVisualStyleBackColor = true;
            RemoveItemBtn.Click += RemoveItemBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearBtn.Location = new Point(854, 304);
            ClearBtn.Margin = new Padding(3, 2, 3, 2);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(118, 36);
            ClearBtn.TabIndex = 11;
            ClearBtn.Text = "Clear Cart";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DiscountsCaptionLabel
            // 
            DiscountsCaptionLabel.AutoSize = true;
            DiscountsCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountsCaptionLabel.Location = new Point(335, 352);
            DiscountsCaptionLabel.Name = "DiscountsCaptionLabel";
            DiscountsCaptionLabel.Size = new Size(64, 15);
            DiscountsCaptionLabel.TabIndex = 12;
            DiscountsCaptionLabel.Text = "Discounts:";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsCheckedListBox.BackColor = SystemColors.Control;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.CheckOnClick = true;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.IntegralHeight = false;
            DiscountsCheckedListBox.Location = new Point(335, 372);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(380, 165);
            DiscountsCheckedListBox.TabIndex = 13;
            DiscountsCheckedListBox.ItemCheck += DiscountsCheckedListBox_ItemCheck;
            // 
            // DiscountAmountCaptionLabel
            // 
            DiscountAmountCaptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountAmountCaptionLabel.AutoSize = true;
            DiscountAmountCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountCaptionLabel.Location = new Point(862, 355);
            DiscountAmountCaptionLabel.Name = "DiscountAmountCaptionLabel";
            DiscountAmountCaptionLabel.Size = new Size(106, 15);
            DiscountAmountCaptionLabel.TabIndex = 14;
            DiscountAmountCaptionLabel.Text = "Discount Amount:";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(890, 375);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(48, 22);
            DiscountAmountLabel.TabIndex = 15;
            DiscountAmountLabel.Text = "0,00";
            // 
            // TotalCaptionLabel
            // 
            TotalCaptionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCaptionLabel.AutoSize = true;
            TotalCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCaptionLabel.Location = new Point(924, 485);
            TotalCaptionLabel.Name = "TotalCaptionLabel";
            TotalCaptionLabel.Size = new Size(44, 15);
            TotalCaptionLabel.TabIndex = 16;
            TotalCaptionLabel.Text = "TOTAL:";
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalLabel.Location = new Point(890, 505);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(48, 22);
            TotalLabel.TabIndex = 17;
            TotalLabel.Text = "0,00";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TotalLabel);
            Controls.Add(TotalCaptionLabel);
            Controls.Add(DiscountAmountLabel);
            Controls.Add(DiscountAmountCaptionLabel);
            Controls.Add(DiscountsCheckedListBox);
            Controls.Add(DiscountsCaptionLabel);
            Controls.Add(ClearBtn);
            Controls.Add(RemoveItemBtn);
            Controls.Add(CreateOrderBtn);
            Controls.Add(AmountLabel);
            Controls.Add(label4);
            Controls.Add(CartListBox);
            Controls.Add(label3);
            Controls.Add(CartCustomerComboBox);
            Controls.Add(label2);
            Controls.Add(CartAddBtn);
            Controls.Add(CartItemsListBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CartsTab";
            Size = new Size(984, 543);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox CartItemsListBox;
        private Button CartAddBtn;
        private Label label2;
        private ComboBox CartCustomerComboBox;
        private Label label3;
        private ListBox CartListBox;
        private Label label4;
        private Label AmountLabel;
        private Button CreateOrderBtn;
        private Button RemoveItemBtn;
        private Button ClearBtn;
        private Label DiscountsCaptionLabel;
        private CheckedListBox DiscountsCheckedListBox;
        private Label DiscountAmountCaptionLabel;
        private Label DiscountAmountLabel;
        private Label TotalCaptionLabel;
        private Label TotalLabel;
    }
}