using ExaminationSystem.ContextLogins;
using System;

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

    private async void SaveBtnm_Click(object sender, EventArgs e)
    {
        if (ValidateChanged())
        {
            await _spContext.SP_Update_StudentAsync(int.Parse(IDTxtBoxm.Text), NameTxtBoxm.Text, EmailTxtBoxm.Text,
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
        return((IDTxtBoxm.Text != _currentStudent.StId.ToString()) ||
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
}
