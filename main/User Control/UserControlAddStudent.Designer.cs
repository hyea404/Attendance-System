namespace Attendance_System81.main.User_Control
{
    partial class UserControlAddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAddStudent = new System.Windows.Forms.TabControl();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxMale = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRegNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchStudent = new System.Windows.Forms.TabPage();
            this.labelCountStudent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageUPStudent = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButtonFemale1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMale1 = new System.Windows.Forms.RadioButton();
            this.comboBoxClass1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxRegNo1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlAddStudent.SuspendLayout();
            this.tabPageAddStudent.SuspendLayout();
            this.tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.tabPageUPStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            this.tabControlAddStudent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlAddStudent.Controls.Add(this.tabPageAddStudent);
            this.tabControlAddStudent.Controls.Add(this.tabPageSearchStudent);
            this.tabControlAddStudent.Controls.Add(this.tabPageUPStudent);
            this.tabControlAddStudent.Location = new System.Drawing.Point(0, 0);
            this.tabControlAddStudent.Multiline = true;
            this.tabControlAddStudent.Name = "tabControlAddStudent";
            this.tabControlAddStudent.SelectedIndex = 0;
            this.tabControlAddStudent.Size = new System.Drawing.Size(800, 400);
            this.tabControlAddStudent.TabIndex = 0;
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.BackColor = System.Drawing.Color.DimGray;
            this.tabPageAddStudent.Controls.Add(this.radioButtonFemale);
            this.tabPageAddStudent.Controls.Add(this.radioButtonMale);
            this.tabPageAddStudent.Controls.Add(this.comboBoxClass);
            this.tabPageAddStudent.Controls.Add(this.buttonAdd);
            this.tabPageAddStudent.Controls.Add(this.textBoxMale);
            this.tabPageAddStudent.Controls.Add(this.label11);
            this.tabPageAddStudent.Controls.Add(this.label7);
            this.tabPageAddStudent.Controls.Add(this.textBoxRegNo);
            this.tabPageAddStudent.Controls.Add(this.label3);
            this.tabPageAddStudent.Controls.Add(this.textBoxName);
            this.tabPageAddStudent.Controls.Add(this.label2);
            this.tabPageAddStudent.Controls.Add(this.label1);
            this.tabPageAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(792, 367);
            this.tabPageAddStudent.TabIndex = 0;
            this.tabPageAddStudent.Text = "Register New Student";
            this.tabPageAddStudent.Enter += new System.EventHandler(this.tabPageAddStudent_Enter);
            this.tabPageAddStudent.Leave += new System.EventHandler(this.tabPageAddStudent_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Location = new System.Drawing.Point(235, 292);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(332, 38);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Student";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxMale
            // 
            this.textBoxMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMale.BackColor = System.Drawing.Color.DimGray;
            this.textBoxMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxMale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMale.Location = new System.Drawing.Point(235, 247);
            this.textBoxMale.Name = "textBoxMale";
            this.textBoxMale.Size = new System.Drawing.Size(162, 26);
            this.textBoxMale.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(231, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Class :";
            // 
            // textBoxRegNo
            // 
            this.textBoxRegNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRegNo.BackColor = System.Drawing.Color.DimGray;
            this.textBoxRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRegNo.Location = new System.Drawing.Point(235, 184);
            this.textBoxRegNo.Name = "textBoxRegNo";
            this.textBoxRegNo.Size = new System.Drawing.Size(332, 26);
            this.textBoxRegNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registration Code :";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BackColor = System.Drawing.Color.DimGray;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName.Location = new System.Drawing.Point(235, 122);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(332, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New Student";
            // 
            // tabPageSearchStudent
            // 
            this.tabPageSearchStudent.BackColor = System.Drawing.Color.DimGray;
            this.tabPageSearchStudent.Controls.Add(this.comboBoxSearchBy);
            this.tabPageSearchStudent.Controls.Add(this.label14);
            this.tabPageSearchStudent.Controls.Add(this.labelCountStudent);
            this.tabPageSearchStudent.Controls.Add(this.label6);
            this.tabPageSearchStudent.Controls.Add(this.dataGridViewStudent);
            this.tabPageSearchStudent.Controls.Add(this.textBoxSearch);
            this.tabPageSearchStudent.Controls.Add(this.label4);
            this.tabPageSearchStudent.Controls.Add(this.label5);
            this.tabPageSearchStudent.ForeColor = System.Drawing.Color.DimGray;
            this.tabPageSearchStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchStudent.Name = "tabPageSearchStudent";
            this.tabPageSearchStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchStudent.Size = new System.Drawing.Size(792, 367);
            this.tabPageSearchStudent.TabIndex = 1;
            this.tabPageSearchStudent.Text = "Search Student";
            this.tabPageSearchStudent.Enter += new System.EventHandler(this.tabPageSearchStudent_Enter);
            // 
            // labelCountStudent
            // 
            this.labelCountStudent.AutoSize = true;
            this.labelCountStudent.BackColor = System.Drawing.Color.Transparent;
            this.labelCountStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountStudent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCountStudent.Location = new System.Drawing.Point(116, 126);
            this.labelCountStudent.Name = "labelCountStudent";
            this.labelCountStudent.Size = new System.Drawing.Size(28, 20);
            this.labelCountStudent.TabIndex = 0;
            this.labelCountStudent.Text = "(?)";
            this.labelCountStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Student : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AllowUserToAddRows = false;
            this.dataGridViewStudent.AllowUserToDeleteRows = false;
            this.dataGridViewStudent.AllowUserToResizeColumns = false;
            this.dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewStudent.GridColor = System.Drawing.Color.DimGray;
            this.dataGridViewStudent.Location = new System.Drawing.Point(6, 149);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.ReadOnly = true;
            this.dataGridViewStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStudent.ShowCellErrors = false;
            this.dataGridViewStudent.ShowEditingIcon = false;
            this.dataGridViewStudent.ShowRowErrors = false;
            this.dataGridViewStudent.Size = new System.Drawing.Size(780, 212);
            this.dataGridViewStudent.TabIndex = 0;
            this.dataGridViewStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudent_CellClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxSearch.Location = new System.Drawing.Point(76, 74);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(478, 26);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(72, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search Student";
            // 
            // tabPageUPStudent
            // 
            this.tabPageUPStudent.BackColor = System.Drawing.Color.DimGray;
            this.tabPageUPStudent.Controls.Add(this.radioButtonFemale1);
            this.tabPageUPStudent.Controls.Add(this.radioButtonMale1);
            this.tabPageUPStudent.Controls.Add(this.comboBoxClass1);
            this.tabPageUPStudent.Controls.Add(this.label8);
            this.tabPageUPStudent.Controls.Add(this.label9);
            this.tabPageUPStudent.Controls.Add(this.textBoxRegNo1);
            this.tabPageUPStudent.Controls.Add(this.label12);
            this.tabPageUPStudent.Controls.Add(this.textBoxName1);
            this.tabPageUPStudent.Controls.Add(this.label13);
            this.tabPageUPStudent.Controls.Add(this.buttonDelete);
            this.tabPageUPStudent.Controls.Add(this.buttonUpdate);
            this.tabPageUPStudent.Controls.Add(this.label10);
            this.tabPageUPStudent.Location = new System.Drawing.Point(4, 4);
            this.tabPageUPStudent.Name = "tabPageUPStudent";
            this.tabPageUPStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUPStudent.Size = new System.Drawing.Size(792, 367);
            this.tabPageUPStudent.TabIndex = 2;
            this.tabPageUPStudent.Text = "Student Management";
            this.tabPageUPStudent.Leave += new System.EventHandler(this.tabPageUPStudent_Leave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDelete.Location = new System.Drawing.Point(405, 292);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(162, 38);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.buttonUpdate.Location = new System.Drawing.Point(235, 292);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(162, 38);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(184, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Student Management Account";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.BackColor = System.Drawing.Color.DimGray;
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(235, 247);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(162, 28);
            this.comboBoxClass.TabIndex = 3;
            this.comboBoxClass.Click += new System.EventHandler(this.comboBoxClass_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(405, 252);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 22);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(492, 252);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 22);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.BackColor = System.Drawing.Color.DimGray;
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Name",
            "Registration Code",
            "Class"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(560, 72);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(162, 28);
            this.comboBoxSearchBy.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(556, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Filter";
            // 
            // radioButtonFemale1
            // 
            this.radioButtonFemale1.AutoSize = true;
            this.radioButtonFemale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale1.Location = new System.Drawing.Point(492, 252);
            this.radioButtonFemale1.Name = "radioButtonFemale1";
            this.radioButtonFemale1.Size = new System.Drawing.Size(75, 22);
            this.radioButtonFemale1.TabIndex = 5;
            this.radioButtonFemale1.TabStop = true;
            this.radioButtonFemale1.Text = "Female";
            this.radioButtonFemale1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale1
            // 
            this.radioButtonMale1.AutoSize = true;
            this.radioButtonMale1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale1.Location = new System.Drawing.Point(405, 252);
            this.radioButtonMale1.Name = "radioButtonMale1";
            this.radioButtonMale1.Size = new System.Drawing.Size(58, 22);
            this.radioButtonMale1.TabIndex = 4;
            this.radioButtonMale1.TabStop = true;
            this.radioButtonMale1.Text = "Male";
            this.radioButtonMale1.UseVisualStyleBackColor = true;
            // 
            // comboBoxClass1
            // 
            this.comboBoxClass1.BackColor = System.Drawing.Color.DimGray;
            this.comboBoxClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxClass1.FormattingEnabled = true;
            this.comboBoxClass1.Location = new System.Drawing.Point(235, 247);
            this.comboBoxClass1.Name = "comboBoxClass1";
            this.comboBoxClass1.Size = new System.Drawing.Size(162, 28);
            this.comboBoxClass1.TabIndex = 9;
            this.comboBoxClass1.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Class :";
            // 
            // textBoxRegNo1
            // 
            this.textBoxRegNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRegNo1.BackColor = System.Drawing.Color.DimGray;
            this.textBoxRegNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRegNo1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxRegNo1.Location = new System.Drawing.Point(235, 184);
            this.textBoxRegNo1.Name = "textBoxRegNo1";
            this.textBoxRegNo1.Size = new System.Drawing.Size(332, 26);
            this.textBoxRegNo1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(231, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Registration Code :";
            // 
            // textBoxName1
            // 
            this.textBoxName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName1.BackColor = System.Drawing.Color.DimGray;
            this.textBoxName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxName1.Location = new System.Drawing.Point(235, 122);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(332, 26);
            this.textBoxName1.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(231, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Name :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Reg";
            this.Column3.HeaderText = "Registration Code";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Class_Name";
            this.Column4.HeaderText = "Class";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Student_Gender";
            this.Column5.HeaderText = "Gender";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // UserControlAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tabControlAddStudent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlAddStudent";
            this.Size = new System.Drawing.Size(800, 400);
            this.tabControlAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.ResumeLayout(false);
            this.tabPageAddStudent.PerformLayout();
            this.tabPageSearchStudent.ResumeLayout(false);
            this.tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.tabPageUPStudent.ResumeLayout(false);
            this.tabPageUPStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAddStudent;
        private System.Windows.Forms.TabPage tabPageAddStudent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRegNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchStudent;
        private System.Windows.Forms.Label labelCountStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageUPStudent;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButtonFemale1;
        private System.Windows.Forms.RadioButton radioButtonMale1;
        private System.Windows.Forms.ComboBox comboBoxClass1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxRegNo1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
