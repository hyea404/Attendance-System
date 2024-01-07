namespace Attendance_System81.main.User_Control
{
    partial class UserControlReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageClassReport = new System.Windows.Forms.TabPage();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewClassReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageStudentReport = new System.Windows.Forms.TabPage();
            this.buttonPrint1 = new System.Windows.Forms.Button();
            this.dataGridViewStudentReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.comboBoxClass1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlReport.SuspendLayout();
            this.tabPageClassReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassReport)).BeginInit();
            this.tabPageStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReport
            // 
            this.tabControlReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReport.Controls.Add(this.tabPageClassReport);
            this.tabControlReport.Controls.Add(this.tabPageStudentReport);
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(800, 500);
            this.tabControlReport.TabIndex = 1;
            // 
            // tabPageClassReport
            // 
            this.tabPageClassReport.BackColor = System.Drawing.Color.DimGray;
            this.tabPageClassReport.Controls.Add(this.buttonPrint);
            this.tabPageClassReport.Controls.Add(this.dataGridViewClassReport);
            this.tabPageClassReport.Controls.Add(this.comboBoxClass);
            this.tabPageClassReport.Controls.Add(this.dateTimePickerDate);
            this.tabPageClassReport.Controls.Add(this.panel2);
            this.tabPageClassReport.Controls.Add(this.label3);
            this.tabPageClassReport.Controls.Add(this.label2);
            this.tabPageClassReport.Controls.Add(this.panel1);
            this.tabPageClassReport.Controls.Add(this.label1);
            this.tabPageClassReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageClassReport.Name = "tabPageClassReport";
            this.tabPageClassReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassReport.Size = new System.Drawing.Size(792, 471);
            this.tabPageClassReport.TabIndex = 0;
            this.tabPageClassReport.Text = "Class Report";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.ForeColor = System.Drawing.Color.DimGray;
            this.buttonPrint.Location = new System.Drawing.Point(690, 33);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(96, 25);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Export csv";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewClassReport
            // 
            this.dataGridViewClassReport.AllowUserToAddRows = false;
            this.dataGridViewClassReport.AllowUserToDeleteRows = false;
            this.dataGridViewClassReport.AllowUserToResizeColumns = false;
            this.dataGridViewClassReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClassReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClassReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClassReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClassReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClassReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClassReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewClassReport.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewClassReport.Location = new System.Drawing.Point(53, 94);
            this.dataGridViewClassReport.Name = "dataGridViewClassReport";
            this.dataGridViewClassReport.ReadOnly = true;
            this.dataGridViewClassReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClassReport.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClassReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClassReport.ShowCellErrors = false;
            this.dataGridViewClassReport.ShowEditingIcon = false;
            this.dataGridViewClassReport.ShowRowErrors = false;
            this.dataGridViewClassReport.Size = new System.Drawing.Size(733, 371);
            this.dataGridViewClassReport.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_Name";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Reg";
            this.Column2.HeaderText = "Registration Code ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Class_Name";
            this.Column3.HeaderText = "Class";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Attendance_Date";
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(33, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 472);
            this.panel2.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(13, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 472);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Report";
            // 
            // tabPageStudentReport
            // 
            this.tabPageStudentReport.BackColor = System.Drawing.Color.DimGray;
            this.tabPageStudentReport.Controls.Add(this.buttonPrint1);
            this.tabPageStudentReport.Controls.Add(this.dataGridViewStudentReport);
            this.tabPageStudentReport.Controls.Add(this.comboBoxRegNo);
            this.tabPageStudentReport.Controls.Add(this.comboBoxClass1);
            this.tabPageStudentReport.Controls.Add(this.dateTimePickerDate1);
            this.tabPageStudentReport.Controls.Add(this.label7);
            this.tabPageStudentReport.Controls.Add(this.panel3);
            this.tabPageStudentReport.Controls.Add(this.label4);
            this.tabPageStudentReport.Controls.Add(this.label5);
            this.tabPageStudentReport.Controls.Add(this.panel4);
            this.tabPageStudentReport.Controls.Add(this.label6);
            this.tabPageStudentReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudentReport.Name = "tabPageStudentReport";
            this.tabPageStudentReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentReport.Size = new System.Drawing.Size(792, 471);
            this.tabPageStudentReport.TabIndex = 1;
            this.tabPageStudentReport.Text = "Student Report";
            // 
            // buttonPrint1
            // 
            this.buttonPrint1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPrint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint1.ForeColor = System.Drawing.Color.DimGray;
            this.buttonPrint1.Location = new System.Drawing.Point(690, 33);
            this.buttonPrint1.Name = "buttonPrint1";
            this.buttonPrint1.Size = new System.Drawing.Size(96, 25);
            this.buttonPrint1.TabIndex = 13;
            this.buttonPrint1.Text = "Export csv";
            this.buttonPrint1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewStudentReport
            // 
            this.dataGridViewStudentReport.AllowUserToAddRows = false;
            this.dataGridViewStudentReport.AllowUserToDeleteRows = false;
            this.dataGridViewStudentReport.AllowUserToResizeColumns = false;
            this.dataGridViewStudentReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewStudentReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudentReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewStudentReport.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewStudentReport.Location = new System.Drawing.Point(53, 94);
            this.dataGridViewStudentReport.Name = "dataGridViewStudentReport";
            this.dataGridViewStudentReport.ReadOnly = true;
            this.dataGridViewStudentReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewStudentReport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStudentReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudentReport.ShowCellErrors = false;
            this.dataGridViewStudentReport.ShowEditingIcon = false;
            this.dataGridViewStudentReport.ShowRowErrors = false;
            this.dataGridViewStudentReport.Size = new System.Drawing.Size(733, 371);
            this.dataGridViewStudentReport.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Student_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Student_Reg";
            this.dataGridViewTextBoxColumn2.HeaderText = "Registration Code ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Class_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Class";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Attendance_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Attendance_Status";
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // comboBoxRegNo
            // 
            this.comboBoxRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(644, 64);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(142, 24);
            this.comboBoxRegNo.TabIndex = 3;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);
            this.comboBoxRegNo.Click += new System.EventHandler(this.comboBoxRegNo_Click);
            // 
            // comboBoxClass1
            // 
            this.comboBoxClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass1.FormattingEnabled = true;
            this.comboBoxClass1.Location = new System.Drawing.Point(406, 64);
            this.comboBoxClass1.Name = "comboBoxClass1";
            this.comboBoxClass1.Size = new System.Drawing.Size(142, 24);
            this.comboBoxClass1.TabIndex = 2;
            this.comboBoxClass1.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass1_SelectedIndexChanged);
            this.comboBoxClass1.Click += new System.EventHandler(this.comboBoxClass1_Click);
            // 
            // dateTimePickerDate1
            // 
            this.dateTimePickerDate1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate1.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePickerDate1.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dateTimePickerDate1.CustomFormat = "MM/yyyy";
            this.dateTimePickerDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate1.Location = new System.Drawing.Point(107, 62);
            this.dateTimePickerDate1.Name = "dateTimePickerDate1";
            this.dateTimePickerDate1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDate1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(554, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reg Code:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(33, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 472);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(13, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 472);
            this.panel4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student Report";
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tabControlReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(800, 500);
            this.tabControlReport.ResumeLayout(false);
            this.tabPageClassReport.ResumeLayout(false);
            this.tabPageClassReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassReport)).EndInit();
            this.tabPageStudentReport.ResumeLayout(false);
            this.tabPageStudentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReport;
        private System.Windows.Forms.TabPage tabPageClassReport;
        private System.Windows.Forms.DataGridView dataGridViewClassReport;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageStudentReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView dataGridViewStudentReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBoxClass1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRegNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPrint1;
    }
}
