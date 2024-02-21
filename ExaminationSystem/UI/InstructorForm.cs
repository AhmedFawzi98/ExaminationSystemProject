namespace ExaminationSystem.UI;

public partial class InstructorForm : Form
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examination_SystemContext;
    public InstructorForm(ILogger logger, Examination_SystemContext examination_SystemContext)
    {
        InitializeComponent();
        _logger = logger;
        _examination_SystemContext = examination_SystemContext;
    }

}
