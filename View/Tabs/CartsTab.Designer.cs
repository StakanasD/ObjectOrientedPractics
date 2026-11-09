namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            CartItemsListBox.Size = new Size(311, 484);
            CartItemsListBox.TabIndex = 1;
            // 
            // CartAddBtn
            // 
            CartAddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CartAddBtn.Location = new Point(3, 517);
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
            CartCustomerComboBox.FormattingEnabled = true;
            CartCustomerComboBox.Location = new Point(406, 29);
            CartCustomerComboBox.Margin = new Padding(3, 2, 3, 2);
            CartCustomerComboBox.Name = "CartCustomerComboBox";
            CartCustomerComboBox.Size = new Size(335, 23);
            CartCustomerComboBox.TabIndex = 4;
            CartCustomerComboBox.SelectedIndexChanged += CartCustomerComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 68);
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
            CartListBox.Location = new Point(335, 86);
            CartListBox.Margin = new Padding(3, 2, 3, 2);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(406, 184);
            CartListBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(683, 280);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Amount:";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(671, 302);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(37, 22);
            AmountLabel.TabIndex = 8;
            AmountLabel.Text = "0.0";
            // 
            // CreateOrderBtn
            // 
            CreateOrderBtn.Location = new Point(335, 338);
            CreateOrderBtn.Margin = new Padding(3, 2, 3, 2);
            CreateOrderBtn.Name = "CreateOrderBtn";
            CreateOrderBtn.Size = new Size(118, 40);
            CreateOrderBtn.TabIndex = 9;
            CreateOrderBtn.Text = "Create Order";
            CreateOrderBtn.UseVisualStyleBackColor = true;
            CreateOrderBtn.Click += CreateOrderBtn_Click;
            // 
            // RemoveItemBtn
            // 
            RemoveItemBtn.Location = new Point(499, 338);
            RemoveItemBtn.Margin = new Padding(3, 2, 3, 2);
            RemoveItemBtn.Name = "RemoveItemBtn";
            RemoveItemBtn.Size = new Size(118, 40);
            RemoveItemBtn.TabIndex = 10;
            RemoveItemBtn.Text = "Remove Item";
            RemoveItemBtn.UseVisualStyleBackColor = true;
            RemoveItemBtn.Click += RemoveItemBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(622, 338);
            ClearBtn.Margin = new Padding(3, 2, 3, 2);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(118, 40);
            ClearBtn.TabIndex = 11;
            ClearBtn.Text = "Clear Cart";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(752, 556);
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
    }
}
