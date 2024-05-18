namespace UniversalCarSaleSystem.Screens.Orders
{
    partial class OrderInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderInfoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CommentsTextBox = new System.Windows.Forms.TextBox();
            this.RemainingAmountTextBox = new System.Windows.Forms.TextBox();
            this.DownPaymentTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.TaxAndExpensesTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NetPriceTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CurrentStockTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PurchaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CarModelComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentStockLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CarColorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CarNameComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PrintReceiptButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CommentsTextBox);
            this.panel1.Controls.Add(this.RemainingAmountTextBox);
            this.panel1.Controls.Add(this.DownPaymentTextBox);
            this.panel1.Controls.Add(this.TotalAmountTextBox);
            this.panel1.Controls.Add(this.TaxAndExpensesTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.NetPriceTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.CurrentStockTextBox);
            this.panel1.Controls.Add(this.QuantityTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.PurchaseDateDateTimePicker);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CarModelComboBox);
            this.panel1.Controls.Add(this.CurrentStockLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CarColorComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CarNameComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CarCategoryComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CustomerNameComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 475);
            this.panel1.TabIndex = 0;
            // 
            // CommentsTextBox
            // 
            this.CommentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsTextBox.Location = new System.Drawing.Point(166, 369);
            this.CommentsTextBox.Multiline = true;
            this.CommentsTextBox.Name = "CommentsTextBox";
            this.CommentsTextBox.Size = new System.Drawing.Size(349, 91);
            this.CommentsTextBox.TabIndex = 25;
            // 
            // RemainingAmountTextBox
            // 
            this.RemainingAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingAmountTextBox.Location = new System.Drawing.Point(166, 341);
            this.RemainingAmountTextBox.Name = "RemainingAmountTextBox";
            this.RemainingAmountTextBox.ReadOnly = true;
            this.RemainingAmountTextBox.Size = new System.Drawing.Size(127, 23);
            this.RemainingAmountTextBox.TabIndex = 23;
            this.RemainingAmountTextBox.TabStop = false;
            this.RemainingAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemainingAmountTextBox.TextChanged += new System.EventHandler(this.RemainingAmountTextBox_TextChanged);
            // 
            // DownPaymentTextBox
            // 
            this.DownPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownPaymentTextBox.Location = new System.Drawing.Point(166, 313);
            this.DownPaymentTextBox.Name = "DownPaymentTextBox";
            this.DownPaymentTextBox.Size = new System.Drawing.Size(127, 23);
            this.DownPaymentTextBox.TabIndex = 21;
            this.DownPaymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DownPaymentTextBox.TextChanged += new System.EventHandler(this.DownPaymentTextBox_TextChanged);
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountTextBox.Location = new System.Drawing.Point(166, 285);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.ReadOnly = true;
            this.TotalAmountTextBox.Size = new System.Drawing.Size(127, 23);
            this.TotalAmountTextBox.TabIndex = 19;
            this.TotalAmountTextBox.TabStop = false;
            this.TotalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalAmountTextBox.TextChanged += new System.EventHandler(this.TotalAmountTextBox_TextChanged);
            // 
            // TaxAndExpensesTextBox
            // 
            this.TaxAndExpensesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAndExpensesTextBox.Location = new System.Drawing.Point(166, 257);
            this.TaxAndExpensesTextBox.Name = "TaxAndExpensesTextBox";
            this.TaxAndExpensesTextBox.Size = new System.Drawing.Size(105, 23);
            this.TaxAndExpensesTextBox.TabIndex = 17;
            this.TaxAndExpensesTextBox.Text = "0";
            this.TaxAndExpensesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TaxAndExpensesTextBox.TextChanged += new System.EventHandler(this.TaxAndExpensesTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Comments:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Remaining Amount:";
            // 
            // NetPriceTextBox
            // 
            this.NetPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPriceTextBox.Location = new System.Drawing.Point(166, 229);
            this.NetPriceTextBox.Name = "NetPriceTextBox";
            this.NetPriceTextBox.ReadOnly = true;
            this.NetPriceTextBox.Size = new System.Drawing.Size(127, 23);
            this.NetPriceTextBox.TabIndex = 15;
            this.NetPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NetPriceTextBox.TextChanged += new System.EventHandler(this.NetPriceTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Down Payment:";
            // 
            // CurrentStockTextBox
            // 
            this.CurrentStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockTextBox.Location = new System.Drawing.Point(432, 200);
            this.CurrentStockTextBox.Name = "CurrentStockTextBox";
            this.CurrentStockTextBox.ReadOnly = true;
            this.CurrentStockTextBox.Size = new System.Drawing.Size(56, 23);
            this.CurrentStockTextBox.TabIndex = 13;
            this.CurrentStockTextBox.TabStop = false;
            this.CurrentStockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(166, 200);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(56, 23);
            this.QuantityTextBox.TabIndex = 13;
            this.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            this.QuantityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.QuantityTextBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Amount:";
            // 
            // PurchaseDateDateTimePicker
            // 
            this.PurchaseDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PurchaseDateDateTimePicker.Location = new System.Drawing.Point(166, 173);
            this.PurchaseDateDateTimePicker.Name = "PurchaseDateDateTimePicker";
            this.PurchaseDateDateTimePicker.Size = new System.Drawing.Size(174, 23);
            this.PurchaseDateDateTimePicker.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tax And Expenses:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Net Price:";
            // 
            // CarModelComboBox
            // 
            this.CarModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModelComboBox.FormattingEnabled = true;
            this.CarModelComboBox.Location = new System.Drawing.Point(166, 144);
            this.CarModelComboBox.Name = "CarModelComboBox";
            this.CarModelComboBox.Size = new System.Drawing.Size(105, 24);
            this.CarModelComboBox.TabIndex = 9;
            // 
            // CurrentStockLabel
            // 
            this.CurrentStockLabel.AutoSize = true;
            this.CurrentStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStockLabel.Location = new System.Drawing.Point(313, 203);
            this.CurrentStockLabel.Name = "CurrentStockLabel";
            this.CurrentStockLabel.Size = new System.Drawing.Size(98, 17);
            this.CurrentStockLabel.TabIndex = 12;
            this.CurrentStockLabel.Text = "Current Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Purchased Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Car Model:";
            // 
            // CarColorComboBox
            // 
            this.CarColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarColorComboBox.FormattingEnabled = true;
            this.CarColorComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Orange",
            "Black",
            "White",
            "Cyan",
            "Silver"});
            this.CarColorComboBox.Location = new System.Drawing.Point(166, 115);
            this.CarColorComboBox.Name = "CarColorComboBox";
            this.CarColorComboBox.Size = new System.Drawing.Size(139, 24);
            this.CarColorComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Car Color:";
            // 
            // CarNameComboBox
            // 
            this.CarNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarNameComboBox.FormattingEnabled = true;
            this.CarNameComboBox.Location = new System.Drawing.Point(166, 86);
            this.CarNameComboBox.Name = "CarNameComboBox";
            this.CarNameComboBox.Size = new System.Drawing.Size(174, 24);
            this.CarNameComboBox.TabIndex = 5;
            this.CarNameComboBox.SelectedValueChanged += new System.EventHandler(this.CarNameComboBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Name:";
            // 
            // CarCategoryComboBox
            // 
            this.CarCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarCategoryComboBox.FormattingEnabled = true;
            this.CarCategoryComboBox.Location = new System.Drawing.Point(166, 57);
            this.CarCategoryComboBox.Name = "CarCategoryComboBox";
            this.CarCategoryComboBox.Size = new System.Drawing.Size(158, 24);
            this.CarCategoryComboBox.TabIndex = 3;
            this.CarCategoryComboBox.SelectedValueChanged += new System.EventHandler(this.CarCategoryComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Category:";
            // 
            // CustomerNameComboBox
            // 
            this.CustomerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameComboBox.FormattingEnabled = true;
            this.CustomerNameComboBox.Location = new System.Drawing.Point(166, 28);
            this.CustomerNameComboBox.Name = "CustomerNameComboBox";
            this.CustomerNameComboBox.Size = new System.Drawing.Size(174, 24);
            this.CustomerNameComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(13, 494);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(88, 28);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(224, 494);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(88, 28);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PrintReceiptButton
            // 
            this.PrintReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReceiptButton.Location = new System.Drawing.Point(107, 494);
            this.PrintReceiptButton.Name = "PrintReceiptButton";
            this.PrintReceiptButton.Size = new System.Drawing.Size(111, 28);
            this.PrintReceiptButton.TabIndex = 3;
            this.PrintReceiptButton.Text = "&Print Receipt";
            this.PrintReceiptButton.UseVisualStyleBackColor = true;
            this.PrintReceiptButton.Click += new System.EventHandler(this.PrintReceiptButton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // OrderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 534);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrintReceiptButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Name = "OrderInfoForm";
            this.Text = "Order Info Screen";
            this.Load += new System.EventHandler(this.OrderInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CommentsTextBox;
        private System.Windows.Forms.TextBox RemainingAmountTextBox;
        private System.Windows.Forms.TextBox DownPaymentTextBox;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.TextBox TaxAndExpensesTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NetPriceTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker PurchaseDateDateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CarModelComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CarColorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CarNameComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarCategoryComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CustomerNameComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button PrintReceiptButton;
        private System.Windows.Forms.TextBox CurrentStockTextBox;
        private System.Windows.Forms.Label CurrentStockLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}