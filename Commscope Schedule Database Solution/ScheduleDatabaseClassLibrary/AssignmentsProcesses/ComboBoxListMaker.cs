using ScheduleDatabaseClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ScheduleDatabaseClassLibrary.AssignmentsProcesses
{
    public class ComboBoxListMaker
    {
        List<object> fullList = null;
        public List<object> FullList  
        {
            get
            {
                return fullList;
            }            
        }
        public ComboBoxListMaker()
        {
            fullList = new List<object>();
            List<MSO_Model> msoList = new List<MSO_Model>();
            msoList = GlobalConfig.Connection.MSO_GetAll();
            msoList.Insert(0, new MSO_Model());
            fullList.Add(msoList);
            List<ActivityModel> activityList = GlobalConfig.Connection.Activity_GetAll();
            activityList.Insert(0, new ActivityModel());
            fullList.Add(activityList);
            List<FE_Model> feList = GlobalConfig.Connection.FE_GetAll();
            feList.Insert(0, new FE_Model());
            fullList.Add(feList);
            List<CityModel> cityList = GlobalConfig.Connection.GenericGetAll<CityModel>("tblCities");
            cityList.Insert(0, new CityModel());
            fullList.Add(cityList);
            List<StateModel> stateList = GlobalConfig.Connection.GenericGetAll<StateModel>("tblStates");
            stateList.Insert(0, new StateModel());
            fullList.Add(stateList);
            List<CountriesModel> countryList = GlobalConfig.Connection.Countries_GetAll();
            countryList.Insert(0, new CountriesModel());
            fullList.Add(countryList);
            List<RegionsModel> regionList = GlobalConfig.Connection.GenericGetAll< RegionsModel>("tblRegions");
            regionList.Insert(0, new RegionsModel());
            fullList.Add(regionList);
            List<RequestorModel> requestorList = GlobalConfig.Connection.GenericGetAll<RequestorModel>("tblSalespersons");
            requestorList.Insert(0, new RequestorModel());
            fullList.Add(requestorList);
            List<ProductModel> productList = GlobalConfig.Connection.GenericGetAll< ProductModel>("tblProducts");
            productList.Insert(0, new ProductModel());
            fullList.Add(productList);
        }
    }
}
