namespace ExaminationSystem.UI
{
    partial class InstructorForm
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
            metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            tabPage0 = new TabPage();


            numInstructorSalaryMA = new MetroSet_UI.Controls.MetroSetTextBox();
            txtInstructorIDMA = new MetroSet_UI.Controls.MetroSetTextBox();
            txtInstructorDepartmentMA = new MetroSet_UI.Controls.MetroSetTextBox();
            lblInstructorDeparmentMA = new MetroSet_UI.Controls.MetroSetLabel();
            txtInstructorUserNameMA = new MetroSet_UI.Controls.MetroSetTextBox();
            txtInstructorDegreeMA = new MetroSet_UI.Controls.MetroSetTextBox();
            txtInstructorNameMA = new MetroSet_UI.Controls.MetroSetTextBox();
            lblInstructorDegreeMA = new MetroSet_UI.Controls.MetroSetLabel();
            lblInstructorSalaryMA = new MetroSet_UI.Controls.MetroSetLabel();
            lblInstructorUserNameMA = new MetroSet_UI.Controls.MetroSetLabel();
            lblInstrutorNameMA = new MetroSet_UI.Controls.MetroSetLabel();
            labInstIDMA = new MetroSet_UI.Controls.MetroSetLabel();


            tabPage2 = new TabPage();
            lblNumTFf = new MetroSet_UI.Controls.MetroSetLabel();
            lblCoursef = new MetroSet_UI.Controls.MetroSetLabel();
            comboboxCoursef = new MetroSet_UI.Controls.MetroSetComboBox();
            lblNumMcqf = new MetroSet_UI.Controls.MetroSetLabel();
            btnGenerateExam = new MetroSet_UI.Controls.MetroSetButton();
            numericTFf = new NumericUpDown();
            numericMcqf = new NumericUpDown();
            tabPage3 = new TabPage();
            gradesGridView = new DataGridView();
            tabPage4 = new TabPage();
            Save = new MetroSet_UI.Controls.MetroSetButton();
            dateTime1 = new DateTimePicker();
            numericmf = new NumericUpDown();
            numeric2mf = new NumericUpDown();
            TextBox5mf = new MetroSet_UI.Controls.MetroSetTextBox();
            TextBox4mf = new MetroSet_UI.Controls.MetroSetTextBox();
            TextBox3mf = new MetroSet_UI.Controls.MetroSetTextBox();
            metroSetLabel13 = new MetroSet_UI.Controls.MetroSetLabel();
            Label12mf = new MetroSet_UI.Controls.MetroSetLabel();
            Label11mf = new MetroSet_UI.Controls.MetroSetLabel();
            label10mf = new MetroSet_UI.Controls.MetroSetLabel();
            Label9mf = new MetroSet_UI.Controls.MetroSetLabel();
            Label8mf = new MetroSet_UI.Controls.MetroSetLabel();
            Label7 = new MetroSet_UI.Controls.MetroSetLabel();
            tabPage5 = new TabPage();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetTabControl1.SuspendLayout();
            tabPage0.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTFf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMcqf).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGridView).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericmf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric2mf).BeginInit();
            SuspendLayout();
            // 
            // metroSetTabControl1
            // 
            metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            metroSetTabControl1.AnimateTime = 200;
            metroSetTabControl1.BackgroundColor = Color.White;
            metroSetTabControl1.Controls.Add(tabPage0);
            metroSetTabControl1.Controls.Add(tabPage2);
            metroSetTabControl1.Controls.Add(tabPage3);
            metroSetTabControl1.Controls.Add(tabPage4);
            metroSetTabControl1.Controls.Add(tabPage5);
            metroSetTabControl1.IsDerivedStyle = true;
            metroSetTabControl1.ItemSize = new Size(100, 38);
            metroSetTabControl1.Location = new Point(15, 73);
            metroSetTabControl1.Name = "metroSetTabControl1";


            metroSetTabControl1.SelectedIndex = 1;

            metroSetTabControl1.SelectedTextColor = Color.White;
            metroSetTabControl1.Size = new Size(1238, 620);
            metroSetTabControl1.SizeMode = TabSizeMode.Fixed;
            metroSetTabControl1.Speed = 100;
            metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetTabControl1.StyleManager = null;
            metroSetTabControl1.TabIndex = 0;
            metroSetTabControl1.ThemeAuthor = "Narwin";
            metroSetTabControl1.ThemeName = "MetroLite";
            metroSetTabControl1.UnselectedTextColor = Color.Gray;
            metroSetTabControl1.UseAnimation = false;
            metroSetTabControl1.SelectedIndexChanged += metroSetTabControl1_SelectedIndexChanged;
            // 
            // tabPage0
            // 
            tabPage0.Controls.Add(numInstructorSalaryMA);
            tabPage0.Controls.Add(txtInstructorIDMA);
            tabPage0.Controls.Add(txtInstructorDepartmentMA);
            tabPage0.Controls.Add(lblInstructorDeparmentMA);
            tabPage0.Controls.Add(txtInstructorUserNameMA);
            tabPage0.Controls.Add(txtInstructorDegreeMA);
            tabPage0.Controls.Add(txtInstructorNameMA);
            tabPage0.Controls.Add(lblInstructorDegreeMA);
            tabPage0.Controls.Add(lblInstructorSalaryMA);
            tabPage0.Controls.Add(lblInstructorUserNameMA);
            tabPage0.Controls.Add(lblInstrutorNameMA);
            tabPage0.Controls.Add(labInstIDMA);
            tabPage0.Location = new Point(4, 42);
            tabPage0.Name = "tabPage0";
            tabPage0.Size = new Size(1230, 574);
            tabPage0.TabIndex = 0;
            tabPage0.Text = "Profile";
            

            // numInstructorSalaryMA
            // 
            numInstructorSalaryMA.AutoCompleteCustomSource = null;
            numInstructorSalaryMA.AutoCompleteMode = AutoCompleteMode.None;
            numInstructorSalaryMA.AutoCompleteSource = AutoCompleteSource.None;
            numInstructorSalaryMA.BorderColor = Color.FromArgb(155, 155, 155);
            numInstructorSalaryMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            numInstructorSalaryMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            numInstructorSalaryMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            numInstructorSalaryMA.Enabled = false;
            numInstructorSalaryMA.Font = new Font("Microsoft Sans Serif", 10F);
            numInstructorSalaryMA.HoverColor = Color.FromArgb(102, 102, 102);
            numInstructorSalaryMA.Image = null;
            numInstructorSalaryMA.IsDerivedStyle = true;
            numInstructorSalaryMA.Lines = null;
            numInstructorSalaryMA.Location = new Point(588, 29);
            numInstructorSalaryMA.MaxLength = 32767;
            numInstructorSalaryMA.Multiline = false;
            numInstructorSalaryMA.Name = "numInstructorSalaryMA";
            numInstructorSalaryMA.ReadOnly = true;
            numInstructorSalaryMA.Size = new Size(169, 38);
            numInstructorSalaryMA.Style = MetroSet_UI.Enums.Style.Light;
            numInstructorSalaryMA.StyleManager = null;
            numInstructorSalaryMA.TabIndex = 17;
            numInstructorSalaryMA.TextAlign = HorizontalAlignment.Left;
            numInstructorSalaryMA.ThemeAuthor = "Narwin";
            numInstructorSalaryMA.ThemeName = "MetroLite";
            numInstructorSalaryMA.UseSystemPasswordChar = false;
            numInstructorSalaryMA.WatermarkText = "";
            // 
            // txtInstructorIDMA
            // 
            txtInstructorIDMA.AutoCompleteCustomSource = null;
            txtInstructorIDMA.AutoCompleteMode = AutoCompleteMode.None;
            txtInstructorIDMA.AutoCompleteSource = AutoCompleteSource.None;
            txtInstructorIDMA.BorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorIDMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtInstructorIDMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorIDMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtInstructorIDMA.Enabled = false;
            txtInstructorIDMA.Font = new Font("Microsoft Sans Serif", 10F);
            txtInstructorIDMA.HoverColor = Color.FromArgb(102, 102, 102);
            txtInstructorIDMA.Image = null;
            txtInstructorIDMA.IsDerivedStyle = true;
            txtInstructorIDMA.Lines = null;
            txtInstructorIDMA.Location = new Point(196, 29);
            txtInstructorIDMA.MaxLength = 32767;
            txtInstructorIDMA.Multiline = false;
            txtInstructorIDMA.Name = "txtInstructorIDMA";
            txtInstructorIDMA.ReadOnly = true;
            txtInstructorIDMA.Size = new Size(169, 38);
            txtInstructorIDMA.Style = MetroSet_UI.Enums.Style.Light;
            txtInstructorIDMA.StyleManager = null;
            txtInstructorIDMA.TabIndex = 16;
            txtInstructorIDMA.TextAlign = HorizontalAlignment.Left;
            txtInstructorIDMA.ThemeAuthor = "Narwin";
            txtInstructorIDMA.ThemeName = "MetroLite";
            txtInstructorIDMA.UseSystemPasswordChar = false;
            txtInstructorIDMA.WatermarkText = "";
            // 
            // txtInstructorDepartmentMA
            // 
            txtInstructorDepartmentMA.AutoCompleteCustomSource = null;
            txtInstructorDepartmentMA.AutoCompleteMode = AutoCompleteMode.None;
            txtInstructorDepartmentMA.AutoCompleteSource = AutoCompleteSource.None;
            txtInstructorDepartmentMA.BorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorDepartmentMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtInstructorDepartmentMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorDepartmentMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtInstructorDepartmentMA.Enabled = false;
            txtInstructorDepartmentMA.Font = new Font("Microsoft Sans Serif", 10F);
            txtInstructorDepartmentMA.HoverColor = Color.FromArgb(102, 102, 102);
            txtInstructorDepartmentMA.Image = null;
            txtInstructorDepartmentMA.IsDerivedStyle = true;
            txtInstructorDepartmentMA.Lines = null;
            txtInstructorDepartmentMA.Location = new Point(588, 167);
            txtInstructorDepartmentMA.MaxLength = 32767;
            txtInstructorDepartmentMA.Multiline = false;
            txtInstructorDepartmentMA.Name = "txtInstructorDepartmentMA";
            txtInstructorDepartmentMA.ReadOnly = true;
            txtInstructorDepartmentMA.Size = new Size(169, 38);
            txtInstructorDepartmentMA.Style = MetroSet_UI.Enums.Style.Light;
            txtInstructorDepartmentMA.StyleManager = null;
            txtInstructorDepartmentMA.TabIndex = 14;
            txtInstructorDepartmentMA.TextAlign = HorizontalAlignment.Left;
            txtInstructorDepartmentMA.ThemeAuthor = "Narwin";
            txtInstructorDepartmentMA.ThemeName = "MetroLite";
            txtInstructorDepartmentMA.UseSystemPasswordChar = false;
            txtInstructorDepartmentMA.WatermarkText = "";
            // 
            // lblInstructorDeparmentMA
            // 
            lblInstructorDeparmentMA.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructorDeparmentMA.IsDerivedStyle = true;
            lblInstructorDeparmentMA.Location = new Point(444, 176);
            lblInstructorDeparmentMA.Name = "lblInstructorDeparmentMA";
            lblInstructorDeparmentMA.Size = new Size(125, 29);
            lblInstructorDeparmentMA.Style = MetroSet_UI.Enums.Style.Light;
            lblInstructorDeparmentMA.StyleManager = null;
            lblInstructorDeparmentMA.TabIndex = 11;
            lblInstructorDeparmentMA.Text = "Department";
            lblInstructorDeparmentMA.ThemeAuthor = "Narwin";
            lblInstructorDeparmentMA.ThemeName = "MetroLite";
            // 
            // txtInstructorUserNameMA
            // 
            txtInstructorUserNameMA.AutoCompleteCustomSource = null;
            txtInstructorUserNameMA.AutoCompleteMode = AutoCompleteMode.None;
            txtInstructorUserNameMA.AutoCompleteSource = AutoCompleteSource.None;
            txtInstructorUserNameMA.BorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorUserNameMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtInstructorUserNameMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorUserNameMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtInstructorUserNameMA.Enabled = false;
            txtInstructorUserNameMA.Font = new Font("Microsoft Sans Serif", 10F);
            txtInstructorUserNameMA.HoverColor = Color.FromArgb(102, 102, 102);
            txtInstructorUserNameMA.Image = null;
            txtInstructorUserNameMA.IsDerivedStyle = true;
            txtInstructorUserNameMA.Lines = null;
            txtInstructorUserNameMA.Location = new Point(196, 162);
            txtInstructorUserNameMA.MaxLength = 32767;
            txtInstructorUserNameMA.Multiline = false;
            txtInstructorUserNameMA.Name = "txtInstructorUserNameMA";
            txtInstructorUserNameMA.ReadOnly = true;
            txtInstructorUserNameMA.Size = new Size(169, 38);
            txtInstructorUserNameMA.Style = MetroSet_UI.Enums.Style.Light;
            txtInstructorUserNameMA.StyleManager = null;
            txtInstructorUserNameMA.TabIndex = 8;
            txtInstructorUserNameMA.TextAlign = HorizontalAlignment.Left;
            txtInstructorUserNameMA.ThemeAuthor = "Narwin";
            txtInstructorUserNameMA.ThemeName = "MetroLite";
            txtInstructorUserNameMA.UseSystemPasswordChar = false;
            txtInstructorUserNameMA.WatermarkText = "";
            // 
            // txtInstructorDegreeMA
            // 
            txtInstructorDegreeMA.AutoCompleteCustomSource = null;
            txtInstructorDegreeMA.AutoCompleteMode = AutoCompleteMode.None;
            txtInstructorDegreeMA.AutoCompleteSource = AutoCompleteSource.None;
            txtInstructorDegreeMA.BorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorDegreeMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtInstructorDegreeMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorDegreeMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtInstructorDegreeMA.Enabled = false;
            txtInstructorDegreeMA.Font = new Font("Microsoft Sans Serif", 10F);
            txtInstructorDegreeMA.HoverColor = Color.FromArgb(102, 102, 102);
            txtInstructorDegreeMA.Image = null;
            txtInstructorDegreeMA.IsDerivedStyle = true;
            txtInstructorDegreeMA.Lines = null;
            txtInstructorDegreeMA.Location = new Point(588, 100);
            txtInstructorDegreeMA.MaxLength = 32767;
            txtInstructorDegreeMA.Multiline = false;
            txtInstructorDegreeMA.Name = "txtInstructorDegreeMA";
            txtInstructorDegreeMA.ReadOnly = true;
            txtInstructorDegreeMA.Size = new Size(169, 38);
            txtInstructorDegreeMA.Style = MetroSet_UI.Enums.Style.Light;
            txtInstructorDegreeMA.StyleManager = null;
            txtInstructorDegreeMA.TabIndex = 7;
            txtInstructorDegreeMA.TextAlign = HorizontalAlignment.Left;
            txtInstructorDegreeMA.ThemeAuthor = "Narwin";
            txtInstructorDegreeMA.ThemeName = "MetroLite";
            txtInstructorDegreeMA.UseSystemPasswordChar = false;
            txtInstructorDegreeMA.WatermarkText = "";
            // 
            // txtInstructorNameMA
            // 
            txtInstructorNameMA.AutoCompleteCustomSource = null;
            txtInstructorNameMA.AutoCompleteMode = AutoCompleteMode.None;
            txtInstructorNameMA.AutoCompleteSource = AutoCompleteSource.None;
            txtInstructorNameMA.BorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorNameMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtInstructorNameMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtInstructorNameMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtInstructorNameMA.Enabled = false;
            txtInstructorNameMA.Font = new Font("Microsoft Sans Serif", 10F);
            txtInstructorNameMA.HoverColor = Color.FromArgb(102, 102, 102);
            txtInstructorNameMA.Image = null;
            txtInstructorNameMA.IsDerivedStyle = true;
            txtInstructorNameMA.Lines = null;
            txtInstructorNameMA.Location = new Point(196, 92);
            txtInstructorNameMA.MaxLength = 32767;
            txtInstructorNameMA.Multiline = false;
            txtInstructorNameMA.Name = "txtInstructorNameMA";
            txtInstructorNameMA.ReadOnly = true;
            txtInstructorNameMA.Size = new Size(169, 38);
            txtInstructorNameMA.Style = MetroSet_UI.Enums.Style.Light;
            txtInstructorNameMA.StyleManager = null;
            txtInstructorNameMA.TabIndex = 6;
            txtInstructorNameMA.TextAlign = HorizontalAlignment.Left;
            txtInstructorNameMA.ThemeAuthor = "Narwin";
            txtInstructorNameMA.ThemeName = "MetroLite";
            txtInstructorNameMA.UseSystemPasswordChar = false;
            txtInstructorNameMA.WatermarkText = "";
            // 
            // lblInstructorDegreeMA
            // 
            lblInstructorDegreeMA.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructorDegreeMA.IsDerivedStyle = true;
            lblInstructorDegreeMA.Location = new Point(444, 109);
            lblInstructorDegreeMA.Name = "lblInstructorDegreeMA";
            lblInstructorDegreeMA.Size = new Size(125, 29);
            lblInstructorDegreeMA.Style = MetroSet_UI.Enums.Style.Light;
            lblInstructorDegreeMA.StyleManager = null;
            lblInstructorDegreeMA.TabIndex = 4;
            lblInstructorDegreeMA.Text = "Degree";
            lblInstructorDegreeMA.ThemeAuthor = "Narwin";
            lblInstructorDegreeMA.ThemeName = "MetroLite";
            // 
            // lblInstructorSalaryMA
            // 
            lblInstructorSalaryMA.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructorSalaryMA.IsDerivedStyle = true;
            lblInstructorSalaryMA.Location = new Point(444, 38);
            lblInstructorSalaryMA.Name = "lblInstructorSalaryMA";
            lblInstructorSalaryMA.Size = new Size(125, 29);
            lblInstructorSalaryMA.Style = MetroSet_UI.Enums.Style.Light;
            lblInstructorSalaryMA.StyleManager = null;
            lblInstructorSalaryMA.TabIndex = 3;
            lblInstructorSalaryMA.Text = "Salary";
            lblInstructorSalaryMA.ThemeAuthor = "Narwin";
            lblInstructorSalaryMA.ThemeName = "MetroLite";
            // 
            // lblInstructorUserNameMA
            // 
            lblInstructorUserNameMA.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstructorUserNameMA.IsDerivedStyle = true;
            lblInstructorUserNameMA.Location = new Point(52, 171);
            lblInstructorUserNameMA.Name = "lblInstructorUserNameMA";
            lblInstructorUserNameMA.Size = new Size(125, 29);
            lblInstructorUserNameMA.Style = MetroSet_UI.Enums.Style.Light;
            lblInstructorUserNameMA.StyleManager = null;
            lblInstructorUserNameMA.TabIndex = 2;
            lblInstructorUserNameMA.Text = "UserName";
            lblInstructorUserNameMA.ThemeAuthor = "Narwin";
            lblInstructorUserNameMA.ThemeName = "MetroLite";
            // 
            // lblInstrutorNameMA
            // 
            lblInstrutorNameMA.Font = new Font("Microsoft Sans Serif", 10F);
            lblInstrutorNameMA.IsDerivedStyle = true;
            lblInstrutorNameMA.Location = new Point(52, 101);
            lblInstrutorNameMA.Name = "lblInstrutorNameMA";
            lblInstrutorNameMA.Size = new Size(125, 29);
            lblInstrutorNameMA.Style = MetroSet_UI.Enums.Style.Light;
            lblInstrutorNameMA.StyleManager = null;
            lblInstrutorNameMA.TabIndex = 1;
            lblInstrutorNameMA.Text = "Name";
            lblInstrutorNameMA.ThemeAuthor = "Narwin";
            lblInstrutorNameMA.ThemeName = "MetroLite";
            // 
            // labInstIDMA
            // 
            labInstIDMA.Font = new Font("Microsoft Sans Serif", 10F);
            labInstIDMA.IsDerivedStyle = true;
            labInstIDMA.Location = new Point(52, 38);
            labInstIDMA.Name = "labInstIDMA";
            labInstIDMA.Size = new Size(125, 29);
            labInstIDMA.Style = MetroSet_UI.Enums.Style.Light;
            labInstIDMA.StyleManager = null;
            labInstIDMA.TabIndex = 0;
            labInstIDMA.Text = "ID";
            labInstIDMA.ThemeAuthor = "Narwin";
            labInstIDMA.ThemeName = "MetroLite";

            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblNumTFf);
            tabPage2.Controls.Add(lblCoursef);
            tabPage2.Controls.Add(comboboxCoursef);
            tabPage2.Controls.Add(lblNumMcqf);
            tabPage2.Controls.Add(btnGenerateExam);
            tabPage2.Controls.Add(numericTFf);
            tabPage2.Controls.Add(numericMcqf);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1230, 574);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Generate Exam";
            // 
            // lblNumTFf
            // 
            lblNumTFf.Font = new Font("Leelawadee UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTFf.IsDerivedStyle = true;
            lblNumTFf.Location = new Point(362, 211);
            lblNumTFf.Name = "lblNumTFf";
            lblNumTFf.Size = new Size(294, 51);
            lblNumTFf.Style = MetroSet_UI.Enums.Style.Light;
            lblNumTFf.StyleManager = null;
            lblNumTFf.TabIndex = 6;
            lblNumTFf.Text = "Number of TF questions";
            lblNumTFf.ThemeAuthor = "Narwin";
            lblNumTFf.ThemeName = "MetroLite";
            // 
            // lblCoursef
            // 
            lblCoursef.Font = new Font("Leelawadee UI", 14F);
            lblCoursef.IsDerivedStyle = true;
            lblCoursef.Location = new Point(362, 56);
            lblCoursef.Name = "lblCoursef";
            lblCoursef.Size = new Size(141, 43);
            lblCoursef.Style = MetroSet_UI.Enums.Style.Light;
            lblCoursef.StyleManager = null;
            lblCoursef.TabIndex = 5;
            lblCoursef.Text = "Course";
            lblCoursef.ThemeAuthor = "Narwin";
            lblCoursef.ThemeName = "MetroLite";
            // 
            // comboboxCoursef
            // 
            comboboxCoursef.AllowDrop = true;
            comboboxCoursef.ArrowColor = Color.FromArgb(150, 150, 150);
            comboboxCoursef.BackColor = Color.Transparent;
            comboboxCoursef.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboboxCoursef.BorderColor = Color.FromArgb(150, 150, 150);
            comboboxCoursef.CausesValidation = false;
            comboboxCoursef.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboboxCoursef.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboboxCoursef.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboboxCoursef.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxCoursef.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxCoursef.Font = new Font("Microsoft Sans Serif", 11F);
            comboboxCoursef.FormattingEnabled = true;
            comboboxCoursef.IsDerivedStyle = true;
            comboboxCoursef.ItemHeight = 20;
            comboboxCoursef.Location = new Point(699, 56);
            comboboxCoursef.Name = "comboboxCoursef";
            comboboxCoursef.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboboxCoursef.SelectedItemForeColor = Color.White;
            comboboxCoursef.Size = new Size(151, 26);
            comboboxCoursef.Style = MetroSet_UI.Enums.Style.Light;
            comboboxCoursef.StyleManager = null;
            comboboxCoursef.TabIndex = 4;
            comboboxCoursef.ThemeAuthor = "Narwin";
            comboboxCoursef.ThemeName = "MetroLite";
            // 
            // lblNumMcqf
            // 
            lblNumMcqf.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumMcqf.IsDerivedStyle = true;
            lblNumMcqf.Location = new Point(362, 135);
            lblNumMcqf.Name = "lblNumMcqf";
            lblNumMcqf.Size = new Size(294, 45);
            lblNumMcqf.Style = MetroSet_UI.Enums.Style.Light;
            lblNumMcqf.StyleManager = null;
            lblNumMcqf.TabIndex = 3;
            lblNumMcqf.Text = "Number of MCQ questions";
            lblNumMcqf.ThemeAuthor = "Narwin";
            lblNumMcqf.ThemeName = "MetroLite";
            // 
            // btnGenerateExam
            // 
            btnGenerateExam.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnGenerateExam.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnGenerateExam.DisabledForeColor = Color.Gray;
            btnGenerateExam.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateExam.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnGenerateExam.HoverColor = Color.FromArgb(95, 207, 255);
            btnGenerateExam.HoverTextColor = Color.White;
            btnGenerateExam.IsDerivedStyle = true;
            btnGenerateExam.Location = new Point(1018, 494);
            btnGenerateExam.Name = "btnGenerateExam";
            btnGenerateExam.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnGenerateExam.NormalColor = Color.FromArgb(65, 177, 225);
            btnGenerateExam.NormalTextColor = Color.White;
            btnGenerateExam.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnGenerateExam.PressColor = Color.FromArgb(35, 147, 195);
            btnGenerateExam.PressTextColor = Color.White;
            btnGenerateExam.Size = new Size(189, 58);
            btnGenerateExam.Style = MetroSet_UI.Enums.Style.Light;
            btnGenerateExam.StyleManager = null;
            btnGenerateExam.TabIndex = 2;
            btnGenerateExam.Text = "Generate Exam";
            btnGenerateExam.ThemeAuthor = "Narwin";
            btnGenerateExam.ThemeName = "MetroLite";
            btnGenerateExam.Click += btnGenerateExam_Click;
            // 
            // numericTFf
            // 
            numericTFf.Enabled = false;
            numericTFf.Location = new Point(700, 208);
            numericTFf.Name = "numericTFf";
            numericTFf.Size = new Size(150, 32);
            numericTFf.TabIndex = 1;
            // 
            // numericMcqf
            // 
            numericMcqf.Location = new Point(700, 135);
            numericMcqf.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericMcqf.Name = "numericMcqf";
            numericMcqf.Size = new Size(150, 32);
            numericMcqf.TabIndex = 0;
            numericMcqf.ValueChanged += numericMcq_ValueChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(gradesGridView);
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1230, 574);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Students Grades";
            // 
            // gradesGridView
            // 
            gradesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesGridView.Location = new Point(3, 3);
            gradesGridView.Name = "gradesGridView";
            gradesGridView.RowHeadersWidth = 51;
            gradesGridView.Size = new Size(1224, 568);
            gradesGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(Save);
            tabPage4.Controls.Add(dateTime1);
            tabPage4.Controls.Add(numericmf);
            tabPage4.Controls.Add(numeric2mf);
            tabPage4.Controls.Add(TextBox5mf);
            tabPage4.Controls.Add(TextBox4mf);
            tabPage4.Controls.Add(TextBox3mf);
            tabPage4.Controls.Add(metroSetLabel13);
            tabPage4.Controls.Add(Label12mf);
            tabPage4.Controls.Add(Label11mf);
            tabPage4.Controls.Add(label10mf);
            tabPage4.Controls.Add(Label9mf);
            tabPage4.Controls.Add(Label8mf);
            tabPage4.Controls.Add(Label7);
            tabPage4.Location = new Point(4, 42);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1230, 574);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Department Details";
            // 
            // Save
            // 
            Save.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            Save.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            Save.DisabledForeColor = Color.Gray;
            Save.Font = new Font("Microsoft Sans Serif", 10F);
            Save.HoverBorderColor = Color.FromArgb(95, 207, 255);
            Save.HoverColor = Color.FromArgb(95, 207, 255);
            Save.HoverTextColor = Color.White;
            Save.IsDerivedStyle = true;
            Save.Location = new Point(964, 514);
            Save.Name = "Save";
            Save.NormalBorderColor = Color.FromArgb(65, 177, 225);
            Save.NormalColor = Color.FromArgb(65, 177, 225);
            Save.NormalTextColor = Color.White;
            Save.PressBorderColor = Color.FromArgb(35, 147, 195);
            Save.PressColor = Color.FromArgb(35, 147, 195);
            Save.PressTextColor = Color.White;
            Save.Size = new Size(94, 29);
            Save.Style = MetroSet_UI.Enums.Style.Light;
            Save.StyleManager = null;
            Save.TabIndex = 3;
            Save.Text = "Save";
            Save.ThemeAuthor = "Narwin";
            Save.ThemeName = "MetroLite";
            Save.Click += Save_Click;
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(415, 397);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(250, 32);
            dateTime1.TabIndex = 18;
            // 
            // numericmf
            // 
            numericmf.Location = new Point(415, 94);
            numericmf.Name = "numericmf";
            numericmf.Size = new Size(150, 32);
            numericmf.TabIndex = 17;
            // 
            // numeric2mf
            // 
            numeric2mf.Location = new Point(415, 341);
            numeric2mf.Name = "numeric2mf";
            numeric2mf.Size = new Size(150, 32);
            numeric2mf.TabIndex = 16;
            // 
            // TextBox5mf
            // 
            TextBox5mf.AutoCompleteCustomSource = null;
            TextBox5mf.AutoCompleteMode = AutoCompleteMode.None;
            TextBox5mf.AutoCompleteSource = AutoCompleteSource.None;
            TextBox5mf.BorderColor = Color.FromArgb(155, 155, 155);
            TextBox5mf.DisabledBackColor = Color.FromArgb(204, 204, 204);
            TextBox5mf.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            TextBox5mf.DisabledForeColor = Color.FromArgb(136, 136, 136);
            TextBox5mf.Font = new Font("Microsoft Sans Serif", 10F);
            TextBox5mf.HoverColor = Color.FromArgb(102, 102, 102);
            TextBox5mf.Image = null;
            TextBox5mf.IsDerivedStyle = true;
            TextBox5mf.Lines = null;
            TextBox5mf.Location = new Point(415, 281);
            TextBox5mf.MaxLength = 32767;
            TextBox5mf.Multiline = false;
            TextBox5mf.Name = "TextBox5mf";
            TextBox5mf.ReadOnly = false;
            TextBox5mf.Size = new Size(169, 38);
            TextBox5mf.Style = MetroSet_UI.Enums.Style.Light;
            TextBox5mf.StyleManager = null;
            TextBox5mf.TabIndex = 14;
            TextBox5mf.TextAlign = HorizontalAlignment.Left;
            TextBox5mf.ThemeAuthor = "Narwin";
            TextBox5mf.ThemeName = "MetroLite";
            TextBox5mf.UseSystemPasswordChar = false;
            TextBox5mf.WatermarkText = "";
            // 
            // TextBox4mf
            // 
            TextBox4mf.AutoCompleteCustomSource = null;
            TextBox4mf.AutoCompleteMode = AutoCompleteMode.None;
            TextBox4mf.AutoCompleteSource = AutoCompleteSource.None;
            TextBox4mf.BorderColor = Color.FromArgb(155, 155, 155);
            TextBox4mf.DisabledBackColor = Color.FromArgb(204, 204, 204);
            TextBox4mf.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            TextBox4mf.DisabledForeColor = Color.FromArgb(136, 136, 136);
            TextBox4mf.Font = new Font("Microsoft Sans Serif", 10F);
            TextBox4mf.HoverColor = Color.FromArgb(102, 102, 102);
            TextBox4mf.Image = null;
            TextBox4mf.IsDerivedStyle = true;
            TextBox4mf.Lines = null;
            TextBox4mf.Location = new Point(415, 151);
            TextBox4mf.MaxLength = 32767;
            TextBox4mf.Multiline = false;
            TextBox4mf.Name = "TextBox4mf";
            TextBox4mf.ReadOnly = false;
            TextBox4mf.Size = new Size(169, 38);
            TextBox4mf.Style = MetroSet_UI.Enums.Style.Light;
            TextBox4mf.StyleManager = null;
            TextBox4mf.TabIndex = 13;
            TextBox4mf.TextAlign = HorizontalAlignment.Left;
            TextBox4mf.ThemeAuthor = "Narwin";
            TextBox4mf.ThemeName = "MetroLite";
            TextBox4mf.UseSystemPasswordChar = false;
            TextBox4mf.WatermarkText = "";
            // 
            // TextBox3mf
            // 
            TextBox3mf.AutoCompleteCustomSource = null;
            TextBox3mf.AutoCompleteMode = AutoCompleteMode.None;
            TextBox3mf.AutoCompleteSource = AutoCompleteSource.None;
            TextBox3mf.BorderColor = Color.FromArgb(155, 155, 155);
            TextBox3mf.DisabledBackColor = Color.FromArgb(204, 204, 204);
            TextBox3mf.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            TextBox3mf.DisabledForeColor = Color.FromArgb(136, 136, 136);
            TextBox3mf.Font = new Font("Microsoft Sans Serif", 10F);
            TextBox3mf.HoverColor = Color.FromArgb(102, 102, 102);
            TextBox3mf.Image = null;
            TextBox3mf.IsDerivedStyle = true;
            TextBox3mf.Lines = null;
            TextBox3mf.Location = new Point(415, 215);
            TextBox3mf.MaxLength = 32767;
            TextBox3mf.Multiline = false;
            TextBox3mf.Name = "TextBox3mf";
            TextBox3mf.ReadOnly = false;
            TextBox3mf.Size = new Size(169, 38);
            TextBox3mf.Style = MetroSet_UI.Enums.Style.Light;
            TextBox3mf.StyleManager = null;
            TextBox3mf.TabIndex = 12;
            TextBox3mf.TextAlign = HorizontalAlignment.Left;
            TextBox3mf.ThemeAuthor = "Narwin";
            TextBox3mf.ThemeName = "MetroLite";
            TextBox3mf.UseSystemPasswordChar = false;
            TextBox3mf.WatermarkText = "";
            // 
            // metroSetLabel13
            // 
            metroSetLabel13.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel13.IsDerivedStyle = true;
            metroSetLabel13.Location = new Point(19, 400);
            metroSetLabel13.Name = "metroSetLabel13";
            metroSetLabel13.Size = new Size(125, 29);
            metroSetLabel13.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel13.StyleManager = null;
            metroSetLabel13.TabIndex = 9;
            metroSetLabel13.Text = "manager Hire Date";
            metroSetLabel13.ThemeAuthor = "Narwin";
            metroSetLabel13.ThemeName = "MetroLite";
            // 
            // Label12mf
            // 
            Label12mf.Font = new Font("Microsoft Sans Serif", 10F);
            Label12mf.IsDerivedStyle = true;
            Label12mf.Location = new Point(19, 341);
            Label12mf.Name = "Label12mf";
            Label12mf.Size = new Size(125, 29);
            Label12mf.Style = MetroSet_UI.Enums.Style.Light;
            Label12mf.StyleManager = null;
            Label12mf.TabIndex = 8;
            Label12mf.Text = "Manager ID";
            Label12mf.ThemeAuthor = "Narwin";
            Label12mf.ThemeName = "MetroLite";
            // 
            // Label11mf
            // 
            Label11mf.Font = new Font("Microsoft Sans Serif", 10F);
            Label11mf.IsDerivedStyle = true;
            Label11mf.Location = new Point(19, 281);
            Label11mf.Name = "Label11mf";
            Label11mf.Size = new Size(169, 29);
            Label11mf.Style = MetroSet_UI.Enums.Style.Light;
            Label11mf.StyleManager = null;
            Label11mf.TabIndex = 7;
            Label11mf.Text = "Department Location";
            Label11mf.ThemeAuthor = "Narwin";
            Label11mf.ThemeName = "MetroLite";
            // 
            // label10mf
            // 
            label10mf.Font = new Font("Microsoft Sans Serif", 10F);
            label10mf.IsDerivedStyle = true;
            label10mf.Location = new Point(19, 215);
            label10mf.Name = "label10mf";
            label10mf.Size = new Size(192, 29);
            label10mf.Style = MetroSet_UI.Enums.Style.Light;
            label10mf.StyleManager = null;
            label10mf.TabIndex = 6;
            label10mf.Text = "Department Description";
            label10mf.ThemeAuthor = "Narwin";
            label10mf.ThemeName = "MetroLite";
            // 
            // Label9mf
            // 
            Label9mf.Font = new Font("Microsoft Sans Serif", 10F);
            Label9mf.IsDerivedStyle = true;
            Label9mf.Location = new Point(19, 151);
            Label9mf.Name = "Label9mf";
            Label9mf.Size = new Size(160, 29);
            Label9mf.Style = MetroSet_UI.Enums.Style.Light;
            Label9mf.StyleManager = null;
            Label9mf.TabIndex = 5;
            Label9mf.Text = "Department Name";
            Label9mf.ThemeAuthor = "Narwin";
            Label9mf.ThemeName = "MetroLite";
            // 
            // Label8mf
            // 
            Label8mf.Font = new Font("Microsoft Sans Serif", 10F);
            Label8mf.IsDerivedStyle = true;
            Label8mf.Location = new Point(19, 94);
            Label8mf.Name = "Label8mf";
            Label8mf.Size = new Size(125, 29);
            Label8mf.Style = MetroSet_UI.Enums.Style.Light;
            Label8mf.StyleManager = null;
            Label8mf.TabIndex = 4;
            Label8mf.Text = "Department ID";
            Label8mf.ThemeAuthor = "Narwin";
            Label8mf.ThemeName = "MetroLite";
            // 
            // Label7
            // 
            Label7.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.IsDerivedStyle = true;
            Label7.Location = new Point(45, 10);
            Label7.Name = "Label7";
            Label7.Size = new Size(352, 61);
            Label7.Style = MetroSet_UI.Enums.Style.Light;
            Label7.StyleManager = null;
            Label7.TabIndex = 3;
            Label7.Text = "Department Details:";
            Label7.ThemeAuthor = "Narwin";
            Label7.ThemeName = "MetroLite";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 42);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1230, 574);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Questions Bank";
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(15, 22);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(317, 29);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 1;
            metroSetLabel1.Text = "Instructors Control Panel";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(1153, 6);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 2;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 708);
            Controls.Add(metroSetControlBox1);
            Controls.Add(metroSetLabel1);
            Controls.Add(metroSetTabControl1);
            Name = "InstructorForm";
            SmallLineColor1 = Color.FromArgb(0, 0, 0, 1);
            SmallLineColor2 = Color.FromArgb(0, 0, 0, 1);
            Load += InstructorForm_Load;
            metroSetTabControl1.ResumeLayout(false);
            tabPage0.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericTFf).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMcqf).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradesGridView).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericmf).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric2mf).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private TabPage tabPage0;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView gradesGridView;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;

        private MetroSet_UI.Controls.MetroSetLabel labInstIDMA;
        private MetroSet_UI.Controls.MetroSetTextBox txtInstructorDegreeMA;
        private MetroSet_UI.Controls.MetroSetTextBox txtInstructorNameMA;
        private MetroSet_UI.Controls.MetroSetLabel lblInstructorDegreeMA;
        private MetroSet_UI.Controls.MetroSetLabel lblInstructorSalaryMA;
        private MetroSet_UI.Controls.MetroSetLabel lblInstructorUserNameMA;
        private MetroSet_UI.Controls.MetroSetLabel lblInstrutorNameMA;
        private MetroSet_UI.Controls.MetroSetTextBox txtInstructorUserNameMA;
        private MetroSet_UI.Controls.MetroSetLabel lblInstructorDeparmentMA;
        private MetroSet_UI.Controls.MetroSetTextBox txtInstructorDepartmentMA;
        private MetroSet_UI.Controls.MetroSetTextBox numInstructorSalaryMA;
        private MetroSet_UI.Controls.MetroSetTextBox txtInstructorIDMA;


    }
}