using System.Diagnostics;


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
        LoadProfile();
    }
    private void LoadProfile()
    {
        txtInstructorIDMA.Text = _currentInstructor.InsId.ToString();
        numInstructorSalaryMA.Text = _currentInstructor.InsSalary.ToString();
        txtInstructorDegreeMA.Text = _currentInstructor.InsDegree;
        txtInstructorNameMA.Text = _currentInstructor.InsName;
        txtInstructorUserNameMA.Text = _currentInstructor.Username;
        txtInstructorDepartmentMA.Text = _currentInstructor.Dept.DeptName;
    }




    private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        numericmf.Maximum = 2000000;
        numeric2mf.Maximum = 2000000;

        if (metroSetTabControl1.SelectedIndex == 4)
        {
            var results = _examination_SystemContext.Departments
                        .Join(_examination_SystemContext.Instructors,
                         department => department.DeptId,
                         instructor => instructor.DeptId,
                         (department, instructor) => new { Department = department, Instructor = instructor })
                         .Where(joinResult => joinResult.Instructor.DeptId == _currentInstructor.DeptId)
                         .Select(joinResult => joinResult.Department)
                          .FirstOrDefault();


            TextBox4mf.Text = results.DeptName;
            TextBox5mf.Text = results.Location;
            numericmf.Value = Convert.ToDecimal(results.DeptId);
            numeric2mf.Value = Convert.ToDecimal(results.MgrId);
            TextBox3mf.Text = results.DeptDescription;
            dateTime1.Value = (DateTime)results.MgrHireDate;


            if (_currentInstructor.InsId != results.MgrId)
            {
                TextBox4mf.ReadOnly = true;
                TextBox5mf.ReadOnly = true;
                numericmf.Enabled = false;
                numeric2mf.Enabled = false;
                TextBox3mf.ReadOnly = true;
                dateTime1.Enabled = false;
                Save.Visible = false;

            }

            Debug.WriteLine(results.DeptName);

        }
    }
    private async void Save_Click(object sender, EventArgs e)
    {
        if (numeric2mf.Value != 0) { 
        Examination_SystemContextProcedures SpContext = new(_examination_SystemContext);

        await SpContext.SP_UPDATE_DepartmentAsync(Convert.ToInt32(numericmf.Value), TextBox4mf.Text, TextBox3mf.Text, TextBox5mf.Text, Convert.ToInt32(numeric2mf.Value), Convert.ToDateTime(dateTime1.Value));

        _examination_SystemContext.SaveChanges();
        MessageBox.Show("Changes saved successfully!", "Success");
        }
       
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
