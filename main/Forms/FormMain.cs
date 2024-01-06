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
    public partial class FormMain : Form
    {
        public string Username, Role;

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Close();
            }
            

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Role: {Role}");

            labelUsername.Text = Username;
            labelRole.Text = Role;

            if(Role == "User")
            {
                buttonDashboard.Hide();
                buttonAddClass.Hide();
                buttonAddStudent.Hide();
                buttonRegister.Hide();

            }
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("F");

        }

        public FormMain()
        {
            InitializeComponent();
            timerDateAndTime.Start();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
            userControlAddClass1.Visible = false;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlAddClass1.Visible = false;
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlAddClass1.ClearTextBox();
            userControlAddClass1.Visible = true;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlAddClass1.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlAddClass1.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlAddClass1.Visible = false;
        }

    }
}
