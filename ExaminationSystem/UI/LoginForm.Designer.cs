namespace ExaminationSystem.UI
{
    partial class LoginForm
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
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            txtboxUsernameLogin = new MetroSet_UI.Controls.MetroSetTextBox();
            txtboxPasswordLogin = new MetroSet_UI.Controls.MetroSetTextBox();
            btnLogin = new MetroSet_UI.Controls.MetroSetButton();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(695, 5);
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
            metroSetControlBox1.TabIndex = 0;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // txtboxUsernameLogin
            // 
            txtboxUsernameLogin.AutoCompleteCustomSource = null;
            txtboxUsernameLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtboxUsernameLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtboxUsernameLogin.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxUsernameLogin.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxUsernameLogin.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxUsernameLogin.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxUsernameLogin.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxUsernameLogin.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxUsernameLogin.Image = null;
            txtboxUsernameLogin.IsDerivedStyle = true;
            txtboxUsernameLogin.Lines = null;
            txtboxUsernameLogin.Location = new Point(286, 119);
            txtboxUsernameLogin.MaxLength = 32767;
            txtboxUsernameLogin.Multiline = false;
            txtboxUsernameLogin.Name = "txtboxUsernameLogin";
            txtboxUsernameLogin.ReadOnly = false;
            txtboxUsernameLogin.Size = new Size(253, 38);
            txtboxUsernameLogin.Style = MetroSet_UI.Enums.Style.Light;
            txtboxUsernameLogin.StyleManager = null;
            txtboxUsernameLogin.TabIndex = 1;
            txtboxUsernameLogin.TextAlign = HorizontalAlignment.Left;
            txtboxUsernameLogin.ThemeAuthor = "Narwin";
            txtboxUsernameLogin.ThemeName = "MetroLite";
            txtboxUsernameLogin.UseSystemPasswordChar = false;
            txtboxUsernameLogin.WatermarkText = "username";
            // 
            // txtboxPasswordLogin
            // 
            txtboxPasswordLogin.AutoCompleteCustomSource = null;
            txtboxPasswordLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtboxPasswordLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtboxPasswordLogin.BorderColor = Color.FromArgb(155, 155, 155);
            txtboxPasswordLogin.DisabledBackColor = Color.FromArgb(204, 204, 204);
            txtboxPasswordLogin.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            txtboxPasswordLogin.DisabledForeColor = Color.FromArgb(136, 136, 136);
            txtboxPasswordLogin.Font = new Font("Microsoft Sans Serif", 10F);
            txtboxPasswordLogin.HoverColor = Color.FromArgb(102, 102, 102);
            txtboxPasswordLogin.Image = null;
            txtboxPasswordLogin.IsDerivedStyle = true;
            txtboxPasswordLogin.Lines = null;
            txtboxPasswordLogin.Location = new Point(286, 183);
            txtboxPasswordLogin.MaxLength = 32767;
            txtboxPasswordLogin.Multiline = false;
            txtboxPasswordLogin.Name = "txtboxPasswordLogin";
            txtboxPasswordLogin.ReadOnly = false;
            txtboxPasswordLogin.Size = new Size(253, 38);
            txtboxPasswordLogin.Style = MetroSet_UI.Enums.Style.Light;
            txtboxPasswordLogin.StyleManager = null;
            txtboxPasswordLogin.TabIndex = 2;
            txtboxPasswordLogin.TextAlign = HorizontalAlignment.Left;
            txtboxPasswordLogin.ThemeAuthor = "Narwin";
            txtboxPasswordLogin.ThemeName = "MetroLite";
            txtboxPasswordLogin.UseSystemPasswordChar = true;
            txtboxPasswordLogin.WatermarkText = "password";
            // 
            // btnLogin
            // 
            btnLogin.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnLogin.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnLogin.DisabledForeColor = Color.Gray;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F);
            btnLogin.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnLogin.HoverColor = Color.FromArgb(95, 207, 255);
            btnLogin.HoverTextColor = Color.White;
            btnLogin.IsDerivedStyle = true;
            btnLogin.Location = new Point(367, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnLogin.NormalColor = Color.FromArgb(65, 177, 225);
            btnLogin.NormalTextColor = Color.White;
            btnLogin.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnLogin.PressColor = Color.FromArgb(35, 147, 195);
            btnLogin.PressTextColor = Color.White;
            btnLogin.Size = new Size(89, 29);
            btnLogin.Style = MetroSet_UI.Enums.Style.Light;
            btnLogin.StyleManager = null;
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.ThemeAuthor = "Narwin";
            btnLogin.ThemeName = "MetroLite";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Leelawadee UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(5, 427);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(340, 29);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 4;
            metroSetLabel1.Text = "© Developed by Tigers Team - ITI - Intake 44 ";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(metroSetLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtboxPasswordLogin);
            Controls.Add(txtboxUsernameLogin);
            Controls.Add(metroSetControlBox1);
            MaximumSize = new Size(800, 450);
            MinimumSize = new Size(800, 450);
            Name = "LoginForm";
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxUsernameLogin;
        private MetroSet_UI.Controls.MetroSetTextBox txtboxPasswordLogin;
        private MetroSet_UI.Controls.MetroSetButton btnLogin;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
    }
}