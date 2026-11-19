namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            OkButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 204);
            HeaderLabel.Location = new Point(16, 15);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(122, 17);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(16, 48);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(92, 45);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(230, 23);
            CategoryComboBox.TabIndex = 2;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(116, 86);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(98, 32);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(224, 86);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(98, 32);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddDiscountForm
            // 
            AcceptButton = OkButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = CancelButton;
            ClientSize = new Size(340, 134);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(HeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddDiscountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
        private Button OkButton;
        private new Button CancelButton;
    }
}