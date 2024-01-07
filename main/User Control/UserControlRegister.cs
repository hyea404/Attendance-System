using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System81.main.User_Control
{
    public partial class UserControlRegister : UserControl
    {
        private string sql = @"Data Source=.\SQLEXPRESS;Initial Catalog=Attendance_Management_System;Integrated Security=True;";

        public UserControlRegister()
        {
            InitializeComponent();
        }

        private string Gender = "", Role, ID = "";

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxPass.Clear();
            maskedTextBoxPho.Text = "+00 000 0000 0000";
            maskedTextBoxPho.ForeColor = Color.WhiteSmoke;
            maskedTextBoxCNIC.Text = "";
            maskedTextBoxCNIC.ForeColor = Color.WhiteSmoke;
            maskedTextBoxDOB.Text = "";
            maskedTextBoxDOB.ForeColor = Color.WhiteSmoke;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxEmail.Text = "";
            textBoxEmail.ForeColor = Color.WhiteSmoke;
            checkBoxRole.Checked = false;
            textBoxAdd.Clear();
            tabControlRegister.SelectedTab = tabPageAddUser;
        }

        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxPass1.Clear();
            maskedTextBoxPho1.Text = "+00 000 0000 0000";
            maskedTextBoxPho1.ForeColor = Color.WhiteSmoke;
            maskedTextBoxCNIC1.Text = "";
            maskedTextBoxCNIC1.ForeColor = Color.WhiteSmoke;
            maskedTextBoxDOB1.Text = "";
            maskedTextBoxDOB1.ForeColor = Color.WhiteSmoke;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            textBoxEmail1.Text = "";
            textBoxEmail1.ForeColor = Color.WhiteSmoke;
            checkBoxRole1.Checked = false;
            textBoxAdd1.Clear();
            ID = "";
        }

        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                txtBox.Select(0, 0);
            });
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.WhiteSmoke;
            }
        }

        private void maskedTextBoxPho_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "+00 000 0000 0000")
                maskedTextBoxPho.Text = "";

            if(!maskedTextBoxPho.MaskCompleted)
            {
                maskedTextBoxPho.ForeColor = Color.WhiteSmoke;
                Mask(maskedTextBoxPho);
            }
        }

        private void maskedTextBoxPho_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "+")
            {
                maskedTextBoxPho.Text = "+00 000 0000 0000";
                maskedTextBoxPho.ForeColor = Color.WhiteSmoke;
            }

            if (!maskedTextBoxPho.MaskCompleted)
            {
                maskedTextBoxPho.ForeColor = Color.WhiteSmoke;
            }
        }

        private void maskedTextBoxCNIC_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC.Text == "")
                maskedTextBoxCNIC.Text = "";

            if (!maskedTextBoxCNIC.MaskCompleted)
            {
                maskedTextBoxCNIC.ForeColor = Color.WhiteSmoke;
                Mask(maskedTextBoxCNIC);
            }
        }

        private void maskedTextBoxCNIC_Leave(object sender, EventArgs e)
        {
            if(maskedTextBoxCNIC.Text.Trim() == "")
            {
                maskedTextBoxCNIC.Text = "";
                maskedTextBoxCNIC.ForeColor = Color.WhiteSmoke;
            }

            if (!maskedTextBoxCNIC.MaskCompleted)
            {
                maskedTextBoxCNIC.ForeColor = Color.WhiteSmoke;
            }
        }

        private void maskedTextBoxDOB_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text == "00/00/0000")
                maskedTextBoxDOB.Text = "";

            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.WhiteSmoke;
                Mask(maskedTextBoxDOB);
            }
        }

        private void maskedTextBoxDOB_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text.Trim() == "/    /")
            {
                maskedTextBoxDOB.Text = "00/00/0000";
                maskedTextBoxDOB.ForeColor = Color.WhiteSmoke;
            }

            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.WhiteSmoke;
            }
        }

        private void maskedTextBoxPho1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho1.Text == "+00 000 0000 0000")
                maskedTextBoxPho1.Text = "";

            if (!maskedTextBoxPho1.MaskCompleted)
            {
                maskedTextBoxPho1.ForeColor = Color.WhiteSmoke;
                Mask(maskedTextBoxPho1);
            }
        }

        private void maskedTextBoxPho1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPho1.Text == "+")
            {
                maskedTextBoxPho1.Text = "+00 000 0000 0000";
                maskedTextBoxPho1.ForeColor = Color.WhiteSmoke;
            }

            if (!maskedTextBoxPho1.MaskCompleted)
            {
                maskedTextBoxPho1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void maskedTextBoxCNIC1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC1.Text == "")
                maskedTextBoxCNIC1.Text = "";

            if (!maskedTextBoxCNIC1.MaskCompleted)
            {
                maskedTextBoxCNIC1.ForeColor = Color.WhiteSmoke;
                Mask(maskedTextBoxCNIC1);
            }
        }

        private void maskedTextBoxCNIC1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC1.Text.Trim() == "")
            {
                maskedTextBoxCNIC1.Text = "";
                maskedTextBoxCNIC1.ForeColor = Color.WhiteSmoke;
            }

            if (!maskedTextBoxCNIC1.MaskCompleted)
            {
                maskedTextBoxCNIC1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void maskedTextBoxDOB1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text == "00/00/0000")
                maskedTextBoxDOB1.Text = "";

            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.WhiteSmoke;
                Mask(maskedTextBoxDOB1);
            }
        }

        private void maskedTextBoxDOB1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text.Trim() == "/    /")
            {
                maskedTextBoxDOB1.Text = "00/00/0000";
                maskedTextBoxDOB1.ForeColor = Color.WhiteSmoke;
            }

            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBoxEmail1_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "")
            {
                textBoxEmail1.Text = "";
                textBoxEmail1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBoxEmail1_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "")
            {
                textBoxEmail1.Text = "";
                textBoxEmail1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser, sql);
            if(comboBoxSearchBy.SelectedIndex == 1)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Pho LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser, sql);
            if(comboBoxSearchBy.SelectedIndex == 2)
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_CNIC LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser, sql);

        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table;", dataGridViewUser, sql);
            dataGridViewUser.Columns[0].Visible = false;
            labelCountUser.Text = dataGridViewUser.Rows.Count.ToString();
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (radioButtonMale.Checked)
                Gender = "Male";
            else
                Gender = "Female";

            if (checkBoxRole.Checked)
                Role = "Admin";
            else
                Role = "User";

            if (textBoxName.Text.Trim() == string.Empty ||
                textBoxPass.Text.Trim() == string.Empty ||
                !maskedTextBoxPho.MaskCompleted ||
                maskedTextBoxPho.Text == "+00 000 0000000" ||
                !maskedTextBoxCNIC.MaskCompleted ||
                maskedTextBoxCNIC.Text == "0000000000000000" ||
                !IsValidDate(maskedTextBoxDOB.Text) ||
                maskedTextBoxDOB.Text == "00/00/0000" ||
                DateTime.Parse(maskedTextBoxDOB.Text) > DateTime.Now ||
                Gender == string.Empty ||
                !IsValidEmail(textBoxEmail.Text) ||
                textBoxEmail.Text == "rokhman@domain.com")
            {
                MessageBox.Show("Fill out all data.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check = Attendance.Attendance.AddRole(textBoxName.Text.Trim(), textBoxPass.Text.Trim(),
                maskedTextBoxPho.Text, maskedTextBoxCNIC.Text, maskedTextBoxDOB.Text, Gender, textBoxEmail.Text.Trim(),
                Role, textBoxAdd.Text.Trim(), sql);

                if (check)
                    ClearTextBox();
            }
        }

        private void tabPageAddUser_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageUPUser_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxPass1.Text = row.Cells[2].Value.ToString();
                maskedTextBoxPho1.Text = row.Cells[3].Value.ToString();
                maskedTextBoxPho1.ForeColor = Color.WhiteSmoke;
                maskedTextBoxCNIC1.Text = row.Cells[4].Value.ToString();
                maskedTextBoxCNIC1.ForeColor = Color.WhiteSmoke;
                maskedTextBoxDOB1.Text = row.Cells[5].Value.ToString();
                maskedTextBoxDOB1.ForeColor = Color.WhiteSmoke;
                Gender = row.Cells[6].Value.ToString();

                if (Gender == "Male")
                    radioButtonMale1.Checked = true;
                else
                    radioButtonFemale1.Checked = true;

                textBoxEmail1.Text = row.Cells[7].Value.ToString();
                textBoxEmail1.ForeColor = Color.WhiteSmoke;
                Role = row.Cells[8].Value.ToString();

                if (Role == "Admin")
                    checkBoxRole1.Checked = true;

                textBoxAdd1.Text = row.Cells[9].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonMale1.Checked)
                    Gender = "Male";
                else
                    Gender = "Female";

                if (checkBoxRole1.Checked)
                    Role = "Admin";
                else
                    Role = "User";

                if (textBoxName1.Text.Trim() == string.Empty ||
                    textBoxPass1.Text.Trim() == string.Empty ||
                    !maskedTextBoxPho1.MaskCompleted ||
                    maskedTextBoxPho1.Text == "+00 000 0000000" ||
                    !maskedTextBoxCNIC1.MaskCompleted ||
                    maskedTextBoxCNIC1.Text == "" ||
                    !IsValidDate(maskedTextBoxDOB1.Text) ||
                    maskedTextBoxDOB1.Text == "00/00/0000" ||
                    DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now ||
                    Gender == string.Empty ||
                    !IsValidEmail(textBoxEmail1.Text) ||
                    textBoxEmail1.Text == "")
                {
                    MessageBox.Show("Fill out all data.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateUser(ID, textBoxName1.Text.Trim(), textBoxPass1.Text.Trim(),
               maskedTextBoxPho1.Text, maskedTextBoxCNIC1.Text, maskedTextBoxDOB1.Text, Gender, textBoxEmail1.Text.Trim(),
               Role, textBoxAdd1.Text.Trim(), sql);

                    if (check)
                        ClearTextBox1();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(ID != "")
            {
                if (radioButtonMale1.Checked)
                    Gender = "Male";
                else
                    Gender = "Female";

                if (checkBoxRole1.Checked)
                    Role = "Admin";
                else
                    Role = "User";

                if (textBoxName1.Text.Trim() == string.Empty ||
                    textBoxPass1.Text.Trim() == string.Empty ||
                    !maskedTextBoxPho1.MaskCompleted ||
                    maskedTextBoxPho1.Text == "+00 000 0000000" ||
                    !maskedTextBoxCNIC1.MaskCompleted ||
                    maskedTextBoxCNIC1.Text == "" ||
                    !IsValidDate(maskedTextBoxDOB1.Text) ||
                    maskedTextBoxDOB1.Text == "00/00/0000" ||
                    DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now ||
                    Gender == string.Empty ||
                    !IsValidEmail(textBoxEmail1.Text) ||
                    textBoxEmail1.Text == "")
                {
                    MessageBox.Show("Fill out all data.", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Delete Account??", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteUser(ID, sql);

                        if (check)
                        ClearTextBox1();
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsValidDate(string date)
        {
            DateTime d;
            bool chValidity;
            try
            {
                return chValidity = DateTime.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
