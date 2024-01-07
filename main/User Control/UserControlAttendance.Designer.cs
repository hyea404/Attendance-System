namespace Attendance_System81.main.User_Control
{
    partial class UserControlAttendance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.dataGridViewMarkAttendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPageMarkAttendance);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.BackColor = System.Drawing.Color.DimGray;
            this.tabPageMarkAttendance.Controls.Add(this.dataGridViewMarkAttendance);
            this.tabPageMarkAttendance.Controls.Add(this.comboBoxClass);
            this.tabPageMarkAttendance.Controls.Add(this.dateTimePickerDate);
            this.tabPageMarkAttendance.Controls.Add(this.panel2);
            this.tabPageMarkAttendance.Controls.Add(this.label3);
            this.tabPageMarkAttendance.Controls.Add(this.label2);
            this.tabPageMarkAttendance.Controls.Add(this.panel1);
            this.tabPageMarkAttendance.Controls.Add(this.label1);
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(4, 25);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(792, 471);
            this.tabPageMarkAttendance.TabIndex = 0;
            this.tabPageMarkAttendance.Text = "Attendance";
            this.tabPageMarkAttendance.Leave += new System.EventHandler(this.tabPageMarkAttendance_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark Attendance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(13, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 472);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(33, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 472);
            this.panel2.TabIndex = 3;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(107, 62);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class :";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(537, 64);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(249, 24);
            this.comboBoxClass.TabIndex = 5;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            this.comboBoxClass.Click += new System.EventHandler(this.comboBoxClass_Click);
            // 
            // dataGridViewMarkAttendance
            // 
            this.dataGridViewMarkAttendance.AllowUserToAddRows = false;
            this.dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewMarkAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewMarkAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMarkAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMarkAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMarkAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarkAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMarkAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMarkAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarkAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewMarkAttendance.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewMarkAttendance.Location = new System.Drawing.Point(53, 94);
            this.dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            this.dataGridViewMarkAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewMarkAttendance.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMarkAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMarkAttendance.ShowCellErrors = false;
            this.dataGridViewMarkAttendance.ShowEditingIcon = false;
            this.dataGridViewMarkAttendance.ShowRowErrors = false;
            this.dataGridViewMarkAttendance.Size = new System.Drawing.Size(733, 371);
            this.dataGridViewMarkAttendance.TabIndex = 6;
            this.dataGridViewMarkAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMarkAttendance_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Reg";
            this.Column3.HeaderText = "Registration Code";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(800, 500);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMarkAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewMarkAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
