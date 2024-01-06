using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Attendance_System81.main.Forms
{
    public partial class FormLogin : Form
    {

        private string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = Attendance_Management_System; Integrated Security = True;";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Check = Attendance.Attendance.IsValidNamePass(textBoxName.Text.Trim(), textBoxPassword.Text.Trim(), sql);
            if (textBoxName.Text.Trim() != string.Empty && textBoxPassword.Text.Trim() != string.Empty)
            {
                if (Check != "")
                {
                    FormMain formMain = new FormMain();
                    formMain.Username = textBoxName.Text;
                    formMain.Role = Check;
                    textBoxName.Clear();
                    textBoxPassword.Clear();
                    textBoxName.Focus();
                    formMain.ShowDialog();
                    labelError.Hide();
                }
                else
                {
                    labelError.Show();
                }
            }
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}
