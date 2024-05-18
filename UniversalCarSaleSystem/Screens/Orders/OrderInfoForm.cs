using DbSQLSERVER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalCarSaleSystem.Models.Orders;
using UniversalCarSaleSystem.Properties;
using UniversalCarSaleSystem.Utilities;
using UniversalCarSaleSystem.Utilities.Lists;
using UniversalCarSaleSystem.Utilities.SystemEnums;

namespace UniversalCarSaleSystem.Screens.Orders
{
    public partial class OrderInfoForm : Template
    {
        public OrderInfoForm()
        {
            InitializeComponent();
        }
        public int Id { get; set; }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBoxes();
            if(this.IsUpdate)
            {
                LoadAndBindDataToControls();
            }
        }

        private void LoadAndBindDataToControls()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DataTable dtOrder = db.GetDataList("usp_OrderGetOrderInfoById", true, new DbParameter { Parameter = "@OrderId", Value = this.Id });
            DataRow row = dtOrder.Rows[0];

            CustomerNameComboBox.Text = row["CustomerName"].ToString();
            CarCategoryComboBox.Text = row["CarCategory"].ToString();
            CarNameComboBox.Text = row["CarName"].ToString();
            CarColorComboBox.Text = row["CarColor"].ToString();
            CarModelComboBox.Text = row["CarModal"].ToString();
            QuantityTextBox.Text = row["Quantity"].ToString();
            PurchaseDateDateTimePicker.Value = Convert.ToDateTime(row["PurchaseDate"]);
            NetPriceTextBox.Text = row["NetPrice"].ToString();
            TaxAndExpensesTextBox.Text = row["TaxAndExpenses"].ToString();
            TotalAmountTextBox.Text = row["TotalAmount"].ToString();
            DownPaymentTextBox.Text = row["DownPayment"].ToString();
            RemainingAmountTextBox.Text = row["RemainingAmount"].ToString();
            CommentsTextBox.Text = row["Comments"].ToString();
        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataIntoComboBoxes(CustomerNameComboBox, "SELECT CustomerName AS 'Description' FROM Customer",false);
            CarCategoryComboBox.SelectedValueChanged -= new EventHandler(CarCategoryComboBox_SelectedValueChanged);
            ListData.LoadDataIntoComboBoxes(CarCategoryComboBox, "usp_StockGetAllCarCategories", true);
            CarCategoryComboBox.SelectedValueChanged += new EventHandler(CarCategoryComboBox_SelectedValueChanged);

        }

        private void CarCategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            CarNameComboBox.SelectedValueChanged -= new EventHandler(CarNameComboBox_SelectedValueChanged);
            ListData.LoadDataIntoComboBoxes(CarNameComboBox, "SELECT CarName AS 'Description' FROM Stock WHERE CarCategory=@CarCategory", false,new DbParameter { Parameter = "@CarCategory", Value = CarCategoryComboBox.Text });
            CarNameComboBox.SelectedValueChanged += new EventHandler(CarNameComboBox_SelectedValueChanged);
        }

        private void CarNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ListData.LoadDataIntoComboBoxes(CarModelComboBox, "SELECT CarModal AS 'Description' FROM Stock WHERE CarName=@CarName", false, new DbParameter { Parameter = "@CarName", Value = CarNameComboBox.Text });

            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            DataTable dtStock = db.GetDataList("SELECT * FROM Stock WHERE CarName=@CarName", false, new DbParameter { Parameter = "@CarName", Value = CarNameComboBox.Text });
            DataRow row = dtStock.Rows[0];

            NetPriceTextBox.Text = row["CarPrice"].ToString();
            CurrentStockTextBox.Text = row["InStock"].ToString();



        }

        private void NetPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TaxAndExpensesTextBox.Text.Trim() != "" && NetPriceTextBox.Text.Trim() !="" )
                TotalAmountTextBox.Text = Convert.ToInt32(NetPriceTextBox.Text) + Convert.ToInt32(TaxAndExpensesTextBox.Text).ToString();
            else
                TotalAmountTextBox.Text = NetPriceTextBox.Text;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaxAndExpensesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (NetPriceTextBox.Text.Trim() != string.Empty && TaxAndExpensesTextBox.Text.Trim() != string.Empty && QuantityTextBox.Text.Trim() != string.Empty)
                {
                    decimal total = (Convert.ToDecimal(QuantityTextBox.Text) * Convert.ToDecimal(NetPriceTextBox.Text)) + Convert.ToDecimal(TaxAndExpensesTextBox.Text);
                    TotalAmountTextBox.Text = total.ToString();
                }
                else
                {
                    if (QuantityTextBox.Text.Trim() != string.Empty)
                    {
                        decimal total = Convert.ToDecimal(QuantityTextBox.Text) * Convert.ToDecimal(NetPriceTextBox.Text);
                        TotalAmountTextBox.Text = total.ToString();
                    }
                    else
                    {
                        decimal total = Convert.ToDecimal(TaxAndExpensesTextBox.Text) + Convert.ToDecimal(NetPriceTextBox.Text);
                        TotalAmountTextBox.Text = NetPriceTextBox.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private void RemainingAmountTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TotalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            SubtractDownPayment();

        }

        private void DownPaymentTextBox_TextChanged(object sender, EventArgs e)
        {
            SubtractDownPayment();
        }

        private void SubtractDownPayment()
        {
            try {
                if (TotalAmountTextBox.Text.Trim() != string.Empty && DownPaymentTextBox.Text.Trim() != string.Empty)
                {
                    decimal total = Convert.ToDecimal(TotalAmountTextBox.Text) - Convert.ToDecimal(DownPaymentTextBox.Text);
                    RemainingAmountTextBox.Text = total.ToString();
                }
                else
                    RemainingAmountTextBox.Text = TotalAmountTextBox.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" +ex.Message);
            }

            }
        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try {
                if (QuantityTextBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Quantity Should Not be Zero Or Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    int i;
                    bool res = int.TryParse(QuantityTextBox.Text, out i);
                    if (!res)
                    {
                        MessageBox.Show("Quantity Should Be Numreic Value Like 1,2 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        QuantityTextBox.Clear();
                        QuantityTextBox.Focus();
                        return;
                    }
                }
                if (Convert.ToInt16(QuantityTextBox.Text) > Convert.ToInt16(CurrentStockTextBox.Text))
                {
                    MessageBox.Show("Quantity Should Not be Greator Than Current Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (QuantityTextBox.Text.Trim() != string.Empty && NetPriceTextBox.Text.Trim() != string.Empty)
                    {
                        decimal sum;
                        if (TaxAndExpensesTextBox.Text.Trim() == string.Empty)
                        {
                            sum = (Convert.ToDecimal(QuantityTextBox.Text) * Convert.ToDecimal(NetPriceTextBox.Text) + 0);
                        }
                        else
                        {
                            sum = (Convert.ToDecimal(QuantityTextBox.Text) * Convert.ToDecimal(NetPriceTextBox.Text)) + Convert.ToDecimal(TaxAndExpensesTextBox.Text);
                            TotalAmountTextBox.Text = sum.ToString();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message);
            }
        }

        private void QuantityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantity Should Not be Zero Or Less Than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(IsValidate())
            {
                if(this.IsUpdate)
                {
                    //Update
                    SaveOrUpdateOrder("usp_OrderSaveOrUpdateOrders");
                    MessageBox.Show("Order has Been Updated Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //Save 
                    SaveOrUpdateOrder("usp_OrderSaveOrUpdateOrders");
                    MessageBox.Show("New Order has Been Successfully Confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void SaveOrUpdateOrder(string StoredProce)
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord(StoredProce, GetObject());
        }

        private Order GetObject()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());

            Order order = new Order();
            order.ProcessType = (this.IsUpdate) ? (int)ProcessType.Update : (int)ProcessType.Save;
            order.OrderId = (this.IsUpdate) ? this.Id : 0;
            order.CustomerName = CustomerNameComboBox.Text;
            order.CarCategory = CarCategoryComboBox.Text;
            order.CarName = CarNameComboBox.Text;
            order.CarColor = CarColorComboBox.Text;
            order.CarModal = Convert.ToInt16(CarModelComboBox.Text);
            order.PurchaseDate = PurchaseDateDateTimePicker.Value.Date;
            order.Quantity =Convert.ToInt16(QuantityTextBox.Text.Trim());
            order.NetPrice = NetPriceTextBox.Text.Trim();
            order.TaxAndExpenses = TaxAndExpensesTextBox.Text.Trim();
            order.TotalAmount = TotalAmountTextBox.Text.Trim();
            order.DownPayment = DownPaymentTextBox.Text.Trim();
            order.RemainingAmount = RemainingAmountTextBox.Text.Trim();
            order.Comments = CommentsTextBox.Text.Trim();
            order.CustomerId =Convert.ToInt16(db.GetScalarValue("SELECT CustomerId FROM Customer WHERE CustomerName=@CustomerName", false, new DbParameter { Parameter = "@CustomerName", Value = CustomerNameComboBox.Text }));
            order.StockId = Convert.ToInt16(db.GetScalarValue("SELECT StockId FROM Stock WHERE CarName=@CarName", false, new DbParameter { Parameter = "@CarName", Value = CarNameComboBox.Text }));
            return order;
        }

        private bool IsValidate()
        {
            if(CustomerNameComboBox.SelectedIndex==-1)
            {
                MessageBox.Show("Customer Name Is Required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                CustomerNameComboBox.Focus();
                return false;
            }

            if (CarCategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Car Category Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CarCategoryComboBox.Focus();
                return false;
            }

            if (CarNameComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Car Name Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CarNameComboBox.Focus();
                return false;
            }

            if (CarColorComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Car Color Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CarColorComboBox.Focus();
                return false;
            }

            if (CarModelComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Car Model Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CarModelComboBox.Focus();
                return false;
            }

            if(QuantityTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Quantity Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantityTextBox.Clear();
                QuantityTextBox.Focus();
                return false;
            }

            if (TaxAndExpensesTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Tax And other Expenses Is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaxAndExpensesTextBox.Clear();
                TaxAndExpensesTextBox.Focus();
                return false;
            }


            return true;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.uni;
            Graphics g = e.Graphics;
            g.DrawImage(image, 170, 0, image.Width, image.Height);
            g.DrawString("Date : " + DateTime.Now.ToShortDateString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            g.DrawString("Customer Name : " + CustomerNameComboBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            g.DrawLine(new Pen(Color.Black), new Point(0, 270), new Point(850, 270));

            g.DrawString("Car Category : " + CarCategoryComboBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 300));
            g.DrawString("Car Name : " + CarNameComboBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            g.DrawString("Car Color : " + CarColorComboBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 400));
            g.DrawString("Car Model : " + CarModelComboBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 450));
            g.DrawString("Purchase Date : " + PurchaseDateDateTimePicker.Value.ToShortDateString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10,500));
            g.DrawString("Quantity  : " + QuantityTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(10, 550));

            g.DrawString("Net Price  : " + NetPriceTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(520, 300));
            g.DrawString("Tax And Expenses : " + TaxAndExpensesTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(520, 350));
            g.DrawString("Total Amount  : " + TotalAmountTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(520, 400));
            g.DrawString("Down payment  : " + DownPaymentTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(520, 450));
            g.DrawString("Remaining Amount  : " + RemainingAmountTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(520, 500));


            g.DrawString("Other Notes  : " + CommentsTextBox.Text, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(0, 700));
          

            //Header
            g.DrawString("All Copy Rights Reserved By Universal Car Sale System 2002 ", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(200, 1050));

        }

        private void PrintReceiptButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
    }
