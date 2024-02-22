using ExaminationSystem.EntitiesExaminationSystem;
using System;
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
        var studentCourseGrade = await _spContext.SP_SelectAllInstructorStudentCoursesAsync(1032);

        gradesGridView.DataSource = studentCourseGrade;
        gradesGridView.ReadOnly = true;
    }



    private void metroSetTabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Debug.WriteLine(_currentInstructor.Crs);

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
            TextBox4mf.ReadOnly = true;
            TextBox5mf.Text = results.Location;
            TextBox5mf.ReadOnly = true;
            numericmf.Value = Convert.ToDecimal(results.DeptId);
            numericmf.Enabled = false;
            numeric2mf.Value = Convert.ToDecimal(results.MgrId);
            numeric2mf.Enabled = false;
            TextBox3mf.Text = results.DeptDescription;
            TextBox3mf.ReadOnly = true;
            dateTime1.Value = (DateTime) results.MgrHireDate;
            dateTime1.Enabled = false;
            

            Debug.WriteLine(results.DeptName);

        }
    }
}
