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
using UniversalCarSaleSystem.Utilities;

namespace UniversalCarSaleSystem.Screens
{
    public partial class LogInForm : Template
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(isValidate())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                bool result = (bool)db.GetScalarValue("[usp_UsersCheckLoginDetails]", true, GetParameters());
                if (result)
                {
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.Show();
                }
                else
                    MessageBox.Show("User Name or Password Is Not Correct ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private DbParameter[] GetParameters()
        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter para1 = new DbParameter();
            para1.Parameter = "@UserName";
            para1.Value = UserNameTextBox.Text.Trim();
            parameters.Add(para1);

            DbParameter para2 = new DbParameter();
            para2.Parameter = "@Password";
            para2.Value = PasswordTextBox.Text.Trim();
            parameters.Add(para2);

            return parameters.ToArray();
        }

        private bool isValidate()
        {
            if(UserNameTextBox.Text.Trim()==string.Empty)
            {
                MessageBox.Show("User Name is required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return false;
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
                return false;
            }

            return true;
        }
    }
}
