namespace Logging;
public class TxtLogger : ILogger
{
    private string _loggingFileName;

    public TxtLogger(string loggingFileName)
    {
        _loggingFileName = loggingFileName;
    }

    public void Log(Exception ex)
    {
            string logMessage = $"""


                                on {DateTime.Now} an unhandled exception was thrown,

                                exception message: {ex.Message},

                                with the following stack trace: {ex.StackTrace}


                                """;
           File.AppendAllText(_loggingFileName, logMessage);
    }
}