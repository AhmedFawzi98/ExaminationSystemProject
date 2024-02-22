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
            tabPage3 = new TabPage();
            gradesGridView = new DataGridView();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetTabControl1.SuspendLayout();
            tabPage0.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradesGridView).BeginInit();
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
            metroSetTabControl1.SelectedIndex = 0;
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
            // 
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
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1230, 574);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Generate Exam";
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
            tabPage4.Location = new Point(4, 42);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1230, 574);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Department Details";
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
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gradesGridView).EndInit();
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