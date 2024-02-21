namespace ExaminationSystem.UI;
public partial class LoginForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly LoginContext _loginContext;
    private List<Login> _accountLogins;
    public LoginForm(ILogger logger, LoginContext loginContext)
    {
        InitializeComponent();
        _logger = logger;
        _loginContext = loginContext;
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
            //Studentform = new Frontend(_logger, new ReservationContext());
            //frontendForm.FormClosed += (sender, e) => this.Close();
            //frontendForm.Show();
        }
        else
        {
            this.Hide();
            //kitchenForm = new Kitchen(_logger, new ReservationContext());
            //kitchenForm.FormClosed += (sender, e) => this.Close();
            //kitchenForm.Show();
        }
    }

    
}

