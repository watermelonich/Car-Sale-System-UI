using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalCarSaleSystem.Screens.CarStock;
using UniversalCarSaleSystem.Screens.Company;
using UniversalCarSaleSystem.Screens.Customers;

namespace UniversalCarSaleSystem.Screens
{
    public partial class MainForm : Template
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CarStockButton_Click(object sender, EventArgs e)
        {
            CarStockForm carStockForm = new CarStockForm();
            carStockForm.ShowDialog();
        }

        private void UpdateStockButton_Click(object sender, EventArgs e)
        {
            UpdateStockForm updateStockForm = new UpdateStockForm();
            updateStockForm.ShowDialog();
        }

        private void CustomerDetailsButton_Click(object sender, EventArgs e)
        {
            ManageCustomerForm manageCustomerForm = new ManageCustomerForm();
            manageCustomerForm.ShowDialog();
        }

        private void CustomerHistoryButton_Click(object sender, EventArgs e)
        {
            ManageCustomerHistoryForm manageCustomerHistoryForm = new ManageCustomerHistoryForm();
            manageCustomerHistoryForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LogInForm lgForm = new LogInForm();
            lgForm.Show();
        }
        
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomerHistoryForm manageCustomerHistoryForm = new ManageCustomerHistoryForm();
            manageCustomerHistoryForm.ShowDialog();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomerForm manageCustomerForm = new ManageCustomerForm();
            manageCustomerForm.ShowDialog();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarStockForm carStockForm = new CarStockForm();
            carStockForm.ShowDialog();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStockForm updateStockForm = new UpdateStockForm();
            updateStockForm.ShowDialog();
        }

        private void CompanyDetailButton_Click(object sender, EventArgs e)
        {
            ShowCompanyDetailsForm();
        }

        private static void ShowCompanyDetailsForm()
        {
            CompanyDetails cd = new CompanyDetails();
            cd.ShowDialog();
        }

        private void aboutCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCompanyDetailsForm();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogInForm lgForm = new LogInForm();
            lgForm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChangeForm pcf = new PasswordChangeForm();
            pcf.ShowDialog();
        }
    }
}
