namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            IndexTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            AddressToolTip = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(ApartmentTextBox);
            groupBox1.Controls.Add(CityTextBox);
            groupBox1.Controls.Add(BuildingTextBox);
            groupBox1.Controls.Add(StreetTextBox);
            groupBox1.Controls.Add(CountryTextBox);
            groupBox1.Controls.Add(IndexTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delivery Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Post Index:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(95, 28);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(120, 23);
            IndexTextBox.TabIndex = 1;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 71);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Country:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(95, 68);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(180, 23);
            CountryTextBox.TabIndex = 3;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 71);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "City:";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.Location = new Point(340, 68);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(270, 23);
            CityTextBox.TabIndex = 5;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 111);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Street:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(95, 108);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(515, 23);
            StreetTextBox.TabIndex = 7;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 151);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Building:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(95, 148);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(120, 23);
            BuildingTextBox.TabIndex = 9;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 151);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 10;
            label6.Text = "Apartment:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(315, 148);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(120, 23);
            ApartmentTextBox.TabIndex = 11;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "AddressControl";
            Size = new Size(635, 240);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox ApartmentTextBox;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox IndexTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolTip AddressToolTip;
    }
}