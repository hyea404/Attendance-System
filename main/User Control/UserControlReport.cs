using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System81.main.User_Control
{
    public partial class UserControlReport : UserControl
    {
        private string sql = @"Data Source=.\SQLEXPRESS;Initial Catalog=Attendance_Management_System;Integrated Security=True;";

        public UserControlReport()
        {
            InitializeComponent();
        }

        public void FirstTab()
        {
            tabControlReport.SelectedTab = tabPageClassReport;
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {

            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass, sql);
        }

        private void comboBoxClass1_Click(object sender, EventArgs e)
        {
            comboBoxClass1.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass1, sql);
        }

        private void comboBoxRegNo_Click(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1)
            {
                comboBoxRegNo.Items.Clear();
                Attendance.Attendance.FillComboBox("SELECT DISTINCT(Student_Reg) FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name = '" + comboBoxClass1.SelectedItem.ToString() + "';", comboBoxRegNo, sql);
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate.Text + "%' AND Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "';", dataGridViewClassReport, sql);
            }
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Class_Name = '" + comboBoxClass1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "' ;", dataGridViewStudentReport, sql);
            }
        }

        private void comboBoxClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Class_Name = '" + comboBoxClass1.SelectedItem.ToString() + "' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "' ;", dataGridViewStudentReport, sql);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save CSV File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Menulis header kolom
                        for (int i = 0; i < dataGridViewStudentReport.Columns.Count; i++)
                        {
                            writer.Write(dataGridViewStudentReport.Columns[i].HeaderText);
                            if (i < dataGridViewStudentReport.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Menulis data
                        for (int i = 0; i < dataGridViewStudentReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewStudentReport.Columns.Count; j++)
                            {
                                writer.Write(dataGridViewStudentReport.Rows[i].Cells[j].Value.ToString());
                                if (j < dataGridViewStudentReport.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Data has been exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonPrint1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save CSV File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Menulis header kolom
                        for (int i = 0; i < dataGridViewStudentReport.Columns.Count; i++)
                        {
                            writer.Write(dataGridViewStudentReport.Columns[i].HeaderText);
                            if (i < dataGridViewStudentReport.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Menulis data
                        for (int i = 0; i < dataGridViewStudentReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewStudentReport.Columns.Count; j++)
                            {
                                writer.Write(dataGridViewStudentReport.Rows[i].Cells[j].Value.ToString());
                                if (j < dataGridViewStudentReport.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Data has been exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
