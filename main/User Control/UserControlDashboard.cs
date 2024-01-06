using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System81.main.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = Attendance_Management_System; Integrated Security = True;";

        public UserControlDashboard()
        {
            InitializeComponent();
        }

        public void Count()
        {

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
