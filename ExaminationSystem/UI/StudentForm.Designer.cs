
using System.Windows.Forms;

namespace ExaminationSystem.UI
{
    partial class StudentForm
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
            StudentTabControlm = new MetroSet_UI.Controls.MetroSetTabControl();
            tabPage1 = new TabPage();
            SaveBtnm = new MetroSet_UI.Controls.MetroSetButton();
            ZipTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            StTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            CityTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            DeptTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            UsernameTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            EmailTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            AgeTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            PhoneTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            NameTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            IDTxtBoxm = new MetroSet_UI.Controls.MetroSetTextBox();
            Usernamem = new MetroSet_UI.Controls.MetroSetLabel();
            StEmailm = new MetroSet_UI.Controls.MetroSetLabel();
            StZipCodem = new MetroSet_UI.Controls.MetroSetLabel();
            Deptm = new MetroSet_UI.Controls.MetroSetLabel();
            StCitym = new MetroSet_UI.Controls.MetroSetLabel();
            StStreetm = new MetroSet_UI.Controls.MetroSetLabel();
            StAgem = new MetroSet_UI.Controls.MetroSetLabel();
            StPhonem = new MetroSet_UI.Controls.MetroSetLabel();
            StNamem = new MetroSet_UI.Controls.MetroSetLabel();
            StuIDm = new MetroSet_UI.Controls.MetroSetLabel();
            tabPage2 = new TabPage();
            btnTakeExamMA = new MetroSet_UI.Controls.MetroSetButton();
            comboCrsNameMA = new MetroSet_UI.Controls.MetroSetComboBox();
            lblCourseNameMA = new MetroSet_UI.Controls.MetroSetLabel();
            tabPage3 = new TabPage();
            studentGradesGridViewm = new DataGridView();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            StudentTabControlm.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentGradesGridViewm).BeginInit();
            SuspendLayout();
            // 
            // StudentTabControlm
            // 
            StudentTabControlm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentTabControlm.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            StudentTabControlm.AnimateTime = 200;
            StudentTabControlm.BackgroundColor = Color.White;
            StudentTabControlm.Controls.Add(tabPage1);
            StudentTabControlm.Controls.Add(tabPage2);
            StudentTabControlm.Controls.Add(tabPage3);
            StudentTabControlm.DrawMode = TabDrawMode.OwnerDrawFixed;
            StudentTabControlm.IsDerivedStyle = false;
            StudentTabControlm.ItemSize = new Size(100, 38);
            StudentTabControlm.Location = new Point(15, 38);
            StudentTabControlm.Name = "StudentTabControlm";
            StudentTabControlm.SelectedIndex = 1;
            StudentTabControlm.SelectedTextColor = Color.Black;
            StudentTabControlm.Size = new Size(970, 552);
            StudentTabControlm.SizeMode = TabSizeMode.Fixed;
            StudentTabControlm.Speed = 100;
            StudentTabControlm.Style = MetroSet_UI.Enums.Style.Light;
            StudentTabControlm.StyleManager = null;
            StudentTabControlm.TabIndex = 0;
            StudentTabControlm.ThemeAuthor = "Narwin";
            StudentTabControlm.ThemeName = "MetroLite";
            StudentTabControlm.UnselectedTextColor = Color.Black;
            StudentTabControlm.UseAnimation = false;
            StudentTabControlm.SelectedIndexChanged += StudentTabControlm_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SaveBtnm);
            tabPage1.Controls.Add(ZipTxtBoxm);
            tabPage1.Controls.Add(StTxtBoxm);
            tabPage1.Controls.Add(CityTxtBoxm);
            tabPage1.Controls.Add(DeptTxtBoxm);
            tabPage1.Controls.Add(UsernameTxtBoxm);
            tabPage1.Controls.Add(EmailTxtBoxm);
            tabPage1.Controls.Add(AgeTxtBoxm);
            tabPage1.Controls.Add(PhoneTxtBoxm);
            tabPage1.Controls.Add(NameTxtBoxm);
            tabPage1.Controls.Add(IDTxtBoxm);
            tabPage1.Controls.Add(Usernamem);
            tabPage1.Controls.Add(StEmailm);
            tabPage1.Controls.Add(StZipCodem);
            tabPage1.Controls.Add(Deptm);
            tabPage1.Controls.Add(StCitym);
            tabPage1.Controls.Add(StStreetm);
            tabPage1.Controls.Add(StAgem);
            tabPage1.Controls.Add(StPhonem);
            tabPage1.Controls.Add(StNamem);
            tabPage1.Controls.Add(StuIDm);
            tabPage1.Location = new Point(4, 42);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(962, 506);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Profile";
            // 
            // SaveBtnm
            // 
            SaveBtnm.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            SaveBtnm.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            SaveBtnm.DisabledForeColor = Color.Gray;
            SaveBtnm.Font = new Font("Microsoft Sans Serif", 10F);
            SaveBtnm.HoverBorderColor = Color.DarkGray;
            SaveBtnm.HoverColor = Color.Black;
            SaveBtnm.HoverTextColor = Color.White;
            SaveBtnm.IsDerivedStyle = false;
            SaveBtnm.Location = new Point(830, 445);
            SaveBtnm.Margin = new Padding(10, 12, 10, 12);
            SaveBtnm.Name = "SaveBtnm";
            SaveBtnm.NormalBorderColor = Color.Black;
            SaveBtnm.NormalColor = Color.Transparent;
            SaveBtnm.NormalTextColor = Color.Black;
            SaveBtnm.PressBorderColor = Color.Black;
            SaveBtnm.PressColor = Color.Black;
            SaveBtnm.PressTextColor = Color.White;
            SaveBtnm.Size = new Size(122, 49);
            SaveBtnm.Style = MetroSet_UI.Enums.Style.Light;
            SaveBtnm.StyleManager = null;
            SaveBtnm.TabIndex = 21;
            SaveBtnm.Text = "Save";
            SaveBtnm.ThemeAuthor = "Narwin";
            SaveBtnm.ThemeName = "MetroLight";
            SaveBtnm.Click += SaveBtnm_Click;
            // 
            // ZipTxtBoxm
            // 
            ZipTxtBoxm.AutoCompleteCustomSource = null;
            ZipTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            ZipTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            ZipTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            ZipTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            ZipTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            ZipTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            ZipTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            ZipTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            ZipTxtBoxm.Image = null;
            ZipTxtBoxm.IsDerivedStyle = true;
            ZipTxtBoxm.Lines = null;
            ZipTxtBoxm.Location = new Point(641, 187);
            ZipTxtBoxm.MaxLength = 32767;
            ZipTxtBoxm.Multiline = false;
            ZipTxtBoxm.Name = "ZipTxtBoxm";
            ZipTxtBoxm.ReadOnly = false;
            ZipTxtBoxm.Size = new Size(135, 34);
            ZipTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            ZipTxtBoxm.StyleManager = null;
            ZipTxtBoxm.TabIndex = 20;
            ZipTxtBoxm.TextAlign = HorizontalAlignment.Center;
            ZipTxtBoxm.ThemeAuthor = "Narwin";
            ZipTxtBoxm.ThemeName = "MetroLight";
            ZipTxtBoxm.UseSystemPasswordChar = false;
            ZipTxtBoxm.WatermarkText = "";
            // 
            // StTxtBoxm
            // 
            StTxtBoxm.AutoCompleteCustomSource = null;
            StTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            StTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            StTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            StTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            StTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            StTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            StTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            StTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            StTxtBoxm.Image = null;
            StTxtBoxm.IsDerivedStyle = true;
            StTxtBoxm.Lines = null;
            StTxtBoxm.Location = new Point(641, 107);
            StTxtBoxm.MaxLength = 32767;
            StTxtBoxm.Multiline = false;
            StTxtBoxm.Name = "StTxtBoxm";
            StTxtBoxm.ReadOnly = false;
            StTxtBoxm.Size = new Size(135, 34);
            StTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            StTxtBoxm.StyleManager = null;
            StTxtBoxm.TabIndex = 19;
            StTxtBoxm.TextAlign = HorizontalAlignment.Center;
            StTxtBoxm.ThemeAuthor = "Narwin";
            StTxtBoxm.ThemeName = "MetroLight";
            StTxtBoxm.UseSystemPasswordChar = false;
            StTxtBoxm.WatermarkText = "";
            // 
            // CityTxtBoxm
            // 
            CityTxtBoxm.AutoCompleteCustomSource = null;
            CityTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            CityTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            CityTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            CityTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            CityTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            CityTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            CityTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            CityTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            CityTxtBoxm.Image = null;
            CityTxtBoxm.IsDerivedStyle = true;
            CityTxtBoxm.Lines = null;
            CityTxtBoxm.Location = new Point(641, 26);
            CityTxtBoxm.MaxLength = 32767;
            CityTxtBoxm.Multiline = false;
            CityTxtBoxm.Name = "CityTxtBoxm";
            CityTxtBoxm.ReadOnly = false;
            CityTxtBoxm.Size = new Size(135, 34);
            CityTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            CityTxtBoxm.StyleManager = null;
            CityTxtBoxm.TabIndex = 18;
            CityTxtBoxm.TextAlign = HorizontalAlignment.Center;
            CityTxtBoxm.ThemeAuthor = "Narwin";
            CityTxtBoxm.ThemeName = "MetroLight";
            CityTxtBoxm.UseSystemPasswordChar = false;
            CityTxtBoxm.WatermarkText = "";
            // 
            // DeptTxtBoxm
            // 
            DeptTxtBoxm.AutoCompleteCustomSource = null;
            DeptTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            DeptTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            DeptTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            DeptTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            DeptTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            DeptTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            DeptTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            DeptTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            DeptTxtBoxm.Image = null;
            DeptTxtBoxm.IsDerivedStyle = true;
            DeptTxtBoxm.Lines = null;
            DeptTxtBoxm.Location = new Point(641, 347);
            DeptTxtBoxm.MaxLength = 32767;
            DeptTxtBoxm.Multiline = false;
            DeptTxtBoxm.Name = "DeptTxtBoxm";
            DeptTxtBoxm.ReadOnly = true;
            DeptTxtBoxm.Size = new Size(135, 34);
            DeptTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            DeptTxtBoxm.StyleManager = null;
            DeptTxtBoxm.TabIndex = 17;
            DeptTxtBoxm.TextAlign = HorizontalAlignment.Center;
            DeptTxtBoxm.ThemeAuthor = "Narwin";
            DeptTxtBoxm.ThemeName = "MetroLight";
            DeptTxtBoxm.UseSystemPasswordChar = false;
            DeptTxtBoxm.WatermarkText = "";
            // 
            // UsernameTxtBoxm
            // 
            UsernameTxtBoxm.AutoCompleteCustomSource = null;
            UsernameTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            UsernameTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            UsernameTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            UsernameTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            UsernameTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            UsernameTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            UsernameTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            UsernameTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            UsernameTxtBoxm.Image = null;
            UsernameTxtBoxm.IsDerivedStyle = true;
            UsernameTxtBoxm.Lines = null;
            UsernameTxtBoxm.Location = new Point(198, 347);
            UsernameTxtBoxm.MaxLength = 32767;
            UsernameTxtBoxm.Multiline = false;
            UsernameTxtBoxm.Name = "UsernameTxtBoxm";
            UsernameTxtBoxm.ReadOnly = true;
            UsernameTxtBoxm.Size = new Size(208, 34);
            UsernameTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            UsernameTxtBoxm.StyleManager = null;
            UsernameTxtBoxm.TabIndex = 16;
            UsernameTxtBoxm.TextAlign = HorizontalAlignment.Center;
            UsernameTxtBoxm.ThemeAuthor = "Narwin";
            UsernameTxtBoxm.ThemeName = "MetroLight";
            UsernameTxtBoxm.UseSystemPasswordChar = false;
            UsernameTxtBoxm.WatermarkText = "";
            // 
            // EmailTxtBoxm
            // 
            EmailTxtBoxm.AutoCompleteCustomSource = null;
            EmailTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            EmailTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            EmailTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            EmailTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            EmailTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            EmailTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            EmailTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            EmailTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            EmailTxtBoxm.Image = null;
            EmailTxtBoxm.IsDerivedStyle = true;
            EmailTxtBoxm.Lines = null;
            EmailTxtBoxm.Location = new Point(198, 267);
            EmailTxtBoxm.MaxLength = 32767;
            EmailTxtBoxm.Multiline = false;
            EmailTxtBoxm.Name = "EmailTxtBoxm";
            EmailTxtBoxm.ReadOnly = false;
            EmailTxtBoxm.Size = new Size(208, 34);
            EmailTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            EmailTxtBoxm.StyleManager = null;
            EmailTxtBoxm.TabIndex = 15;
            EmailTxtBoxm.TextAlign = HorizontalAlignment.Center;
            EmailTxtBoxm.ThemeAuthor = "Narwin";
            EmailTxtBoxm.ThemeName = "MetroLight";
            EmailTxtBoxm.UseSystemPasswordChar = false;
            EmailTxtBoxm.WatermarkText = "";
            // 
            // AgeTxtBoxm
            // 
            AgeTxtBoxm.AutoCompleteCustomSource = null;
            AgeTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            AgeTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            AgeTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            AgeTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            AgeTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            AgeTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            AgeTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            AgeTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            AgeTxtBoxm.Image = null;
            AgeTxtBoxm.IsDerivedStyle = true;
            AgeTxtBoxm.Lines = null;
            AgeTxtBoxm.Location = new Point(641, 267);
            AgeTxtBoxm.MaxLength = 32767;
            AgeTxtBoxm.Multiline = false;
            AgeTxtBoxm.Name = "AgeTxtBoxm";
            AgeTxtBoxm.ReadOnly = false;
            AgeTxtBoxm.Size = new Size(135, 34);
            AgeTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            AgeTxtBoxm.StyleManager = null;
            AgeTxtBoxm.TabIndex = 14;
            AgeTxtBoxm.TextAlign = HorizontalAlignment.Center;
            AgeTxtBoxm.ThemeAuthor = "Narwin";
            AgeTxtBoxm.ThemeName = "MetroLight";
            AgeTxtBoxm.UseSystemPasswordChar = false;
            AgeTxtBoxm.WatermarkText = "";
            // 
            // PhoneTxtBoxm
            // 
            PhoneTxtBoxm.AutoCompleteCustomSource = null;
            PhoneTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            PhoneTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            PhoneTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            PhoneTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            PhoneTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            PhoneTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            PhoneTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            PhoneTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            PhoneTxtBoxm.Image = null;
            PhoneTxtBoxm.IsDerivedStyle = true;
            PhoneTxtBoxm.Lines = null;
            PhoneTxtBoxm.Location = new Point(198, 187);
            PhoneTxtBoxm.MaxLength = 32767;
            PhoneTxtBoxm.Multiline = false;
            PhoneTxtBoxm.Name = "PhoneTxtBoxm";
            PhoneTxtBoxm.ReadOnly = false;
            PhoneTxtBoxm.Size = new Size(208, 34);
            PhoneTxtBoxm.Style = MetroSet_UI.Enums.Style.Light;
            PhoneTxtBoxm.StyleManager = null;
            PhoneTxtBoxm.TabIndex = 13;
            PhoneTxtBoxm.TextAlign = HorizontalAlignment.Center;
            PhoneTxtBoxm.ThemeAuthor = "Narwin";
            PhoneTxtBoxm.ThemeName = "MetroLight";
            PhoneTxtBoxm.UseSystemPasswordChar = false;
            PhoneTxtBoxm.WatermarkText = "";
            // 
            // NameTxtBoxm
            // 
            NameTxtBoxm.AutoCompleteCustomSource = null;
            NameTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            NameTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            NameTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            NameTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            NameTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            NameTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            NameTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            NameTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            NameTxtBoxm.Image = null;
            NameTxtBoxm.IsDerivedStyle = true;
            NameTxtBoxm.Lines = null;
            NameTxtBoxm.Location = new Point(198, 107);
            NameTxtBoxm.MaxLength = 32767;
            NameTxtBoxm.Multiline = false;
            NameTxtBoxm.Name = "NameTxtBoxm";
            NameTxtBoxm.ReadOnly = false;
            NameTxtBoxm.Size = new Size(208, 34);
            NameTxtBoxm.Style = MetroSet_UI.Enums.Style.Custom;
            NameTxtBoxm.StyleManager = null;
            NameTxtBoxm.TabIndex = 12;
            NameTxtBoxm.TextAlign = HorizontalAlignment.Center;
            NameTxtBoxm.ThemeAuthor = "Narwin";
            NameTxtBoxm.ThemeName = "MetroLite";
            NameTxtBoxm.UseSystemPasswordChar = false;
            NameTxtBoxm.WatermarkText = "";
            // 
            // IDTxtBoxm
            // 
            IDTxtBoxm.AutoCompleteCustomSource = null;
            IDTxtBoxm.AutoCompleteMode = AutoCompleteMode.None;
            IDTxtBoxm.AutoCompleteSource = AutoCompleteSource.None;
            IDTxtBoxm.BorderColor = Color.FromArgb(155, 155, 155);
            IDTxtBoxm.DisabledBackColor = Color.FromArgb(204, 204, 204);
            IDTxtBoxm.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            IDTxtBoxm.DisabledForeColor = Color.FromArgb(136, 136, 136);
            IDTxtBoxm.Font = new Font("Microsoft Sans Serif", 10F);
            IDTxtBoxm.HoverColor = Color.FromArgb(102, 102, 102);
            IDTxtBoxm.Image = null;
            IDTxtBoxm.IsDerivedStyle = false;
            IDTxtBoxm.Lines = null;
            IDTxtBoxm.Location = new Point(198, 26);
            IDTxtBoxm.MaxLength = 32767;
            IDTxtBoxm.Multiline = false;
            IDTxtBoxm.Name = "IDTxtBoxm";
            IDTxtBoxm.ReadOnly = true;
            IDTxtBoxm.Size = new Size(208, 34);
            IDTxtBoxm.Style = MetroSet_UI.Enums.Style.Custom;
            IDTxtBoxm.StyleManager = null;
            IDTxtBoxm.TabIndex = 11;
            IDTxtBoxm.TextAlign = HorizontalAlignment.Center;
            IDTxtBoxm.ThemeAuthor = "Narwin";
            IDTxtBoxm.ThemeName = "";
            IDTxtBoxm.UseSystemPasswordChar = false;
            IDTxtBoxm.WatermarkText = "";
            // 
            // Usernamem
            // 
            Usernamem.Font = new Font("Microsoft YaHei UI", 10F);
            Usernamem.IsDerivedStyle = true;
            Usernamem.Location = new Point(42, 347);
            Usernamem.Margin = new Padding(20, 23, 20, 23);
            Usernamem.Name = "Usernamem";
            Usernamem.Size = new Size(108, 34);
            Usernamem.Style = MetroSet_UI.Enums.Style.Light;
            Usernamem.StyleManager = null;
            Usernamem.TabIndex = 9;
            Usernamem.Text = "Username";
            Usernamem.ThemeAuthor = "Narwin";
            Usernamem.ThemeName = "MetroLight";
            // 
            // StEmailm
            // 
            StEmailm.Font = new Font("Microsoft YaHei UI", 10F);
            StEmailm.IsDerivedStyle = true;
            StEmailm.Location = new Point(42, 267);
            StEmailm.Margin = new Padding(20, 23, 20, 23);
            StEmailm.Name = "StEmailm";
            StEmailm.Size = new Size(100, 34);
            StEmailm.Style = MetroSet_UI.Enums.Style.Light;
            StEmailm.StyleManager = null;
            StEmailm.TabIndex = 8;
            StEmailm.Text = "Email";
            StEmailm.ThemeAuthor = "Narwin";
            StEmailm.ThemeName = "MetroLight";
            // 
            // StZipCodem
            // 
            StZipCodem.Font = new Font("Microsoft YaHei UI", 10F);
            StZipCodem.IsDerivedStyle = true;
            StZipCodem.Location = new Point(518, 187);
            StZipCodem.Margin = new Padding(20, 23, 20, 23);
            StZipCodem.Name = "StZipCodem";
            StZipCodem.Size = new Size(100, 34);
            StZipCodem.Style = MetroSet_UI.Enums.Style.Light;
            StZipCodem.StyleManager = null;
            StZipCodem.TabIndex = 7;
            StZipCodem.Text = "Zip Code";
            StZipCodem.ThemeAuthor = "Narwin";
            StZipCodem.ThemeName = "MetroLight";
            // 
            // Deptm
            // 
            Deptm.Font = new Font("Microsoft YaHei UI", 10F);
            Deptm.IsDerivedStyle = true;
            Deptm.Location = new Point(518, 347);
            Deptm.Margin = new Padding(20, 23, 20, 23);
            Deptm.Name = "Deptm";
            Deptm.Size = new Size(133, 34);
            Deptm.Style = MetroSet_UI.Enums.Style.Light;
            Deptm.StyleManager = null;
            Deptm.TabIndex = 6;
            Deptm.Text = "Department";
            Deptm.ThemeAuthor = "Narwin";
            Deptm.ThemeName = "MetroLight";
            // 
            // StCitym
            // 
            StCitym.Font = new Font("Microsoft YaHei UI", 10F);
            StCitym.IsDerivedStyle = true;
            StCitym.Location = new Point(518, 26);
            StCitym.Margin = new Padding(20, 23, 20, 23);
            StCitym.Name = "StCitym";
            StCitym.Size = new Size(100, 34);
            StCitym.Style = MetroSet_UI.Enums.Style.Light;
            StCitym.StyleManager = null;
            StCitym.TabIndex = 5;
            StCitym.Text = "City";
            StCitym.ThemeAuthor = "Narwin";
            StCitym.ThemeName = "MetroLight";
            // 
            // StStreetm
            // 
            StStreetm.Font = new Font("Microsoft YaHei UI", 10F);
            StStreetm.IsDerivedStyle = true;
            StStreetm.Location = new Point(518, 107);
            StStreetm.Margin = new Padding(20, 23, 20, 23);
            StStreetm.Name = "StStreetm";
            StStreetm.Size = new Size(100, 34);
            StStreetm.Style = MetroSet_UI.Enums.Style.Light;
            StStreetm.StyleManager = null;
            StStreetm.TabIndex = 4;
            StStreetm.Text = "Street";
            StStreetm.ThemeAuthor = "Narwin";
            StStreetm.ThemeName = "MetroLight";
            // 
            // StAgem
            // 
            StAgem.Font = new Font("Microsoft YaHei UI", 10F);
            StAgem.IsDerivedStyle = true;
            StAgem.Location = new Point(518, 267);
            StAgem.Margin = new Padding(20, 23, 20, 23);
            StAgem.Name = "StAgem";
            StAgem.Size = new Size(100, 34);
            StAgem.Style = MetroSet_UI.Enums.Style.Light;
            StAgem.StyleManager = null;
            StAgem.TabIndex = 3;
            StAgem.Text = "Age";
            StAgem.ThemeAuthor = "Narwin";
            StAgem.ThemeName = "MetroLight";
            // 
            // StPhonem
            // 
            StPhonem.Font = new Font("Microsoft YaHei UI", 10F);
            StPhonem.IsDerivedStyle = true;
            StPhonem.Location = new Point(42, 187);
            StPhonem.Margin = new Padding(20, 23, 20, 23);
            StPhonem.Name = "StPhonem";
            StPhonem.Size = new Size(100, 34);
            StPhonem.Style = MetroSet_UI.Enums.Style.Light;
            StPhonem.StyleManager = null;
            StPhonem.TabIndex = 2;
            StPhonem.Text = "Phone";
            StPhonem.ThemeAuthor = "Narwin";
            StPhonem.ThemeName = "MetroLight";
            // 
            // StNamem
            // 
            StNamem.Font = new Font("Microsoft YaHei UI", 10F);
            StNamem.IsDerivedStyle = true;
            StNamem.Location = new Point(42, 107);
            StNamem.Margin = new Padding(20, 23, 20, 23);
            StNamem.Name = "StNamem";
            StNamem.Size = new Size(100, 34);
            StNamem.Style = MetroSet_UI.Enums.Style.Light;
            StNamem.StyleManager = null;
            StNamem.TabIndex = 1;
            StNamem.Text = "Name";
            StNamem.ThemeAuthor = "Narwin";
            StNamem.ThemeName = "MetroLight";
            // 
            // StuIDm
            // 
            StuIDm.Font = new Font("Microsoft YaHei UI", 10F);
            StuIDm.IsDerivedStyle = true;
            StuIDm.Location = new Point(42, 26);
            StuIDm.Margin = new Padding(20, 23, 20, 23);
            StuIDm.Name = "StuIDm";
            StuIDm.Size = new Size(100, 34);
            StuIDm.Style = MetroSet_UI.Enums.Style.Light;
            StuIDm.StyleManager = null;
            StuIDm.TabIndex = 0;
            StuIDm.Text = "ID";
            StuIDm.ThemeAuthor = "Narwin";
            StuIDm.ThemeName = "MetroLight";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnTakeExamMA);
            tabPage2.Controls.Add(comboCrsNameMA);
            tabPage2.Controls.Add(lblCourseNameMA);
            tabPage2.Location = new Point(4, 42);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1203, 506);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Take Exam";
            // 
            // btnTakeExamMA
            // 
            btnTakeExamMA.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnTakeExamMA.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnTakeExamMA.DisabledForeColor = Color.Gray;
            btnTakeExamMA.Font = new Font("Microsoft Sans Serif", 10F);
            btnTakeExamMA.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnTakeExamMA.HoverColor = Color.FromArgb(95, 207, 255);
            btnTakeExamMA.HoverTextColor = Color.White;
            btnTakeExamMA.IsDerivedStyle = true;
            btnTakeExamMA.Location = new Point(523, 298);
            btnTakeExamMA.Name = "btnTakeExamMA";
            btnTakeExamMA.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnTakeExamMA.NormalColor = Color.FromArgb(65, 177, 225);
            btnTakeExamMA.NormalTextColor = Color.White;
            btnTakeExamMA.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnTakeExamMA.PressColor = Color.FromArgb(35, 147, 195);
            btnTakeExamMA.PressTextColor = Color.White;
            btnTakeExamMA.Size = new Size(148, 39);
            btnTakeExamMA.Style = MetroSet_UI.Enums.Style.Light;
            btnTakeExamMA.StyleManager = null;
            btnTakeExamMA.TabIndex = 2;
            btnTakeExamMA.Text = "Take Exam";
            btnTakeExamMA.ThemeAuthor = "Narwin";
            btnTakeExamMA.ThemeName = "MetroLite";
            btnTakeExamMA.Click += btnTakeExamMA_Click;
            // 
            // comboCrsNameMA
            // 
            comboCrsNameMA.AllowDrop = true;
            comboCrsNameMA.ArrowColor = Color.FromArgb(150, 150, 150);
            comboCrsNameMA.BackColor = Color.Transparent;
            comboCrsNameMA.BackgroundColor = Color.FromArgb(238, 238, 238);
            comboCrsNameMA.BorderColor = Color.FromArgb(150, 150, 150);
            comboCrsNameMA.CausesValidation = false;
            comboCrsNameMA.DisabledBackColor = Color.FromArgb(204, 204, 204);
            comboCrsNameMA.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            comboCrsNameMA.DisabledForeColor = Color.FromArgb(136, 136, 136);
            comboCrsNameMA.DrawMode = DrawMode.OwnerDrawFixed;
            comboCrsNameMA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCrsNameMA.Font = new Font("Microsoft Sans Serif", 11F);
            comboCrsNameMA.FormattingEnabled = true;
            comboCrsNameMA.IsDerivedStyle = true;
            comboCrsNameMA.ItemHeight = 20;
            comboCrsNameMA.Location = new Point(643, 148);
            comboCrsNameMA.Name = "comboCrsNameMA";
            comboCrsNameMA.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            comboCrsNameMA.SelectedItemForeColor = Color.White;
            comboCrsNameMA.Size = new Size(151, 26);
            comboCrsNameMA.Style = MetroSet_UI.Enums.Style.Light;
            comboCrsNameMA.StyleManager = null;
            comboCrsNameMA.TabIndex = 1;
            comboCrsNameMA.ThemeAuthor = "Narwin";
            comboCrsNameMA.ThemeName = "MetroLite";
            // 
            // lblCourseNameMA
            // 
            lblCourseNameMA.Font = new Font("Microsoft Sans Serif", 10F);
            lblCourseNameMA.IsDerivedStyle = true;
            lblCourseNameMA.Location = new Point(458, 148);
            lblCourseNameMA.Name = "lblCourseNameMA";
            lblCourseNameMA.Size = new Size(125, 29);
            lblCourseNameMA.Style = MetroSet_UI.Enums.Style.Light;
            lblCourseNameMA.StyleManager = null;
            lblCourseNameMA.TabIndex = 0;
            lblCourseNameMA.Text = "Course";
            lblCourseNameMA.ThemeAuthor = "Narwin";
            lblCourseNameMA.ThemeName = "MetroLite";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(studentGradesGridViewm);
            tabPage3.Location = new Point(4, 42);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1203, 506);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Grades";
            // 
            // studentGradesGridViewm
            // 
            studentGradesGridViewm.AllowUserToAddRows = false;
            studentGradesGridViewm.AllowUserToDeleteRows = false;
            studentGradesGridViewm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentGradesGridViewm.CellBorderStyle = DataGridViewCellBorderStyle.None;
            studentGradesGridViewm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGradesGridViewm.Enabled = false;
            studentGradesGridViewm.Location = new Point(4, 3);
            studentGradesGridViewm.Name = "studentGradesGridViewm";
            studentGradesGridViewm.ReadOnly = true;
            studentGradesGridViewm.Size = new Size(1196, 500);
            studentGradesGridViewm.TabIndex = 0;
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(901, 0);
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
            metroSetControlBox1.ThemeName = "MetroLight";
            // 
            // StudentForm
            // 
            AllowResize = false;
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1000, 607);
            Controls.Add(metroSetControlBox1);
            Controls.Add(StudentTabControlm);
            Font = new Font("Microsoft YaHei UI", 13F);
            MaximumSize = new Size(1000, 607);
            MinimumSize = new Size(1000, 607);
            Name = "StudentForm";
            Padding = new Padding(12, 80, 12, 14);
            ShowLeftRect = false;
            Text = "Student Interface";
            TextColor = Color.Black;
            ThemeName = "MetroLight";
            FormClosing += StudentForm_FormClosing;
            Load += StudentForm_Load;
            StudentTabControlm.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentGradesGridViewm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTabControl StudentTabControlm;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MetroSet_UI.Controls.MetroSetLabel StEmailm;
        private MetroSet_UI.Controls.MetroSetLabel StZipCodem;
        private MetroSet_UI.Controls.MetroSetLabel Deptm;
        private MetroSet_UI.Controls.MetroSetLabel StCitym;
        private MetroSet_UI.Controls.MetroSetLabel StStreetm;
        private MetroSet_UI.Controls.MetroSetLabel StAgem;
        private MetroSet_UI.Controls.MetroSetLabel StPhonem;
        private MetroSet_UI.Controls.MetroSetLabel StNamem;
        private MetroSet_UI.Controls.MetroSetLabel StuIDm;
        private MetroSet_UI.Controls.MetroSetLabel Usernamem;
        private MetroSet_UI.Controls.MetroSetTextBox ZipTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox StTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox CityTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox DeptTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox UsernameTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox EmailTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox AgeTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox PhoneTxtBoxm;
        private MetroSet_UI.Controls.MetroSetTextBox NameTxtBoxm;
        private MetroSet_UI.Controls.MetroSetButton SaveBtnm;
        private MetroSet_UI.Controls.MetroSetTextBox IDTxtBoxm;
        private DataGridView studentGradesGridViewm;
        private MetroSet_UI.Controls.MetroSetLabel lblCourseNameMA;
        private MetroSet_UI.Controls.MetroSetButton btnTakeExamMA;
        private MetroSet_UI.Controls.MetroSetComboBox comboCrsNameMA;
    }
}