﻿using System.Diagnostics;

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


    private void numericMcq_ValueChanged(object sender, EventArgs e)
    {
        numericTFf.Value = 10 - numericMcqf.Value;

    }

}
