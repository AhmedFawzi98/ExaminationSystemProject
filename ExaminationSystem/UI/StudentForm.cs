using ExaminationSystem.ContextLogins;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace ExaminationSystem.UI;

public partial class StudentForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examContext;
    private readonly Examination_SystemContextProcedures _spContext;
    private readonly Student _currentStudent;

    public StudentForm(ILogger logger, Examination_SystemContext examContext, Examination_SystemContextProcedures spContext, Student currentStudent)
    {
        InitializeComponent();
        _logger = logger;
        _examContext = examContext;
        _spContext = spContext;
        _currentStudent = currentStudent;
    }

    private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        _examContext.Dispose();
    }

    private void StudentForm_Load(object sender, EventArgs e)
    {
        this.StudentTabControlm.SelectedIndex = 0;
        ProfileLoad();
    }

    private void ProfileLoad()
    {
        IDTxtBoxm.Text = _currentStudent.StId.ToString();
        NameTxtBoxm.Text = _currentStudent.StName;
        PhoneTxtBoxm.Text = _currentStudent.StPhone;
        AgeTxtBoxm.Text = _currentStudent.StAge.ToString();
        EmailTxtBoxm.Text = _currentStudent.StEmail;
        UsernameTxtBoxm.Text = _currentStudent.Username;
        DeptTxtBoxm.Text = _currentStudent.Dept?.DeptName ?? "";
        CityTxtBoxm.Text = _currentStudent.City;
        StTxtBoxm.Text = _currentStudent.Street;
        ZipTxtBoxm.Text = _currentStudent.ZipCode;
    }
    private async void GradesLoad()
    {
        var studentCourseGrade = await _spContext.SP_Get_Student_Grade_By_IDAsync(_currentStudent.StId);

        studentGradesGridViewm.DataSource = studentCourseGrade;
        studentGradesGridViewm.ReadOnly = true;
    }

    private async void SaveBtnm_Click(object sender, EventArgs e)
    {
        if (ValidateChanged())
        {
            await _spContext.SP_Update_StudentAsync(int.Parse(IDTxtBoxm.Text), UsernameTxtBoxm.Text, NameTxtBoxm.Text, EmailTxtBoxm.Text,
                int.Parse(AgeTxtBoxm.Text), StTxtBoxm.Text, PhoneTxtBoxm.Text, CityTxtBoxm.Text,
                ZipTxtBoxm.Text, _currentStudent.DeptId);
            MetroSetMessageBox.Show(this, "Changes saved successfully", "Saved changes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
            MetroSetMessageBox.Show(this, "Nothing to change", "Nothing changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private bool ValidateChanged()
    {
        return ((IDTxtBoxm.Text != _currentStudent.StId.ToString()) ||
            (NameTxtBoxm.Text != _currentStudent.StName) ||
            (PhoneTxtBoxm.Text != _currentStudent.StPhone) ||
            (AgeTxtBoxm.Text != _currentStudent.StAge.ToString()) ||
            (EmailTxtBoxm.Text != _currentStudent.StEmail) ||
            (UsernameTxtBoxm.Text != _currentStudent.Username) ||
            (DeptTxtBoxm.Text != (_currentStudent.Dept?.DeptName ?? "")) ||
            (CityTxtBoxm.Text != _currentStudent.City) ||
            (StTxtBoxm.Text != _currentStudent.Street) ||
            (ZipTxtBoxm.Text != _currentStudent.ZipCode));
    }
    private void TakeExam()
    {
        var res = _examContext.Courses.Include(c => c.StudentCourses)
       .Where(course => course.StudentCourses.Any(SC => SC.StId == _currentStudent.StId))
       .Select(course => new { id = course.CrId, name = course.CrName })
       .ToList();

        comboCrsNameMA.DataSource = res;
        comboCrsNameMA.DisplayMember = "name";
        comboCrsNameMA.ValueMember = "id";

    }


    private void StudentTabControlm_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (this.StudentTabControlm.SelectedIndex)
        {
            case 0:
                ProfileLoad();
                break;
            case 1:
                TakeExam();
                break;
            case 2:
                GradesLoad();
                break;
        }

    }

    private async void btnTakeExamMA_Click(object sender, EventArgs e)
    {
        try
        {
            int.TryParse(comboCrsNameMA.SelectedValue.ToString(), out int crID);
            OutputParameter<int?> examid = new OutputParameter<int?>();
            await _spContext.SP_Assign_Student_ExamAsync(crID, examid);
           
            int.TryParse(examid.Value.ToString(), out int examIdInt);
            ExamPage exampage = new ExamPage(_logger,_examContext,_spContext,_currentStudent, examIdInt, crID);
            this.Hide();
            exampage.Show();
        }
        catch(Exception ex) 
        {
            _logger.Log(ex);
        }
    }
}
