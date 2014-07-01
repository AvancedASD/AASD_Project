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
using AASD_WebUI.Proxy;

namespace AASD_WebUI.ControllersTest.SearchResultTest
{
    [TestClass]
    public class ListTest
    {

        private IEnumerable<ResultContract> _listResultContract;
        [TestInitialize]
        public void PreTestInitialize()
        {
            _listResultContract = new ResultContract[] {
            new ResultContract()
            {
                Description="XXX", DisplayUrl = "google.com", Title = "Hot", Url = "www.google.com"
            },
            new ResultContract() 
             {
                 Description="GOD", DisplayUrl = "jesus.com", Title = "Pray", Url = "www.jesus.com"}  
             };
        }

        private SearchResultController GetController()
        {
            Mock<IAASDService> wcfMock = new Mock<IAASDService>();
            wcfMock.Setup(s => s.RetrieveSearch(It.IsAny<RetrieveSearchRequest1>())).
                Returns(
                () =>
                {
                    System.Threading.Thread.Sleep(10);
                    return new RetrieveSearchResponse()
                    {
                        listResultContract = _listResultContract.ToArray()
                    };
                });
            SearchResultController controller = new SearchResultController(wcfMock.Object);
            return controller;
        }

        [TestMethod]
        public void TestListAction()
        {
            SearchResultController controller = GetController();
            ActionResult result = controller.List("test");
            Assert.IsNotNull(result);
        }
    }
}
