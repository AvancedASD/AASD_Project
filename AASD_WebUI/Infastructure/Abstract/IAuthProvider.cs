using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AASD_WebUI.Infastructure.Abstract
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}