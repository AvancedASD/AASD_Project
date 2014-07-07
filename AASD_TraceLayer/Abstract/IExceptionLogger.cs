using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Created by Arun
namespace AAASD_TraceLayer.Abstract
{
    public interface IExceptionLogger
    {
        void writeException(String fileName, String methodName, String message);
    }
}
