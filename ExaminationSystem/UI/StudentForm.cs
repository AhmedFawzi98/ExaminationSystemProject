using ExaminationSystem.ContextLogins;

namespace ExaminationSystem.UI;

public partial class StudentForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examContext;
    public StudentForm(ILogger logger, Examination_SystemContext examContext)
    {
        InitializeComponent();
        _logger = logger;
        _examContext = examContext;
    }

    private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _examContext.Dispose();
    }
}
