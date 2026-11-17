namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            SelectedOrderHeaderLabel = new Label();
            IdLabel = new Label();
            CreatedLabel = new Label();
            StatusLabel = new Label();
            OrdersIdTextBox = new TextBox();
            OrdersDateTextBox = new TextBox();
            OrdersStatusComboBox = new ComboBox();
            PriorityOptionsHeaderLabel = new Label();
            DeliveryTimeLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            OrderItemsHeaderLabel = new Label();
            OrdersItemsListBox = new ListBox();
            AmountCaptionLabel = new Label();
            OrderAmountLabel = new Label();
            AddItemBtn = new Button();
            RemoveItemBtn = new Button();
            ClearOrderBtn = new Button();
            SuspendLayout();
            // 
            // SelectedOrderHeaderLabel
            // 
            SelectedOrderHeaderLabel.AutoSize = true;
            SelectedOrderHeaderLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderHeaderLabel.Location = new Point(12, 10);
            SelectedOrderHeaderLabel.Name = "SelectedOrderHeaderLabel";
            SelectedOrderHeaderLabel.Size = new Size(105, 17);
            SelectedOrderHeaderLabel.TabIndex = 0;
            SelectedOrderHeaderLabel.Text = "Selected Order";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(12, 42);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(12, 74);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 2;
            CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(12, 106);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // OrdersIdTextBox
            // 
            OrdersIdTextBox.Location = new Point(92, 39);
            OrdersIdTextBox.Name = "OrdersIdTextBox";
            OrdersIdTextBox.ReadOnly = true;
            OrdersIdTextBox.Size = new Size(180, 23);
            OrdersIdTextBox.TabIndex = 4;
            // 
            // OrdersDateTextBox
            // 
            OrdersDateTextBox.Location = new Point(92, 71);
            OrdersDateTextBox.Name = "OrdersDateTextBox";
            OrdersDateTextBox.ReadOnly = true;
            OrdersDateTextBox.Size = new Size(180, 23);
            OrdersDateTextBox.TabIndex = 5;
            // 
            // OrdersStatusComboBox
            // 
            OrdersStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OrdersStatusComboBox.FormattingEnabled = true;
            OrdersStatusComboBox.Location = new Point(92, 103);
            OrdersStatusComboBox.Name = "OrdersStatusComboBox";
            OrdersStatusComboBox.Size = new Size(180, 23);
            OrdersStatusComboBox.TabIndex = 6;
            OrdersStatusComboBox.SelectedIndexChanged += OrdersStatusComboBox_SelectedIndexChanged;
            // 
            // PriorityOptionsHeaderLabel
            // 
            PriorityOptionsHeaderLabel.AutoSize = true;
            PriorityOptionsHeaderLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOptionsHeaderLabel.Location = new Point(320, 10);
            PriorityOptionsHeaderLabel.Name = "PriorityOptionsHeaderLabel";
            PriorityOptionsHeaderLabel.Size = new Size(105, 17);
            PriorityOptionsHeaderLabel.TabIndex = 7;
            PriorityOptionsHeaderLabel.Text = "Priority Options";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(320, 42);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(82, 15);
            DeliveryTimeLabel.TabIndex = 8;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(415, 39);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(185, 23);
            DeliveryTimeComboBox.TabIndex = 9;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
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
            addressControl1.Location = new Point(12, 136);
            addressControl1.Name = "addressControl1";
            addressControl1.ReadOnly = false;
            addressControl1.Size = new Size(720, 240);
            addressControl1.TabIndex = 10;
            // 
            // OrderItemsHeaderLabel
            // 
            OrderItemsHeaderLabel.AutoSize = true;
            OrderItemsHeaderLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsHeaderLabel.Location = new Point(12, 382);
            OrderItemsHeaderLabel.Name = "OrderItemsHeaderLabel";
            OrderItemsHeaderLabel.Size = new Size(84, 17);
            OrderItemsHeaderLabel.TabIndex = 11;
            OrderItemsHeaderLabel.Text = "Order Items";
            // 
            // OrdersItemsListBox
            // 
            OrdersItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersItemsListBox.FormattingEnabled = true;
            OrdersItemsListBox.ItemHeight = 15;
            OrdersItemsListBox.Location = new Point(12, 404);
            OrdersItemsListBox.Name = "OrdersItemsListBox";
            OrdersItemsListBox.Size = new Size(720, 124);
            OrdersItemsListBox.TabIndex = 12;
            // 
            // AmountCaptionLabel
            // 
            AmountCaptionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountCaptionLabel.AutoSize = true;
            AmountCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountCaptionLabel.Location = new Point(675, 534);
            AmountCaptionLabel.Name = "AmountCaptionLabel";
            AmountCaptionLabel.Size = new Size(57, 15);
            AmountCaptionLabel.TabIndex = 13;
            AmountCaptionLabel.Text = "Amount:";
            // 
            // OrderAmountLabel
            // 
            OrderAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OrderAmountLabel.AutoSize = true;
            OrderAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderAmountLabel.Location = new Point(660, 552);
            OrderAmountLabel.Name = "OrderAmountLabel";
            OrderAmountLabel.Size = new Size(49, 25);
            OrderAmountLabel.TabIndex = 14;
            OrderAmountLabel.Text = "0,00";
            // 
            // AddItemBtn
            // 
            AddItemBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemBtn.Location = new Point(12, 582);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(125, 36);
            AddItemBtn.TabIndex = 15;
            AddItemBtn.Text = "Add Item";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // RemoveItemBtn
            // 
            RemoveItemBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemBtn.Location = new Point(148, 582);
            RemoveItemBtn.Name = "RemoveItemBtn";
            RemoveItemBtn.Size = new Size(125, 36);
            RemoveItemBtn.TabIndex = 16;
            RemoveItemBtn.Text = "Remove Item";
            RemoveItemBtn.UseVisualStyleBackColor = true;
            RemoveItemBtn.Click += RemoveItemBtn_Click;
            // 
            // ClearOrderBtn
            // 
            ClearOrderBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrderBtn.Location = new Point(607, 582);
            ClearOrderBtn.Name = "ClearOrderBtn";
            ClearOrderBtn.Size = new Size(125, 36);
            ClearOrderBtn.TabIndex = 17;
            ClearOrderBtn.Text = "Clear Order";
            ClearOrderBtn.UseVisualStyleBackColor = true;
            ClearOrderBtn.Click += ClearOrderBtn_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearOrderBtn);
            Controls.Add(RemoveItemBtn);
            Controls.Add(AddItemBtn);
            Controls.Add(OrderAmountLabel);
            Controls.Add(AmountCaptionLabel);
            Controls.Add(OrdersItemsListBox);
            Controls.Add(OrderItemsHeaderLabel);
            Controls.Add(addressControl1);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(DeliveryTimeLabel);
            Controls.Add(PriorityOptionsHeaderLabel);
            Controls.Add(OrdersStatusComboBox);
            Controls.Add(OrdersDateTextBox);
            Controls.Add(OrdersIdTextBox);
            Controls.Add(StatusLabel);
            Controls.Add(CreatedLabel);
            Controls.Add(IdLabel);
            Controls.Add(SelectedOrderHeaderLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(748, 630);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderHeaderLabel;
        private Label IdLabel;
        private Label CreatedLabel;
        private Label StatusLabel;
        private TextBox OrdersIdTextBox;
        private TextBox OrdersDateTextBox;
        private ComboBox OrdersStatusComboBox;
        private Label PriorityOptionsHeaderLabel;
        private Label DeliveryTimeLabel;
        private ComboBox DeliveryTimeComboBox;
        private Controls.AddressControl addressControl1;
        private Label OrderItemsHeaderLabel;
        private ListBox OrdersItemsListBox;
        private Label AmountCaptionLabel;
        private Label OrderAmountLabel;
        private Button AddItemBtn;
        private Button RemoveItemBtn;
        private Button ClearOrderBtn;
    }
}