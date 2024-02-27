using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.UI
{
    public partial class ExamPage : MetroSetForm
    {
        private readonly ILogger _logger;
        private readonly Examination_SystemContext _examContext;
        private readonly Examination_SystemContextProcedures _spContext;
        private readonly Student _currentStudent;
        private readonly int _examid;
        private readonly BindingSource _bindingSource;
        private readonly Dictionary<string, List<choices>> QuestionChoicesDict;
        private List<char> Answers;
        private int currentIdx;
        private int _CRID;
        public ExamPage(ILogger logger, Examination_SystemContext examContext, Examination_SystemContextProcedures spContext, Student currentStudent, int examid, int cRID)
        {
            InitializeComponent();
            _logger = logger;
            _examContext = examContext;
            _spContext = spContext;
            _currentStudent = currentStudent;
            _examid = examid;
            _bindingSource = new BindingSource();
            QuestionChoicesDict = new Dictionary<string, List<choices>>();
            Answers = new List<char>(Enumerable.Repeat('X', 10));
            currentIdx = 0;
            btnBackMA.Enabled = false;
            _CRID = cRID;
        }

        private async void ExamPage_Load(object sender, EventArgs e)
        {
            var res = await _spContext.SP_Get_Questions_and_Choices_By_ExamIDAsync(_examid);
            _bindingSource.DataSource = res;
            for (int i = 0; i < res.Count; i++)
            {
                if (!QuestionChoicesDict.ContainsKey(res[i].Q_Head))
                    QuestionChoicesDict.Add(res[i].Q_Head, new List<choices>());
                QuestionChoicesDict[res[i].Q_Head].Add(new choices(res[i].Choice_Desc, res[i].Choice_Selector));
            }
            foreach (var pair in QuestionChoicesDict)
                pair.Value.Sort((a, b) => a.Choice_Selector.CompareTo(b.Choice_Selector));

            ControlVisablity();
            AttatchSimpleBinding();
        }

        private void ControlVisablity()
        {
            bool flag = ((SP_Get_Questions_and_Choices_By_ExamIDResult)_bindingSource.Current).Type == "Mcq";
            radioCMA.Visible = flag;
            radioDMA.Visible = flag;

            if (currentIdx == 0)
                btnBackMA.Enabled = false;
            else
                btnBackMA.Enabled = true;

            if (currentIdx == QuestionChoicesDict.Count - 1)
                btnNextMA.Enabled = false;
            else
                btnNextMA.Enabled = true;
        }

        private void AttatchSimpleBinding()
        {
            SP_Get_Questions_and_Choices_By_ExamIDResult current =
                ((SP_Get_Questions_and_Choices_By_ExamIDResult)_bindingSource.Current);

            lblQuestionTypeMA.Text = current.Type;
            lblGradeMA.Text = "Grade: "+current.Q_Grade.ToString();
            lblQuestionheadMA.Text = current.Q_Head;

            radioAMA.Text = QuestionChoicesDict[current.Q_Head][0].Choice_Desc;
            radioBMA.Text = QuestionChoicesDict[current.Q_Head][1].Choice_Desc;

            if (current.Type == "Mcq")
            {
                radioCMA.Text = QuestionChoicesDict[current.Q_Head][2].Choice_Desc;
                radioDMA.Text = QuestionChoicesDict[current.Q_Head][3].Choice_Desc;
            }
        }

        private void btnBackMA_Click(object sender, EventArgs e)
        {
            if (radioAMA.Checked)
                Answers[currentIdx] = 'a';
            else if (radioBMA.Checked)
                Answers[currentIdx] = 'b';
            else if (radioCMA.Checked)
                Answers[currentIdx] = 'c';
            else if (radioDMA.Checked)
                Answers[currentIdx] = 'd';
            else
                Answers[currentIdx] = 'X';

            currentIdx--;

            string curQuestion = ((SP_Get_Questions_and_Choices_By_ExamIDResult)_bindingSource.Current).Q_Head;
            string newQuestion = string.Empty;
            do
            {
                _bindingSource.MovePrevious();
                newQuestion = ((SP_Get_Questions_and_Choices_By_ExamIDResult)_bindingSource.Current).Q_Head;
            } while (curQuestion == newQuestion);
            radioAMA.Checked = false;
            radioBMA.Checked=false;
            radioCMA.Checked=false;
            radioDMA.Checked=false;
            ControlVisablity();
            AttatchSimpleBinding();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNextMA_Click(object sender, EventArgs e)
        {
            if (radioAMA.Checked)
                Answers[currentIdx] = 'a';
            else if (radioBMA.Checked)
                Answers[currentIdx] = 'b';
            else if (radioCMA.Checked)
                Answers[currentIdx] = 'c';
            else if (radioDMA.Checked)
                Answers[currentIdx] = 'd';
            else
                Answers[currentIdx] = 'X';

            currentIdx++;

            string curQuestion = ((SP_Get_Questions_and_Choices_By_ExamIDResult)_bindingSource.Current).Q_Head;
            string newQuestion = string.Empty;
            do
            {
                _bindingSource.MoveNext();
                newQuestion = ((SP_Get_Questions_and_Choices_By_ExamIDResult)_bindingSource.Current).Q_Head;
            } while (curQuestion == newQuestion);
            radioAMA.Checked = false;
            radioBMA.Checked = false;
            radioCMA.Checked = false;
            radioDMA.Checked = false;
            ControlVisablity();
            AttatchSimpleBinding();
        }

        private async void btnSubmitMA_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable AnswersDatatable = GenrateDataTable();
                await _spContext.SP_Submit_AnswersAsync(_examid, _currentStudent.StId, AnswersDatatable);
                OutputParameter<decimal?> Grade=new OutputParameter<decimal?>();
                
                await _spContext.SP_Grade_ExamAsync(_currentStudent.StId, _CRID,_examid, Grade);
                MetroSetMessageBox.Show(this, $"Your Grade is {Grade.Value}%",null,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex) 
            {
                _logger.Log(ex);
            }
        }
        private DataTable GenrateDataTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ans", typeof(string));
            for (int i = 0; i < 10; i++)
            {
                DataRow row = dataTable.NewRow();
                row["ans"] = Answers[i].ToString();
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }
    }
    internal record choices(string Choice_Desc, string Choice_Selector);
}
