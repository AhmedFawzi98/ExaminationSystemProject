
namespace ExaminationSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ILogger logger = new TxtLogger("ExaminationSystemExceptions.txt");
            try
            {
                LoginContext loginContext = new LoginContext();
                Examination_SystemContext examination_SystemContext = new Examination_SystemContext();
                Examination_SystemContextProcedures spContext = new Examination_SystemContextProcedures(examination_SystemContext);
                ApplicationConfiguration.Initialize();
                Application.Run(new LoginForm(logger, loginContext, examination_SystemContext, spContext));
            }
            catch(Exception ex) 
            {
                logger.Log(ex);
                DialogResult result = MessageBox.Show("an unexpected error occured, the app will close, please contact developer to check", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    return;
            }  
        }
    }
}