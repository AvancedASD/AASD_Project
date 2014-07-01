using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AAASD_TraceLayer.Abstract;

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
            if (!File.Exists(tracePath))
            {
                File.Create(tracePath);

            }

            writeTraceLines = File.AppendText(tracePath);
            writeTraceLines.WriteLine(DateTime.Now + ":**Trace File Initialized**");

            if (!File.Exists(exceptionFilePath))
            {
                File.Create(exceptionFilePath);
            }
            writeExceptionLines = File.AppendText(exceptionFilePath);
            writeExceptionLines.WriteLine(DateTime.Today + ":**Exception File Initialized**");

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
            writeExceptionLines = File.AppendText(ExceptionFileName);
            writeExceptionLines.WriteLine(DateTime.Today + ":" + fileName + ":" + methodName + "():" + message);
            writeExceptionLines.Close();
        }
        public void writeTrace(String fileName, String methodName, String message)
        {
            writeTraceLines = File.AppendText(TraceFileName);
            writeTraceLines.WriteLine(DateTime.Today + ":" + fileName + ":" + methodName + "():" + message);
            writeTraceLines.Close();
        }
    }
}