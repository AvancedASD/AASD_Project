using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;
using AASD_BuisnessLayer.Entities;
using System.Threading;
using AASD_BuisnessLayer.Enumeration;


namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.FilterBehaviors
{
    //This is just an example. Later we can delete this filter and create new filters- IVAN
    // FOr the time being any one of the search class is enough, we will deal with all the Filter related business functionality here. - Santosh
    public class DataFilter : IFilterBehavior
    {
        //Delete old data
        static bool added = false;

        public IList<Filter> filteredResults = new List<Filter>();
        public IList<Filter> GetFilteredData(IList<Result> data, IList<String> context)
        {

            foreach (Result re in data)
            {
                added = false;
                foreach (String a in context)
                {

                    if (re.Description.Contains(a) && added == false)
                    {
                        filteredResults.Add(new Filter()
                        {
                            Description = re.Description,
                            QueryId = re.QueryId,
                            ResultId = re.ResultId,
                            DisplayUrl = re.DisplayUrl,
                            Title = re.Title,
                            Url = re.Url,
                            ResulType = QueryResultType.Filtered
                        });
                        added = true;
                    }
                    else
                    {
                        Console.WriteLine("miss");

                    }

                }

                //  Console.WriteLine("arun counter :" + counter);
                Console.WriteLine(re.Url + "\n" + re.ResultId + "\n" + re.ResulType + "\n" + re.QueryId + "\n" + re.Description);
            }

            return filteredResults;

        }

    }
}
