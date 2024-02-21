
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
                ApplicationConfiguration.Initialize();
                Application.Run(new LoginForm(logger, loginContext));
            }
            catch(Exception ex) 
            {
                logger.Log(ex);
                DialogResult result = MessageBox.Show("sorry, an unexpected error occured, the app will close, please contact developer to check", "unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                    return;
            }  
        }
    }
}