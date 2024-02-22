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
            tabPage5 = new TabPage();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericTFf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMcqf).BeginInit();
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
            // 
            // tabPage0
            // 
            tabPage0.Location = new Point(4, 42);
            tabPage0.Name = "tabPage0";
            tabPage0.Size = new Size(1230, 574);
            tabPage0.TabIndex = 0;
            tabPage0.Text = "Profile";
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
            lblNumTFf.Font = new Font("Microsoft Sans Serif", 10F);
            lblNumTFf.IsDerivedStyle = true;
            lblNumTFf.Location = new Point(19, 198);
            lblNumTFf.Name = "lblNumTFf";
            lblNumTFf.Size = new Size(214, 29);
            lblNumTFf.Style = MetroSet_UI.Enums.Style.Light;
            lblNumTFf.StyleManager = null;
            lblNumTFf.TabIndex = 6;
            lblNumTFf.Text = "Number of TF questions";
            lblNumTFf.ThemeAuthor = "Narwin";
            lblNumTFf.ThemeName = "MetroLite";
            // 
            // lblCoursef
            // 
            lblCoursef.Font = new Font("Microsoft Sans Serif", 10F);
            lblCoursef.IsDerivedStyle = true;
            lblCoursef.Location = new Point(19, 43);
            lblCoursef.Name = "lblCoursef";
            lblCoursef.Size = new Size(85, 29);
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
            comboboxCoursef.Location = new Point(356, 43);
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
            lblNumMcqf.Font = new Font("Microsoft Sans Serif", 10F);
            lblNumMcqf.IsDerivedStyle = true;
            lblNumMcqf.Location = new Point(19, 122);
            lblNumMcqf.Name = "lblNumMcqf";
            lblNumMcqf.Size = new Size(214, 29);
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
            btnGenerateExam.Font = new Font("Microsoft Sans Serif", 10F);
            btnGenerateExam.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnGenerateExam.HoverColor = Color.FromArgb(95, 207, 255);
            btnGenerateExam.HoverTextColor = Color.White;
            btnGenerateExam.IsDerivedStyle = true;
            btnGenerateExam.Location = new Point(805, 507);
            btnGenerateExam.Name = "btnGenerateExam";
            btnGenerateExam.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnGenerateExam.NormalColor = Color.FromArgb(65, 177, 225);
            btnGenerateExam.NormalTextColor = Color.White;
            btnGenerateExam.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnGenerateExam.PressColor = Color.FromArgb(35, 147, 195);
            btnGenerateExam.PressTextColor = Color.White;
            btnGenerateExam.Size = new Size(141, 29);
            btnGenerateExam.Style = MetroSet_UI.Enums.Style.Light;
            btnGenerateExam.StyleManager = null;
            btnGenerateExam.TabIndex = 2;
            btnGenerateExam.Text = "Generate Exam";
            btnGenerateExam.ThemeAuthor = "Narwin";
            btnGenerateExam.ThemeName = "MetroLite";
            // 
            // numericTFf
            // 
            numericTFf.Enabled = false;
            numericTFf.Location = new Point(357, 195);
            numericTFf.Name = "numericTFf";
            numericTFf.Size = new Size(150, 32);
            numericTFf.TabIndex = 1;
            // 
            // numericMcqf
            // 
            numericMcqf.Location = new Point(357, 122);
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
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericTFf).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMcqf).EndInit();
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
        private NumericUpDown numericTFf;
        private NumericUpDown numericMcqf;
        private MetroSet_UI.Controls.MetroSetLabel lblNumTFf;
        private MetroSet_UI.Controls.MetroSetLabel lblCoursef;
        private MetroSet_UI.Controls.MetroSetComboBox comboboxCoursef;
        private MetroSet_UI.Controls.MetroSetLabel lblNumMcqf;
        private MetroSet_UI.Controls.MetroSetButton btnGenerateExam;
    }
}