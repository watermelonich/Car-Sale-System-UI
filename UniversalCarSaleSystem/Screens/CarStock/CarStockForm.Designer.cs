namespace UniversalCarSaleSystem.Screens.CarStock
{
    partial class CarStockForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.CarNameLabel = new System.Windows.Forms.Label();
            this.CarPriceLabel = new System.Windows.Forms.Label();
            this.CarModalLabel = new System.Windows.Forms.Label();
            this.CarStockListBox = new System.Windows.Forms.ListBox();
            this.CarCategoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.CarNameLbl = new System.Windows.Forms.Label();
            this.CarPriceLbl = new System.Windows.Forms.Label();
            this.CarModelLbl = new System.Windows.Forms.Label();
            this.CarCategoryLbl = new System.Windows.Forms.Label();
            this.CurrentStockLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.BackgroundImage = global::UniversalCarSaleSystem.Properties.Resources.noImage;
            this.CarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarPictureBox.Location = new System.Drawing.Point(340, 12);
            this.CarPictureBox.Name = "CarPictureBox";
            this.CarPictureBox.Size = new System.Drawing.Size(361, 284);
            this.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPictureBox.TabIndex = 0;
            this.CarPictureBox.TabStop = false;
            // 
            // CarNameLabel
            // 
            this.CarNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLabel.Location = new System.Drawing.Point(339, 300);
            this.CarNameLabel.Name = "CarNameLabel";
            this.CarNameLabel.Size = new System.Drawing.Size(84, 23);
            this.CarNameLabel.TabIndex = 1;
            this.CarNameLabel.Text = "Car Name:";
            // 
            // CarPriceLabel
            // 
            this.CarPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPriceLabel.Location = new System.Drawing.Point(339, 328);
            this.CarPriceLabel.Name = "CarPriceLabel";
            this.CarPriceLabel.Size = new System.Drawing.Size(121, 23);
            this.CarPriceLabel.TabIndex = 1;
            this.CarPriceLabel.Text = "Car Price PKR:";
            // 
            // CarModalLabel
            // 
            this.CarModalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModalLabel.Location = new System.Drawing.Point(339, 356);
            this.CarModalLabel.Name = "CarModalLabel";
            this.CarModalLabel.Size = new System.Drawing.Size(90, 23);
            this.CarModalLabel.TabIndex = 1;
            this.CarModalLabel.Text = "Car Modal:";
            // 
            // CarStockListBox
            // 
            this.CarStockListBox.FormattingEnabled = true;
            this.CarStockListBox.Location = new System.Drawing.Point(24, 39);
            this.CarStockListBox.Name = "CarStockListBox";
            this.CarStockListBox.Size = new System.Drawing.Size(271, 472);
            this.CarStockListBox.TabIndex = 2;
            this.CarStockListBox.SelectedValueChanged += new System.EventHandler(this.CarStockListBox_SelectedValueChanged);
            // 
            // CarCategoryLabel
            // 
            this.CarCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarCategoryLabel.Location = new System.Drawing.Point(339, 384);
            this.CarCategoryLabel.Name = "CarCategoryLabel";
            this.CarCategoryLabel.Size = new System.Drawing.Size(108, 23);
            this.CarCategoryLabel.TabIndex = 1;
            this.CarCategoryLabel.Text = "Car Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(116, 6);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(179, 21);
            this.CategoryComboBox.TabIndex = 4;
            this.CategoryComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryComboBox_SelectedValueChanged);
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockLabel.Location = new System.Drawing.Point(339, 412);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(121, 23);
            this.CurrentStockLabel.TabIndex = 1;
            this.CurrentStockLabel.Text = "Current Stock:";
            // 
            // CarNameLbl
            // 
            this.CarNameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameLbl.Location = new System.Drawing.Point(450, 300);
            this.CarNameLbl.Name = "CarNameLbl";
            this.CarNameLbl.Size = new System.Drawing.Size(251, 23);
            this.CarNameLbl.TabIndex = 5;
            // 
            // CarPriceLbl
            // 
            this.CarPriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPriceLbl.Location = new System.Drawing.Point(450, 328);
            this.CarPriceLbl.Name = "CarPriceLbl";
            this.CarPriceLbl.Size = new System.Drawing.Size(251, 23);
            this.CarPriceLbl.TabIndex = 5;
            // 
            // CarModelLbl
            // 
            this.CarModelLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarModelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModelLbl.Location = new System.Drawing.Point(450, 355);
            this.CarModelLbl.Name = "CarModelLbl";
            this.CarModelLbl.Size = new System.Drawing.Size(251, 23);
            this.CarModelLbl.TabIndex = 5;
            // 
            // CarCategoryLbl
            // 
            this.CarCategoryLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CarCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarCategoryLbl.Location = new System.Drawing.Point(450, 384);
            this.CarCategoryLbl.Name = "CarCategoryLbl";
            this.CarCategoryLbl.Size = new System.Drawing.Size(251, 23);
            this.CarCategoryLbl.TabIndex = 5;
            // 
            // CurrentStockLbl
            // 
            this.CurrentStockLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentStockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockLbl.Location = new System.Drawing.Point(450, 411);
            this.CurrentStockLbl.Name = "CurrentStockLbl";
            this.CurrentStockLbl.Size = new System.Drawing.Size(251, 23);
            this.CurrentStockLbl.TabIndex = 5;
            // 
            // CarStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 524);
            this.Controls.Add(this.CurrentStockLbl);
            this.Controls.Add(this.CarCategoryLbl);
            this.Controls.Add(this.CarModelLbl);
            this.Controls.Add(this.CarPriceLbl);
            this.Controls.Add(this.CarNameLbl);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarStockListBox);
            this.Controls.Add(this.CurrentStockLabel);
            this.Controls.Add(this.CarCategoryLabel);
            this.Controls.Add(this.CarModalLabel);
            this.Controls.Add(this.CarPriceLabel);
            this.Controls.Add(this.CarNameLabel);
            this.Controls.Add(this.CarPictureBox);
            this.Name = "CarStockForm";
            this.Text = "Car Stock Screen";
            this.Load += new System.EventHandler(this.CarStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CarPictureBox;
        private System.Windows.Forms.Label CarNameLabel;
        private System.Windows.Forms.Label CarPriceLabel;
        private System.Windows.Forms.Label CarModalLabel;
        private System.Windows.Forms.ListBox CarStockListBox;
        private System.Windows.Forms.Label CarCategoryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Windows.Forms.Label CarNameLbl;
        private System.Windows.Forms.Label CarPriceLbl;
        private System.Windows.Forms.Label CarModelLbl;
        private System.Windows.Forms.Label CarCategoryLbl;
        private System.Windows.Forms.Label CurrentStockLbl;
    }
}