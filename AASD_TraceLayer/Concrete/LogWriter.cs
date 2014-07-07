using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AAASD_TraceLayer.Abstract;
using NLog;
using System.Globalization;

///Created by Arun & Santosh
namespace AAASD_TraceLayer.Concrete
{
    public class LogWriter : IExceptionLogger, ITraceLogger
    {
        private static LogWriter instance;
        String TraceFileName = "Traces.txt";
        string folderName = @"c:\AASD_Logs";
        String ExceptionFileName = "Exceptions.txt";
        string tracePath;
        string exceptionFilePath;
        StreamWriter writeTraceLines;
        StreamWriter writeExceptionLines;

        private LogWriter()
        {
            System.IO.Directory.CreateDirectory(folderName);
            tracePath = System.IO.Path.Combine(folderName, TraceFileName);
            exceptionFilePath = System.IO.Path.Combine(folderName, ExceptionFileName);
        }

        public static LogWriter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogWriter();
                }
                return instance;
            }
        }

        public void writeException(String fileName, String methodName, String message)
        {
            if (!File.Exists(exceptionFilePath))
            {
                File.Create(exceptionFilePath);
            }
            writeExceptionLines = File.AppendText(exceptionFilePath);
            writeExceptionLines.WriteLine();
            writeExceptionLines.WriteLine("---------------------------------Start of Exception---------------------------------------------------------");
            writeExceptionLines.WriteLine(Convert.ToString(DateTime.UtcNow, CultureInfo.CurrentCulture) + ":**Exception File Initialized**");
            writeExceptionLines.WriteLine("------------------------------------------------------------------------------------------------------");
            writeExceptionLines.WriteLine(Convert.ToString(DateTime.UtcNow, CultureInfo.CurrentCulture) + ":" + fileName + ":" + methodName + "():" + message);
            writeExceptionLines.WriteLine("----------------------------------------END of Exception----------------------------------------------");
            writeExceptionLines.WriteLine();
            writeExceptionLines.Close();
        }
        public void writeTrace(String fileName, String methodName, String message)
        {
            if (!File.Exists(tracePath))
            {
                File.Create(tracePath);

            }
            writeTraceLines = File.AppendText(tracePath);
            writeTraceLines.WriteLine();
            writeTraceLines.WriteLine("---------------------------------Start of trace---------------------------------------------------------");
            writeTraceLines.WriteLine(Convert.ToString(DateTime.UtcNow, CultureInfo.CurrentCulture) + ":**Trace File Initialized**");
            writeTraceLines.WriteLine("--------------------------------------------------------------------------------------------------------");
            writeTraceLines.WriteLine(Convert.ToString(DateTime.UtcNow, CultureInfo.CurrentCulture) + ":" + fileName + ":" + methodName + "():" + message);
            writeTraceLines.WriteLine("-----------------------------------------End of Trace------------------------------------------------------");
            writeTraceLines.WriteLine();
            writeTraceLines.Close();
        }
    }
}