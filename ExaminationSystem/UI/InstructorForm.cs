using ExaminationSystem.EntitiesExaminationSystem;
using System.Diagnostics;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Threading;
using ExaminationSystem.ContextExaminationSystem;

namespace ExaminationSystem.UI;

public partial class InstructorForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContext _examination_SystemContext;
    private readonly Examination_SystemContextProcedures _spContext;
    private int _id;
    private string _questionHead;
    private string _grade;
    private string _difficulty;
    private string _type;
    private string _model;
    private string _course;
    private List<Course> Courses;




    public InstructorForm(ILogger logger, Examination_SystemContext examination_SystemContext, Examination_SystemContextProcedures spContext)
    {
        InitializeComponent();
        _logger = logger;
        _examination_SystemContext = examination_SystemContext;
        _spContext = spContext;
        List<Course> Courses = _examination_SystemContext.Courses.ToList();

        this.IComboBoxCourses.DataSource = Courses;
        this.IComboBoxCourses.DisplayMember = "CrId";
        this.IComboBoxCourses.ValueMember = "CrId";
        //this.IComboBoxCourses.SelectedIndex = 0;

        HidingAll();
    }
    //my name is fawzi 
    //dsfewfew
    //Buffer/fer
    // IbrahimHassan
    private async void InstructorForm_Load(object sender, EventArgs e)
    {
        var studentCourseGrade = await _spContext.SP_SelectAllInstructorStudentCoursesAsync(1032);

        gradesGridView.DataSource = studentCourseGrade;
        gradesGridView.ReadOnly = true;
    }


    private void ITFRadio_CheckedChanged(object sender)
    {
        ShowTF();
        HideMcq();
    }

    private void IMCQ_CheckedChanged(object sender)
    {
        ShowMcq();
        HideTF();
    }

    //int result = await _spContext.SP_INSERT_QuestionAsync(id, head, grade, difficulty, type, model, course);
    //int result2 = await _spContext.SP_INSERT_Question_ChoicesAsync(int ? id, string desc, string selector, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    // SP   SP_INSERT_Question
    // SP   SP_INSERT_Question_Choices


    private void HidingAll()
    {
        this.IQuestionAnswerA.Visible = false;
        this.IQuestionAnswerB.Visible = false;
        this.IQuestionAnswerC.Visible = false;
        this.IQuestionAnswerD.Visible = false;
        this.ILabel5.Visible = false;
        this.ILabel6.Visible = false;
        this.ILabel7.Visible = false;
        this.ILabel8.Visible = false;
        this.ILabel9.Visible = false;
        this.IModelAnswerA.Visible = false;
        this.IModelAnswerB.Visible = false;
        this.IModelAnswerC.Visible = false;
        this.IModelAnswerD.Visible = false;
        this.IModelAnswerF.Visible = false;
        this.IModelAnswerT.Visible = false;
        this.ILabel10.Visible = false;
        this.TFGroupBox.Visible = false;
        this.MCQGroupBox.Visible = false;
    }

    public void ShowTF()
    {
        this.IModelAnswerF.Visible = true;
        this.IModelAnswerT.Visible = true;
        this.ILabel10.Visible = true;
        this.TFGroupBox.Visible = true;
    }

    public void HideTF()
    {
        this.IModelAnswerF.Visible = false;
        this.IModelAnswerT.Visible = false;
        this.ILabel10.Visible = false;
        this.TFGroupBox.Visible = false;
    }
    public void ShowMcq()
    {
        this.IQuestionAnswerA.Visible = true;
        this.IQuestionAnswerB.Visible = true;
        this.IQuestionAnswerC.Visible = true;
        this.IQuestionAnswerD.Visible = true;
        this.ILabel5.Visible = true;
        this.ILabel6.Visible = true;
        this.ILabel7.Visible = true;
        this.ILabel8.Visible = true;
        this.ILabel9.Visible = true;
        this.IModelAnswerA.Visible = true;
        this.IModelAnswerB.Visible = true;
        this.IModelAnswerC.Visible = true;
        this.IModelAnswerD.Visible = true;
        this.MCQGroupBox.Visible = true;
    }
    public void HideMcq()
    {
        this.IQuestionAnswerA.Visible = false;
        this.IQuestionAnswerB.Visible = false;
        this.IQuestionAnswerC.Visible = false;
        this.IQuestionAnswerD.Visible = false;
        this.ILabel5.Visible = false;
        this.ILabel6.Visible = false;
        this.ILabel7.Visible = false;
        this.ILabel8.Visible = false;
        this.ILabel9.Visible = false;
        this.IModelAnswerA.Visible = false;
        this.IModelAnswerB.Visible = false;
        this.IModelAnswerC.Visible = false;
        this.IModelAnswerD.Visible = false;
        this.MCQGroupBox.Visible = false;
    }

    private async void metroSetButton1_Click(object sender, EventArgs e)
    {
        // Question MCQ Entry
        if (!string.IsNullOrEmpty(this.IQuestionHead.Text) && !string.IsNullOrEmpty(this.IQuestionAnswerA.Text) &&
            !string.IsNullOrEmpty(this.IQuestionAnswerB.Text) && !string.IsNullOrEmpty(this.IQuestionAnswerC.Text) &&
            !string.IsNullOrEmpty(this.IQuestionAnswerD.Text))
        {
            if (this.IModelAnswerA.Checked || this.IModelAnswerB.Checked || this.IModelAnswerC.Checked || this.IModelAnswerD.Checked)
            {
                if (this.IQuestionDifficultyEasy.Checked || this.IQuestionDifficultyMedium.Checked || this.IQuestionDifficultyHard.Checked)
                {
                    // Determine the selected difficulty
                    string difficulty = string.Empty;
                    if (this.IQuestionDifficultyEasy.Checked)
                    {
                        difficulty = "Easy";
                    }
                    else if (this.IQuestionDifficultyMedium.Checked)
                    {
                        difficulty = "Medium";
                    }
                    else if (this.IQuestionDifficultyHard.Checked)
                    {
                        difficulty = "Hard";
                    }

                    // Determine the selected model and course
                    string model = string.Empty; // You need to set this based on your logic
                    if (this.IModelAnswerA.Checked)
                    {
                        model = "a";
                    }
                    else if (this.IModelAnswerB.Checked)
                    {
                        model = "b";
                    }
                    else if (this.IModelAnswerC.Checked)
                    {
                        model = "c";
                    }
                    else if (this.IModelAnswerD.Checked)
                    {
                        model = "d";
                    }

                    int QuestionID = _examination_SystemContext.Questions.Max(s => s.QId) + 1;

                    int Course_ID = (int)IComboBoxCourses.SelectedValue;

                    string type = "Mcq";

                    int.TryParse(this.IQuestionGrade.Text, out int Grade);


                    await _spContext.SP_INSERT_QuestionAsync(QuestionID, this.IQuestionHead.Text, Grade, difficulty, type, model, Course_ID);
                    await _spContext.SP_INSERT_Question_ChoicesAsync(QuestionID, this.IQuestionAnswerA.Text, "a");
                    await _spContext.SP_INSERT_Question_ChoicesAsync(QuestionID, this.IQuestionAnswerB.Text, "b");
                    await _spContext.SP_INSERT_Question_ChoicesAsync(QuestionID, this.IQuestionAnswerC.Text, "c");
                    await _spContext.SP_INSERT_Question_ChoicesAsync(QuestionID, this.IQuestionAnswerD.Text, "d");
                    MessageBox.Show("Question inserted successfully");
                }
                else
                {
                    MessageBox.Show("Please select a difficulty level");
                }
            }
            else
            {
                MessageBox.Show("Please select a correct answer");
            }
        }
        // TF Questions
        else if (!string.IsNullOrEmpty(this.IQuestionHead.Text) && (this.IModelAnswerT.Checked || this.IModelAnswerF.Checked))
        {
            if (this.IQuestionDifficultyEasy.Checked || this.IQuestionDifficultyMedium.Checked || this.IQuestionDifficultyHard.Checked)
            {
                // Determine the selected difficulty
                string difficulty = string.Empty;
                if (this.IQuestionDifficultyEasy.Checked)
                {
                    difficulty = "Easy";
                }
                else if (this.IQuestionDifficultyMedium.Checked)
                {
                    difficulty = "Medium";
                }
                else if (this.IQuestionDifficultyHard.Checked)
                {
                    difficulty = "Hard";
                }

                string model = string.Empty; // You need to set this based on your logic
                if (this.IModelAnswerT.Checked)
                {
                    model = "a";
                }
                else if (this.IModelAnswerF.Checked)
                {
                    model = "b";
                }

                int QuestionID = _examination_SystemContext.Questions.Max(s => s.QId) + 1;

                int Course_ID = (int)IComboBoxCourses.SelectedValue;

                string type = "Tf";

                int.TryParse(this.IQuestionGrade.Text, out int Grade);

                await _spContext.SP_INSERT_QuestionAsync(QuestionID, this.IQuestionHead.Text, Grade, difficulty, type, model, Course_ID);
                await _spContext.SP_INSERT_Question_ChoicesAsync(QuestionID, "True", "a");
                await _spContext.SP_INSERT_Question_ChoicesAsync(QuestionID, "False", "b");
                MessageBox.Show("Question inserted successfully");
            }
            else
            {
                MessageBox.Show("You must check for Difficulty Type");
            }
        }
        else
        {
            MessageBox.Show("Please fill in all fields");
        }
    }
}
