namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            InfoLabel = new Label();
            CalculateBtn = new Button();
            ApplyBtn = new Button();
            UpdateBtn = new Button();
            ProductsAmountCaptionLabel = new Label();
            ProductsAmountLabel = new Label();
            DiscountAmountCaptionLabel = new Label();
            DiscountAmountLabel = new Label();
            SuspendLayout();
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InfoLabel.Location = new Point(15, 15);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(195, 17);
            InfoLabel.TabIndex = 0;
            InfoLabel.Text = "Info: Накопительная - 0 баллов";
            // 
            // CalculateBtn
            // 
            CalculateBtn.Location = new Point(15, 45);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(115, 36);
            CalculateBtn.TabIndex = 1;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Location = new Point(140, 45);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(115, 36);
            ApplyBtn.TabIndex = 2;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(265, 45);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(115, 36);
            UpdateBtn.TabIndex = 3;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ProductsAmountCaptionLabel
            // 
            ProductsAmountCaptionLabel.AutoSize = true;
            ProductsAmountCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductsAmountCaptionLabel.Location = new Point(450, 15);
            ProductsAmountCaptionLabel.Name = "ProductsAmountCaptionLabel";
            ProductsAmountCaptionLabel.Size = new Size(106, 15);
            ProductsAmountCaptionLabel.TabIndex = 4;
            ProductsAmountCaptionLabel.Text = "Products Amount:";
            // 
            // ProductsAmountLabel
            // 
            ProductsAmountLabel.AutoSize = true;
            ProductsAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductsAmountLabel.Location = new Point(450, 35);
            ProductsAmountLabel.Name = "ProductsAmountLabel";
            ProductsAmountLabel.Size = new Size(49, 25);
            ProductsAmountLabel.TabIndex = 5;
            ProductsAmountLabel.Text = "0,00";
            // 
            // DiscountAmountCaptionLabel
            // 
            DiscountAmountCaptionLabel.AutoSize = true;
            DiscountAmountCaptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountCaptionLabel.Location = new Point(450, 72);
            DiscountAmountCaptionLabel.Name = "DiscountAmountCaptionLabel";
            DiscountAmountCaptionLabel.Size = new Size(106, 15);
            DiscountAmountCaptionLabel.TabIndex = 6;
            DiscountAmountCaptionLabel.Text = "Discount Amount:";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(450, 92);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(49, 25);
            DiscountAmountLabel.TabIndex = 7;
            DiscountAmountLabel.Text = "0,00";
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DiscountAmountLabel);
            Controls.Add(DiscountAmountCaptionLabel);
            Controls.Add(ProductsAmountLabel);
            Controls.Add(ProductsAmountCaptionLabel);
            Controls.Add(UpdateBtn);
            Controls.Add(ApplyBtn);
            Controls.Add(CalculateBtn);
            Controls.Add(InfoLabel);
            Name = "DiscountsTab";
            Size = new Size(600, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoLabel;
        private Button CalculateBtn;
        private Button ApplyBtn;
        private Button UpdateBtn;
        private Label ProductsAmountCaptionLabel;
        private Label ProductsAmountLabel;
        private Label DiscountAmountCaptionLabel;
        private Label DiscountAmountLabel;
    }
}