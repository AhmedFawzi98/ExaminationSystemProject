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
            tabPage3 = new TabPage();
            gradesGridView = new DataGridView();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetNumeric1 = new MetroSet_UI.Controls.MetroSetNumeric();
            metroSetTextBox1 = new MetroSet_UI.Controls.MetroSetTextBox();
            metroSetTextBox2 = new MetroSet_UI.Controls.MetroSetTextBox();
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
            tabPage0.Controls.Add(metroSetTextBox2);
            tabPage0.Controls.Add(metroSetTextBox1);
            tabPage0.Controls.Add(metroSetNumeric1);
            tabPage0.Controls.Add(metroSetLabel6);
            tabPage0.Controls.Add(metroSetLabel5);
            tabPage0.Controls.Add(metroSetLabel4);
            tabPage0.Controls.Add(metroSetLabel3);
            tabPage0.Controls.Add(metroSetLabel2);
            tabPage0.Location = new Point(4, 42);
            tabPage0.Name = "tabPage0";
            tabPage0.Size = new Size(1230, 574);
            tabPage0.TabIndex = 0;
            tabPage0.Text = "Profile";
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
            // metroSetLabel2
            // 
            metroSetLabel2.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel2.IsDerivedStyle = true;
            metroSetLabel2.Location = new Point(17, 37);
            metroSetLabel2.Name = "metroSetLabel2";
            metroSetLabel2.Size = new Size(125, 29);
            metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel2.StyleManager = null;
            metroSetLabel2.TabIndex = 0;
            metroSetLabel2.Text = "metroSetLabel2";
            metroSetLabel2.ThemeAuthor = "Narwin";
            metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            metroSetLabel3.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel3.IsDerivedStyle = true;
            metroSetLabel3.Location = new Point(17, 110);
            metroSetLabel3.Name = "metroSetLabel3";
            metroSetLabel3.Size = new Size(125, 29);
            metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel3.StyleManager = null;
            metroSetLabel3.TabIndex = 1;
            metroSetLabel3.Text = "metroSetLabel3";
            metroSetLabel3.ThemeAuthor = "Narwin";
            metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            metroSetLabel4.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel4.IsDerivedStyle = true;
            metroSetLabel4.Location = new Point(17, 186);
            metroSetLabel4.Name = "metroSetLabel4";
            metroSetLabel4.Size = new Size(125, 29);
            metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel4.StyleManager = null;
            metroSetLabel4.TabIndex = 2;
            metroSetLabel4.Text = "metroSetLabel4";
            metroSetLabel4.ThemeAuthor = "Narwin";
            metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            metroSetLabel5.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel5.IsDerivedStyle = true;
            metroSetLabel5.Location = new Point(17, 251);
            metroSetLabel5.Name = "metroSetLabel5";
            metroSetLabel5.Size = new Size(125, 29);
            metroSetLabel5.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel5.StyleManager = null;
            metroSetLabel5.TabIndex = 3;
            metroSetLabel5.Text = "metroSetLabel5";
            metroSetLabel5.ThemeAuthor = "Narwin";
            metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            metroSetLabel6.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetLabel6.IsDerivedStyle = true;
            metroSetLabel6.Location = new Point(17, 322);
            metroSetLabel6.Name = "metroSetLabel6";
            metroSetLabel6.Size = new Size(125, 29);
            metroSetLabel6.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel6.StyleManager = null;
            metroSetLabel6.TabIndex = 4;
            metroSetLabel6.Text = "metroSetLabel6";
            metroSetLabel6.ThemeAuthor = "Narwin";
            metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetNumeric1
            // 
            metroSetNumeric1.BackColor = Color.Transparent;
            metroSetNumeric1.BackgroundColor = Color.Empty;
            metroSetNumeric1.BorderColor = Color.FromArgb(150, 150, 150);
            metroSetNumeric1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            metroSetNumeric1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            metroSetNumeric1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            metroSetNumeric1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetNumeric1.IsDerivedStyle = true;
            metroSetNumeric1.Location = new Point(161, 37);
            metroSetNumeric1.Maximum = 100;
            metroSetNumeric1.Minimum = 0;
            metroSetNumeric1.Name = "metroSetNumeric1";
            metroSetNumeric1.Size = new Size(169, 26);
            metroSetNumeric1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetNumeric1.StyleManager = null;
            metroSetNumeric1.SymbolsColor = Color.FromArgb(128, 128, 128);
            metroSetNumeric1.TabIndex = 5;
            metroSetNumeric1.Text = "metroSetNumeric1";
            metroSetNumeric1.ThemeAuthor = "Narwin";
            metroSetNumeric1.ThemeName = "MetroLite";
            metroSetNumeric1.Value = 0;
            // 
            // metroSetTextBox1
            // 
            metroSetTextBox1.AutoCompleteCustomSource = null;
            metroSetTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            metroSetTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            metroSetTextBox1.BorderColor = Color.FromArgb(155, 155, 155);
            metroSetTextBox1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            metroSetTextBox1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            metroSetTextBox1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            metroSetTextBox1.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetTextBox1.HoverColor = Color.FromArgb(102, 102, 102);
            metroSetTextBox1.Image = null;
            metroSetTextBox1.IsDerivedStyle = true;
            metroSetTextBox1.Lines = null;
            metroSetTextBox1.Location = new Point(161, 101);
            metroSetTextBox1.MaxLength = 32767;
            metroSetTextBox1.Multiline = false;
            metroSetTextBox1.Name = "metroSetTextBox1";
            metroSetTextBox1.ReadOnly = false;
            metroSetTextBox1.Size = new Size(169, 38);
            metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetTextBox1.StyleManager = null;
            metroSetTextBox1.TabIndex = 6;
            metroSetTextBox1.Text = "metroSetTextBox1";
            metroSetTextBox1.TextAlign = HorizontalAlignment.Left;
            metroSetTextBox1.ThemeAuthor = "Narwin";
            metroSetTextBox1.ThemeName = "MetroLite";
            metroSetTextBox1.UseSystemPasswordChar = false;
            metroSetTextBox1.WatermarkText = "";
            // 
            // metroSetTextBox2
            // 
            metroSetTextBox2.AutoCompleteCustomSource = null;
            metroSetTextBox2.AutoCompleteMode = AutoCompleteMode.None;
            metroSetTextBox2.AutoCompleteSource = AutoCompleteSource.None;
            metroSetTextBox2.BorderColor = Color.FromArgb(155, 155, 155);
            metroSetTextBox2.DisabledBackColor = Color.FromArgb(204, 204, 204);
            metroSetTextBox2.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            metroSetTextBox2.DisabledForeColor = Color.FromArgb(136, 136, 136);
            metroSetTextBox2.Font = new Font("Microsoft Sans Serif", 10F);
            metroSetTextBox2.HoverColor = Color.FromArgb(102, 102, 102);
            metroSetTextBox2.Image = null;
            metroSetTextBox2.IsDerivedStyle = true;
            metroSetTextBox2.Lines = null;
            metroSetTextBox2.Location = new Point(161, 242);
            metroSetTextBox2.MaxLength = 32767;
            metroSetTextBox2.Multiline = false;
            metroSetTextBox2.Name = "metroSetTextBox2";
            metroSetTextBox2.ReadOnly = false;
            metroSetTextBox2.Size = new Size(169, 38);
            metroSetTextBox2.Style = MetroSet_UI.Enums.Style.Light;
            metroSetTextBox2.StyleManager = null;
            metroSetTextBox2.TabIndex = 7;
            metroSetTextBox2.Text = "metroSetTextBox2";
            metroSetTextBox2.TextAlign = HorizontalAlignment.Left;
            metroSetTextBox2.ThemeAuthor = "Narwin";
            metroSetTextBox2.ThemeName = "MetroLite";
            metroSetTextBox2.UseSystemPasswordChar = false;
            metroSetTextBox2.WatermarkText = "";
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
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox2;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private MetroSet_UI.Controls.MetroSetNumeric metroSetNumeric1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
    }
}