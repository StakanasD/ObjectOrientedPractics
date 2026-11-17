namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            OrdersDataGridView = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            OrdersStatusComboBox = new ComboBox();
            OrdersDateTextBox = new TextBox();
            OrdersIdTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            PriorityOptionsPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            PriorityOptionsHeaderLabel = new Label();
            addressControl1 = new Controls.AddressControl();
            groupBox2 = new GroupBox();
            OrderAmountLabel = new Label();
            label5 = new Label();
            OrdersItemsListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            PriorityOptionsPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(3, 25);
            OrdersDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 25;
            OrdersDataGridView.Size = new Size(432, 526);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OrdersStatusComboBox);
            groupBox1.Controls.Add(OrdersDateTextBox);
            groupBox1.Controls.Add(OrdersIdTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(441, 10);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(309, 110);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected Order";
            // 
            // OrdersStatusComboBox
            // 
            OrdersStatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrdersStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OrdersStatusComboBox.FormattingEnabled = true;
            OrdersStatusComboBox.Location = new Point(80, 75);
            OrdersStatusComboBox.Margin = new Padding(3, 2, 3, 2);
            OrdersStatusComboBox.Name = "OrdersStatusComboBox";
            OrdersStatusComboBox.Size = new Size(224, 23);
            OrdersStatusComboBox.TabIndex = 5;
            OrdersStatusComboBox.SelectedIndexChanged += OrdersStatusComboBox_SelectedIndexChanged;
            // 
            // OrdersDateTextBox
            // 
            OrdersDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDateTextBox.Location = new Point(80, 47);
            OrdersDateTextBox.Margin = new Padding(3, 2, 3, 2);
            OrdersDateTextBox.Name = "OrdersDateTextBox";
            OrdersDateTextBox.ReadOnly = true;
            OrdersDateTextBox.Size = new Size(224, 23);
            OrdersDateTextBox.TabIndex = 4;
            // 
            // OrdersIdTextBox
            // 
            OrdersIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrdersIdTextBox.Location = new Point(80, 20);
            OrdersIdTextBox.Margin = new Padding(3, 2, 3, 2);
            OrdersIdTextBox.Name = "OrdersIdTextBox";
            OrdersIdTextBox.ReadOnly = true;
            OrdersIdTextBox.Size = new Size(224, 23);
            OrdersIdTextBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 78);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 50);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Created:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 23);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // PriorityOptionsPanel
            // 
            PriorityOptionsPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsPanel.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsPanel.Controls.Add(PriorityOptionsHeaderLabel);
            PriorityOptionsPanel.Location = new Point(756, 10);
            PriorityOptionsPanel.Name = "PriorityOptionsPanel";
            PriorityOptionsPanel.Size = new Size(319, 110);
            PriorityOptionsPanel.TabIndex = 6;
            PriorityOptionsPanel.Visible = false;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(108, 44);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(195, 23);
            DeliveryTimeComboBox.TabIndex = 2;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(10, 47);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(82, 15);
            DeliveryTimeLabel.TabIndex = 1;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // PriorityOptionsHeaderLabel
            // 
            PriorityOptionsHeaderLabel.AutoSize = true;
            PriorityOptionsHeaderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOptionsHeaderLabel.Location = new Point(10, 10);
            PriorityOptionsHeaderLabel.Name = "PriorityOptionsHeaderLabel";
            PriorityOptionsHeaderLabel.Size = new Size(98, 15);
            PriorityOptionsHeaderLabel.TabIndex = 0;
            PriorityOptionsHeaderLabel.Text = "Priority Options";
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
            addressControl1.Location = new Point(441, 126);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.ReadOnly = true;
            addressControl1.Size = new Size(634, 240);
            addressControl1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(OrderAmountLabel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(OrdersItemsListBox);
            groupBox2.Location = new Point(441, 372);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(634, 179);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Items";
            // 
            // OrderAmountLabel
            // 
            OrderAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OrderAmountLabel.AutoSize = true;
            OrderAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderAmountLabel.Location = new Point(555, 146);
            OrderAmountLabel.Name = "OrderAmountLabel";
            OrderAmountLabel.Size = new Size(49, 25);
            OrderAmountLabel.TabIndex = 2;
            OrderAmountLabel.Text = "0,00";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(573, 124);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Amount:";
            // 
            // OrdersItemsListBox
            // 
            OrdersItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersItemsListBox.FormattingEnabled = true;
            OrdersItemsListBox.ItemHeight = 15;
            OrdersItemsListBox.Location = new Point(5, 20);
            OrdersItemsListBox.Margin = new Padding(3, 2, 3, 2);
            OrdersItemsListBox.Name = "OrdersItemsListBox";
            OrdersItemsListBox.Size = new Size(624, 94);
            OrdersItemsListBox.TabIndex = 0;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriorityOptionsPanel);
            Controls.Add(groupBox2);
            Controls.Add(addressControl1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(OrdersDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrdersTab";
            Size = new Size(1077, 556);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            PriorityOptionsPanel.ResumeLayout(false);
            PriorityOptionsPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrdersDataGridView;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox OrdersDateTextBox;
        private TextBox OrdersIdTextBox;
        private ComboBox OrdersStatusComboBox;
        private Panel PriorityOptionsPanel;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Label PriorityOptionsHeaderLabel;
        private Controls.AddressControl addressControl1;
        private GroupBox groupBox2;
        private ListBox OrdersItemsListBox;
        private Label label5;
        private Label OrderAmountLabel;
    }
}