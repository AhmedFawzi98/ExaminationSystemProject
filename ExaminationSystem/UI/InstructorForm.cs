namespace ExaminationSystem.UI;

public partial class InstructorForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examination_SystemContext;
    private readonly Examination_SystemContextProcedures _spContext;

    public InstructorForm(ILogger logger, Examination_SystemContext examination_SystemContext, Examination_SystemContextProcedures spContext)
    {
        InitializeComponent();
        _logger = logger;
        _examination_SystemContext = examination_SystemContext;
        _spContext = spContext;
    }
    private async void InstructorForm_Load(object sender, EventArgs e)
    {
        var studentCourseGrade = await _spContext.SP_SelectAllInstructorStudentCoursesAsync(1032);

        gradesGridView.DataSource = studentCourseGrade;
        gradesGridView.ReadOnly = true;
    }

    private void numericMcq_ValueChanged(object sender, EventArgs e)
    {
        numericTFf.Value = 10 - numericMcqf.Value;

    }
}
