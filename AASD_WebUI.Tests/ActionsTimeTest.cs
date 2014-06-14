using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using AASD_WebUI;
using System.Reflection;
using System.Collections.Generic;
using AASD_WebUI.Controllers;

namespace AASD_WebUI.Tests
{
    [TestClass]
    public class ActionsTimeTest
    {
       
        public void ResultListTime()
        {
            SearchResultController target = new SearchResultController();

            var test = target.List();
            Assert.IsNotNull(test);
        }

         [TestMethod]
        public void TimeTest()
        {
            ResultListTime();
        }
    }
}
