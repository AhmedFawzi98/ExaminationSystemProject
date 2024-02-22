
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
        var studentCourseGrade = await _spContext.SP_SelectAllInstructorStudentCoursesAsync(1032);

        gradesGridView.DataSource = studentCourseGrade;
        gradesGridView.ReadOnly = true;
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


}
