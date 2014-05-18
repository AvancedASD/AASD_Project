﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchEngines;
using AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.FilterBehaviors;
using AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchBehaviors;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;


namespace AASD_BuisnessLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //DbManager dbManage = new DbManager

            SearchFactory searchFactory = new SearchFactory();
            ISearchBehaviour bingSearch = searchFactory.getSearch("Bing");

            string request = "Microsoft products";
            SearchEngine fullSearchEngine = new SearchEngine_Standart(new DateFilter(), bingSearch);
            object unfilteredData = fullSearchEngine.GetResults(request);
            //dbManage.PersistData

            object filteredData = fullSearchEngine.FilterData(unfilteredData);
            
            //fullSearchEngine.search = new GoogLe
            fullSearchEngine.filter = new DuplicateDataFilter();
            filteredData = fullSearchEngine.FilterData(filteredData);

            fullSearchEngine.filter = new RelevanceFilter();
            filteredData = fullSearchEngine.FilterData(filteredData);

            fullSearchEngine.search = new NeuralNetworkSearch();
            filteredData = fullSearchEngine.GetResults(request);

            
        }
    }
}
