using ExaminationSystem.ContextLogins;

namespace ExaminationSystem.UI;

public partial class StudentForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examContext;
    private readonly Examination_SystemContextProcedures _spContext;

    public StudentForm(ILogger logger, Examination_SystemContext examContext, Examination_SystemContextProcedures spContext)
    {
        InitializeComponent();
        _logger = logger;
        _examContext = examContext;
        _spContext = spContext;
    }

    private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _examContext.Dispose();
    }


}
