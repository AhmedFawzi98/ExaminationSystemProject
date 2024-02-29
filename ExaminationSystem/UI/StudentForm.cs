namespace ExaminationSystem.UI;

public partial class StudentForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examContext;
    private readonly Examination_SystemContextProcedures _spContext;
    private  Student _currentStudent;

    public StudentForm(ILogger logger, Examination_SystemContext examContext, Examination_SystemContextProcedures spContext, Student currentStudent)
    {
        InitializeComponent();
        _logger = logger;
        _examContext = examContext;
        _spContext = spContext;
        _currentStudent = currentStudent;
    }
    private void StudentForm_Load(object sender, EventArgs e)
    {
        this.StudentTabControlm.SelectedIndex = 0;
        ProfileLoad();
    }

    private void ProfileLoad()
    {
       
        try
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
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during" +
                "Loading your profile",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
    private async void GradesLoad()
    {
        try
        {
            var studentCourseGrade = await _spContext.SP_Get_Student_Grade_By_IDAsync(_currentStudent.StId);
            studentGradesGridViewm.DataSource = studentCourseGrade;
            studentGradesGridViewm.ReadOnly = true;
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during" +
                "Loading your Grades",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
    private async void SaveBtnm_Click(object sender, EventArgs e)
    {
        try
        {
            if (ValidateChanged())
            {
                await _spContext.SP_Update_StudentAsync(int.Parse(IDTxtBoxm.Text), UsernameTxtBoxm.Text, NameTxtBoxm.Text, EmailTxtBoxm.Text,
                    int.Parse(AgeTxtBoxm.Text), StTxtBoxm.Text, PhoneTxtBoxm.Text, CityTxtBoxm.Text,
                    ZipTxtBoxm.Text, _currentStudent.DeptId);

                UpdateCurrentStudent();
                
                MetroSetMessageBox.Show(this, "Changes saved successfully", "Saved changes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MetroSetMessageBox.Show(this, "Nothing to change", "Nothing changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during" +
                "Saving your changes",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

    private void UpdateCurrentStudent()
    {
        try
        {
            _currentStudent.Street = StTxtBoxm.Text;
            _currentStudent.StAge = int.Parse(AgeTxtBoxm.Text);
            _currentStudent.StEmail = EmailTxtBoxm.Text;
            _currentStudent.StPhone = PhoneTxtBoxm.Text;
            _currentStudent.City = CityTxtBoxm.Text;
            _currentStudent.StName = NameTxtBoxm.Text;
            _currentStudent.ZipCode = ZipTxtBoxm.Text;
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during" +
                "Saving your changes",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }


    }

    private bool ValidateChanged()
    {
        try
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
        catch (Exception ex)
        {
            _logger.Log(ex);
            return false;
        }

    }
    private void TakeExam()
    {
        try
        {
            var res = _examContext.Courses.Include(c => c.StudentCourses)
                    .Where(course => course.StudentCourses.Any(SC => SC.StId == _currentStudent.StId))
                    .Select(course => new { id = course.CrId, name = course.CrName })
                    .ToList();

            comboCrsNameMA.DataSource = res;
            comboCrsNameMA.DisplayMember = "name";
            comboCrsNameMA.ValueMember = "id";
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during" +
                "Loading Take Exam page",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
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
            exampage.FormClosed += (sender, e) => this.Show();
            exampage.Show();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during" +
                "Loading your Exam page",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
