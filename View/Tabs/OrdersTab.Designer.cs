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
            addressControl1 = new AddressControl();
            groupBox2 = new GroupBox();
            OrderAmountLabel = new Label();
            label5 = new Label();
            OrdersItemsListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(0, 0);
            OrdersDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.Size = new Size(435, 554);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Orders";
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
            label4.Location = new Point(15, 81);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 47);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Created:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "ID:";
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
            addressControl1.Location = new Point(441, 124);
            addressControl1.Margin = new Padding(3, 2, 3, 2);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(634, 253);
            addressControl1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OrderAmountLabel);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(OrdersItemsListBox);
            groupBox2.Location = new Point(441, 382);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(634, 172);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Items";
            // 
            // OrderAmountLabel
            // 
            OrderAmountLabel.AutoSize = true;
            OrderAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderAmountLabel.Location = new Point(559, 140);
            OrderAmountLabel.Name = "OrderAmountLabel";
            OrderAmountLabel.Size = new Size(39, 25);
            OrderAmountLabel.TabIndex = 2;
            OrderAmountLabel.Text = "0.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 118);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Amount:";
            // 
            // OrdersItemsListBox
            // 
            OrdersItemsListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrdersItemsListBox.FormattingEnabled = true;
            OrdersItemsListBox.ItemHeight = 15;
            OrdersItemsListBox.Location = new Point(5, 20);
            OrdersItemsListBox.Margin = new Padding(3, 2, 3, 2);
            OrdersItemsListBox.Name = "OrdersItemsListBox";
            OrdersItemsListBox.Size = new Size(629, 94);
            OrdersItemsListBox.TabIndex = 0;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private AddressControl addressControl1;
        private GroupBox groupBox2;
        private ListBox OrdersItemsListBox;
        private Label label5;
        private Label OrderAmountLabel;
    }
}
