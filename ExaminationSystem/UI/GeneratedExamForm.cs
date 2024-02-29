namespace ExaminationSystem.UI;

public partial class GeneratedExamForm : MetroSetForm
{
    private readonly ILogger _logger;
    private readonly Examination_SystemContextProcedures _spContext;
    private readonly int? _generatedExamId;

    public GeneratedExamForm(ILogger logger, Examination_SystemContextProcedures spContext, int? generatedExamId)
    {
        InitializeComponent();
        _logger = logger;
        _spContext = spContext;
        _generatedExamId = generatedExamId;
    }

    private async void GeneratedExamForm_Load(object sender, EventArgs e)
    {
        await LoadExamDetailGridViwDataSources();
    }
    private async Task LoadExamDetailGridViwDataSources()
    {
        try
        {
            var examDetails = await _spContext.SP_Get_Questions_and_Choices_By_ExamIDAsync(_generatedExamId);

            gridViewExamDetailsf.DataSource = examDetails;
            gridViewExamDetailsf.Columns.Remove("Cr_ID");
            gridViewExamDetailsf.ReadOnly = true;
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during " +
                "Showing the generated exam",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }

    }

    private async void btnDeleteExamf_Click(object sender, EventArgs e)
    {

        try
        {
            await _spContext.SP_DeleteFrom_ExamAsync(_generatedExamId);
            DialogResult result = MetroSetMessageBox.Show(this, $"Exam is deleted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                this.Close();
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            var res = MetroSetMessageBox.Show(this, "Un expected Error has ouccured during " +
                "Deleting the generated exam",
                null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

    private void btnCloseExamdetailsf_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
