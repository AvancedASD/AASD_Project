using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAASD_TraceLayer.Abstract
{
    public interface ITraceLogger
    {
        void writeTrace(String fileName, String methodName, String message);
    }
}
