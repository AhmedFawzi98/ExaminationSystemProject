using System.Diagnostics;
using System.Windows.Forms;

namespace ExaminationSystem.UI;

public partial class InstructorForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examination_SystemContext;
    private readonly Examination_SystemContextProcedures _spContext;
    private readonly Instructor _currentInstructor;

    public InstructorForm(ILogger logger, Examination_SystemContext examination_SystemContext, Examination_SystemContextProcedures spContext, Instructor currentInstructor)
    {
        InitializeComponent();
        _logger = logger;
        _examination_SystemContext = examination_SystemContext;
        _spContext = spContext;
        _currentInstructor = currentInstructor;
    }

    private async void InstructorForm_Load(object sender, EventArgs e)
    {
        try
        {
            await LoadGradesGridViwDataSources();
            await LoadCoursesNamesComboBoxDataSources();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            DialogResult result = MetroSetMessageBox.Show(this, $"instructor control panel can't be loaded", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
    private async Task LoadGradesGridViwDataSources() 
    {
        var studentCourseGrade = await _spContext.SP_SelectAllInstructorStudentCoursesAsync(1032);
        gradesGridView.DataSource = studentCourseGrade;
        gradesGridView.ReadOnly = true;
        gradesGridView.Columns["StudentGrade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        gradesGridView.Columns["StudentName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        gradesGridView.Columns["CourseName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
    private async Task LoadCoursesNamesComboBoxDataSources()
    {
        var coursesNamesOfCurrentIns = (await _spContext.SP_GetCourseName_and_NumberOFStudentsPerCourse_By_InstructorIDAsync(_currentInstructor.InsId))
                        .AsEnumerable()
                        .Select(c => c.CourseName).ToList();

        comboboxCoursef.DataSource = coursesNamesOfCurrentIns;
    }

    private void numericMcq_ValueChanged(object sender, EventArgs e)
    {
        numericTFf.Value = 10 - numericMcqf.Value;

    }

    private async void btnGenerateExam_Click(object sender, EventArgs e)
    {
        try
        {
            int numOfMcq = Convert.ToInt32(numericMcqf.Value);
            int numOfTF = Convert.ToInt32(numericTFf.Value);
            OutputParameter<int?> generatedExamId = new OutputParameter<int?>();

            await _spContext.SP_Generate_ExamAsync(comboboxCoursef.SelectedItem?.ToString(), numOfMcq, numOfTF, generatedExamId);
            MetroSetMessageBox.Show(this, $"a new exam with ExamId={generatedExamId.Value} was generated successfully", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            GeneratedExamForm generatedExamForm = new GeneratedExamForm(_logger, _spContext, generatedExamId.Value);
            generatedExamForm.Show();
        }
        catch(Exception ex)
        {
            _logger.Log(ex);
            MetroSetMessageBox.Show(this, $"an error occured, can't create new exam", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
