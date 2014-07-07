using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AAASD_TraceLayer.Concrete;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;
using AASD_BuisnessLayer.BusinessGateways;
using AASD_BuisnessLayer.Entities;
using NLog;
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


        public override IList<Filter> GetFilteredData(IList<Result> data, Query request, IList<string> context)
        {
            return base.GetFilteredData(data, request, context);
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
            IEnumerable<Result> unfilteredList1 = new List<Result>();
            Logger lg;
            try
            {
                IList<Result> unfilteredList = this.RetrieveResultsBing(request);
                BusinessGateway businessGateway = new BusinessGateway();
                bool response = businessGateway.PersistResultsToDB(request, unfilteredList);
                contextList = businessGateway.ConsumingFreeBaseApi(request);
                unfilteredList1 = businessGateway.RetrievingUnfilteredResult(request);
                //unfilteredList1 = businessGateway.RetrievingUnfilteredResult<Result>(request);

                //// Need to add the Db Call 

                filteredData = this.GetFilteredData(unfilteredList, request, contextList);

                displayResult = this.DisplayResults(filteredData);
            }
            catch (Exception e)
            {
                LogWriter.Instance.writeException(Convert.ToString(this), Convert.ToString(this.GetType()), e.Message);
                //lg = new Logger();
                //lg.Error("Exception Occured business layer!!!!!! ", e);
            }
            finally
            {
                //lg = lg != null ? new Logger() : lg;
                bool res = (displayResult != null && displayResult.Count > 0) ? true : false;
                if (res)
                {
                    //lg.Trace("tracing business layer successful ");
                    LogWriter.Instance.writeTrace(Convert.ToString(this), Convert.ToString(this.GetType()), "tracing - AASD -Business_Layer- successful");
                }
                else
                {
                    //lg.Trace("tracing business layer ");
                    LogWriter.Instance.writeTrace(Convert.ToString(this), Convert.ToString(this.GetType()), "tracing - AASD -Business_Layer- successful");
                }

            }

            return displayResult;

        }


    }
}