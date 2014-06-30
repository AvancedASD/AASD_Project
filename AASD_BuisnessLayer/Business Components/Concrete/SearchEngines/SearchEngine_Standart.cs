using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;
using AASD_BuisnessLayer.BusinessGateways;
using AASD_BuisnessLayer.Entities;
//using AASD_FreeBaseServiceAgent;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchEngines
{
    //Later we can add some sepcific functionality
    public class SearchEngine_Standart : SearchEngine
    {

        public override IList<Result> RetrieveResultsBing(Query request)
        {
            return base.RetrieveResultsBing(request);
        }


        public override IList<Filter> GetFilteredData(IList<Result> data, IList<string> context)
        {
            return base.GetFilteredData(data, context);
        }

        public override IList<Display> DisplayResults(IList<Filter> filteredResult)
        {
            return base.DisplayResults(filteredResult);
        }

        public IList<Display> ExecutingSearchEngine(Query request)
        {
            IList<Display> displayResult = null;
            IList<string> contextList = null;
            IList<Filter> filteredData = null;
            try
            {
                IList<Result> unfilteredList = this.RetrieveResultsBing(request);
                BusinessGateway businessGateway = new BusinessGateway();
                //bool response = businessGateway.PersistResultsToDB(unfilteredList);
                contextList = businessGateway.ConsumingFreeBaseApi(request);
                //unfilteredList = businessGateway.RetrievingUnfilteredResult(request);

                //// Need to add the Db Call 

                //filteredData = this.GetFilteredData(unfilteredList, contextList);

                //displayResult = this.DisplayResults(filteredData);
            }
            catch (Exception e)
            {
                throw e;
            }

            return displayResult;

        }


    }
}