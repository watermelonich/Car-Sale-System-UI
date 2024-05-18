using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DbSQLSERVER
{
    public class FSMessageBox
    {
        public static void ShowErrorMessage(string Message)
        {
            MessageBox.Show(Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static void ShowErrorMessage(string Message,string Title)
        {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowSuccessMessage(string Message)
        {
            MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowSuccessMessage(string Message, string Title)
        {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
