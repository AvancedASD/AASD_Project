using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;
using AASD_BuisnessLayer.BusinessGateways;
using AASD_BuisnessLayer.Entities;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchBehaviors
{
    // FOr the time being any one of the search class is enough, we will deal with all the search related business functionality here. - Santosh
    public class BingSearch : ISearchBehaviour
    {
        public IList<Result> RetrieveResults(Query request)
        {
            IList<Result> resultList = null;
            try
            {
                if (request != null)
                {
                    BusinessGateway businessGateway = new BusinessGateway();
                    resultList = new List<Result>();
                    resultList = businessGateway.ConsumingBingApi(request);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
            }


            return resultList;

        }
    }
}
