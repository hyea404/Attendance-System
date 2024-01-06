using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System81.main.User_Control
{
    public partial class UserControlAddClass : UserControl
    {
        private string sql = @"Data Source=.\SQLEXPRESS;Initial Catalog=Attendance_Management_System;Integrated Security=True;";


        private string CID = "";
        public UserControlAddClass()
        {
            InitializeComponent();
        }

        private void IntegerType(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxHmStudent.Clear();
            textBoxMale.Clear();
            textBoxFemale.Clear();
            tabControlAddClass.SelectedTab = tabPageAddClass;
        }
        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxHmStudent1.Clear();
            textBoxMale1.Clear();
            textBoxFemale1.Clear();
            CID = "";
        }

        private void tabPageUPClass_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim() == string.Empty || textBoxHmStudent.Text.Trim() == string.Empty || textBoxMale.Text.Trim() == string.Empty || textBoxFemale.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fill out all data.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool check = Attendance.Attendance.AddClass(textBoxName.Text.Trim(), textBoxHmStudent.Text.Trim(), textBoxMale.Text.Trim(), textBoxFemale.Text.Trim(), sql);
                
                if (check)
                ClearTextBox();
            }
        }

        private void tabPageUPClass_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageSearchClass_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table;", dataGridViewClass, sql);
            dataGridViewClass.Columns[0].Visible = false;
            labelCountClass.Text = dataGridViewClass.Rows.Count.ToString();
        }

        private void tabPageAddClass_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddClass_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void textBoxHmStudent_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxHmStudent1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM Class_Table WHERE Class_Name LIKE '%" + textBoxSearch.Text + "%';", dataGridViewClass, sql);
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClass.Rows[e.RowIndex];
                CID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxHmStudent1.Text = row.Cells[2].Value.ToString();
                textBoxMale1.Text = row.Cells[3].Value.ToString();
                textBoxFemale1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHmStudent1.Text.Trim() == string.Empty || textBoxMale1.Text.Trim() == string.Empty || textBoxFemale1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Fill out all data.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateClass(CID, textBoxName1.Text.Trim(), textBoxHmStudent1.Text.Trim(), textBoxMale1.Text.Trim(), textBoxFemale1.Text.Trim(), sql);

                    if (check)
                        ClearTextBox1();
                }
            }
            else
            {
                MessageBox.Show("Please Select Row from Table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (CID != "")
            {
                if (textBoxName1.Text.Trim() == string.Empty || textBoxHmStudent1.Text.Trim() == string.Empty || textBoxMale1.Text.Trim() == string.Empty || textBoxFemale1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Fill out all data.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Delete Class??", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteClass(CID, sql);

                        if (check)
                            ClearTextBox1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Row from Table.", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxFemale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }

        private void textBoxMale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntegerType(e);
        }
    }
}
