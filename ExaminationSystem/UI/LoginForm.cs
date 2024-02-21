using ExaminationSystem.ContextExaminationSystem;

namespace ExaminationSystem.UI;
public partial class LoginForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly LoginContext _loginContext;
    private readonly Examination_SystemContext _examination_SystemContext;
    private List<Login> _accountLogins;

    public LoginForm(ILogger logger, LoginContext loginContext,Examination_SystemContext examination_SystemContext)
    {
        InitializeComponent();
        _logger = logger;
        _loginContext = loginContext;
        _examination_SystemContext = examination_SystemContext;
    }
    private void LoginForm_Load(object sender, EventArgs e)
    {
        _loginContext.Logins.Load();
        _accountLogins = _loginContext.Logins.Local.ToList();
    }

    private void btnLogin_Click_1(object sender, EventArgs e)
    {
        string username = txtboxUsernameLogin.Text.Trim();
        string password = txtboxPasswordLogin.Text.Trim();
        var loginResult = _accountLogins.Where(l => l.Username == username && l.Password == password).FirstOrDefault();
        if (loginResult is null)
            MetroSetMessageBox.Show(this, "wrong username or password, try again", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else if (loginResult.AccountType.Equals('s'))
        {
            this.Hide();
            StudentForm studentForm = new StudentForm(_logger, _examination_SystemContext);
            studentForm.FormClosed += (sender, e) => this.Close();
            studentForm.Show();
        }
        else
        {
            this.Hide();
            InstructorForm instructorForm = new InstructorForm(_logger, _examination_SystemContext);
            instructorForm.FormClosed += (sender, e) => this.Close();
            instructorForm.Show();
        }
    }

    private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _loginContext.Dispose();
    }
}

