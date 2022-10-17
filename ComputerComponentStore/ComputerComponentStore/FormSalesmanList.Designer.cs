namespace ComputerComponentStore
{
    partial class FormSalesmanList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dateTimePickerDoj = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.panelGender = new System.Windows.Forms.Panel();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelDoB = new System.Windows.Forms.Label();
            this.labelShift = new System.Windows.Forms.Label();
            this.labelBonus = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelDoJ = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxBonus = new System.Windows.Forms.TextBox();
            this.textBoxSalName = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelSalesmanList = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSalesmanList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofJoining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesmanList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBoxShift);
            this.panel1.Controls.Add(this.labelSearchByName);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.dateTimePickerDoj);
            this.panel1.Controls.Add(this.dateTimePickerDob);
            this.panel1.Controls.Add(this.panelGender);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.labelDoB);
            this.panel1.Controls.Add(this.labelShift);
            this.panel1.Controls.Add(this.labelBonus);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelDoJ);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.textBoxSalary);
            this.panel1.Controls.Add(this.textBoxBonus);
            this.panel1.Controls.Add(this.textBoxSalName);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.labelSalesmanList);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 665);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.comboBoxShift.Location = new System.Drawing.Point(165, 455);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(222, 28);
            this.comboBoxShift.TabIndex = 32;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchByName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSearchByName.Location = new System.Drawing.Point(300, 81);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(140, 20);
            this.labelSearchByName.TabIndex = 31;
            this.labelSearchByName.Text = "Search by Name";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(299, 105);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(170, 26);
            this.textBoxSearch.TabIndex = 30;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dateTimePickerDoj
            // 
            this.dateTimePickerDoj.CustomFormat = "mn-dy-yy";
            this.dateTimePickerDoj.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDoj.Location = new System.Drawing.Point(166, 298);
            this.dateTimePickerDoj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDoj.Name = "dateTimePickerDoj";
            this.dateTimePickerDoj.Size = new System.Drawing.Size(222, 26);
            this.dateTimePickerDoj.TabIndex = 29;
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Checked = false;
            this.dateTimePickerDob.CustomFormat = "mn-dy-yy";
            this.dateTimePickerDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDob.Location = new System.Drawing.Point(168, 515);
            this.dateTimePickerDob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(222, 26);
            this.dateTimePickerDob.TabIndex = 28;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.labelGender);
            this.panelGender.Controls.Add(this.radioButtonMale);
            this.panelGender.Controls.Add(this.radioButtonFemale);
            this.panelGender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGender.Location = new System.Drawing.Point(0, 607);
            this.panelGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(479, 58);
            this.panelGender.TabIndex = 27;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(25, 18);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(71, 20);
            this.labelGender.TabIndex = 27;
            this.labelGender.Text = "Gender :";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(165, 16);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(68, 24);
            this.radioButtonMale.TabIndex = 25;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(266, 16);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 24);
            this.radioButtonFemale.TabIndex = 26;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(287, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 22);
            this.label10.TabIndex = 24;
            this.label10.Text = "mn - dy - yy";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(22, 569);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(83, 20);
            this.labelPhone.TabIndex = 23;
            this.labelPhone.Text = "Phone No:";
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Location = new System.Drawing.Point(24, 515);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(107, 20);
            this.labelDoB.TabIndex = 22;
            this.labelDoB.Text = "Date of Birth :";
            // 
            // labelShift
            // 
            this.labelShift.AutoSize = true;
            this.labelShift.Location = new System.Drawing.Point(25, 458);
            this.labelShift.Name = "labelShift";
            this.labelShift.Size = new System.Drawing.Size(50, 20);
            this.labelShift.TabIndex = 21;
            this.labelShift.Text = "Shift :";
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Location = new System.Drawing.Point(25, 408);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(59, 20);
            this.labelBonus.TabIndex = 20;
            this.labelBonus.Text = "Bonus:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(25, 352);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(61, 20);
            this.labelSalary.TabIndex = 19;
            this.labelSalary.Text = "Salary :";
            // 
            // labelDoJ
            // 
            this.labelDoJ.AutoSize = true;
            this.labelDoJ.Location = new System.Drawing.Point(25, 298);
            this.labelDoJ.Name = "labelDoJ";
            this.labelDoJ.Size = new System.Drawing.Size(124, 20);
            this.labelDoJ.TabIndex = 18;
            this.labelDoJ.Text = "Date of Joining :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 228);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 20);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Salesman Name :";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(25, 172);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(106, 20);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "Salesman Id :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(166, 566);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(221, 26);
            this.textBoxPhone.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(285, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "mn - dy- yy";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 9);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(68, 31);
            this.buttonBack.TabIndex = 9;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(168, 352);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(222, 26);
            this.textBoxSalary.TabIndex = 8;
            // 
            // textBoxBonus
            // 
            this.textBoxBonus.Location = new System.Drawing.Point(166, 405);
            this.textBoxBonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBonus.Name = "textBoxBonus";
            this.textBoxBonus.Size = new System.Drawing.Size(222, 26);
            this.textBoxBonus.TabIndex = 7;
            // 
            // textBoxSalName
            // 
            this.textBoxSalName.Location = new System.Drawing.Point(166, 228);
            this.textBoxSalName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalName.Name = "textBoxSalName";
            this.textBoxSalName.Size = new System.Drawing.Size(222, 26);
            this.textBoxSalName.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(166, 170);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(222, 26);
            this.textBoxId.TabIndex = 5;
            // 
            // labelSalesmanList
            // 
            this.labelSalesmanList.AutoSize = true;
            this.labelSalesmanList.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesmanList.Location = new System.Drawing.Point(86, 8);
            this.labelSalesmanList.Name = "labelSalesmanList";
            this.labelSalesmanList.Size = new System.Drawing.Size(242, 33);
            this.labelSalesmanList.TabIndex = 4;
            this.labelSalesmanList.Text = "SALESMAN LIST";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(202, 75);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 56);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(105, 75);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 56);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(8, 75);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(91, 56);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSalesmanList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(479, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 665);
            this.panel2.TabIndex = 1;
            // 
            // dgvSalesmanList
            // 
            this.dgvSalesmanList.AllowUserToAddRows = false;
            this.dgvSalesmanList.AllowUserToDeleteRows = false;
            this.dgvSalesmanList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSalesmanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesmanList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SalesmanName,
            this.DateofJoining,
            this.Salary,
            this.Bonus,
            this.Shift,
            this.DateofBirth,
            this.Gender,
            this.Contect});
            this.dgvSalesmanList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesmanList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSalesmanList.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesmanList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSalesmanList.Name = "dgvSalesmanList";
            this.dgvSalesmanList.ReadOnly = true;
            this.dgvSalesmanList.RowHeadersWidth = 51;
            this.dgvSalesmanList.RowTemplate.Height = 28;
            this.dgvSalesmanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesmanList.Size = new System.Drawing.Size(873, 665);
            this.dgvSalesmanList.TabIndex = 0;
            this.dgvSalesmanList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesmanList_CellContentClick);
            this.dgvSalesmanList.DoubleClick += new System.EventHandler(this.dgvSalesmanList_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.ToolTipText = "Salesman Id";
            // 
            // SalesmanName
            // 
            this.SalesmanName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesmanName.DataPropertyName = "Name";
            this.SalesmanName.HeaderText = "Salesman Name";
            this.SalesmanName.MinimumWidth = 6;
            this.SalesmanName.Name = "SalesmanName";
            this.SalesmanName.ReadOnly = true;
            // 
            // DateofJoining
            // 
            this.DateofJoining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateofJoining.DataPropertyName = "Date of Joining";
            this.DateofJoining.HeaderText = "Date of Joining";
            this.DateofJoining.MinimumWidth = 6;
            this.DateofJoining.Name = "DateofJoining";
            this.DateofJoining.ReadOnly = true;
            this.DateofJoining.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateofJoining.ToolTipText = "Join Date";
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Salary.ToolTipText = "Salary";
            // 
            // Bonus
            // 
            this.Bonus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bonus.DataPropertyName = "Bonus";
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.MinimumWidth = 6;
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            this.Bonus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bonus.ToolTipText = "Bonus";
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Shift.DataPropertyName = "Shift";
            this.Shift.HeaderText = "Shift";
            this.Shift.MinimumWidth = 6;
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Shift.ToolTipText = "Shift";
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateofBirth.DataPropertyName = "Date of Birth";
            this.DateofBirth.HeaderText = "Date of Birth";
            this.DateofBirth.MinimumWidth = 6;
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.ReadOnly = true;
            this.DateofBirth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateofBirth.ToolTipText = "Birth date";
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Gender.ToolTipText = "Gender";
            // 
            // Contect
            // 
            this.Contect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contect.DataPropertyName = "Contact";
            this.Contect.HeaderText = "Contect";
            this.Contect.MinimumWidth = 6;
            this.Contect.Name = "Contect";
            this.Contect.ReadOnly = true;
            this.Contect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Contect.ToolTipText = "Phone No";
            // 
            // FormSalesmanList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormSalesmanList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSalesmanList_FormClosed);
            this.Load += new System.EventHandler(this.FormSalesmanList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesmanList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxBonus;
        private System.Windows.Forms.TextBox textBoxSalName;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelSalesmanList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSalesmanList;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelDoB;
        private System.Windows.Forms.Label labelShift;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelDoJ;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofJoining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contect;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoj;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.ComboBox comboBoxShift;
    }
}