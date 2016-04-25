using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Public;
namespace DataAccess
{
    public class tblLocationData
    {
        DataConnection conn = new DataConnection();
        public DataTable loadDataTblLocation()
        {
            return conn.LoadLocation();
        }

        public int InsertLocation(TblLocation lt)
        {
            int npar = 5;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@NameLocation";
            values[0] = lt.NameLocation;
            name[1] = "@Area";
            values[1] = lt.Area;
            name[2] = "@LocationContent";
            values[2] = lt.LocationContent;
            name[3] = "@Username";
            values[3] = lt.User;
            name[4] = "@DateCreate";
            values[4] = lt.DateCreate;


            return conn.InsertLocation(name, values, npar);
        }

        public int Updatelocation(TblLocation lt)
        {
            string NameLocation = lt.NameLocation;
            string Area = lt.Area;
            string LocationContent = lt.LocationContent;         
            string user = lt.User;
            string dateupdate = lt.DateUpdate;
            int id = lt.Id;

            return conn.EditLocation(NameLocation, Area, LocationContent, user,dateupdate, id);
        }

        public int DeleteLocation(int ID)
        {
            return conn.DeleteLocation(ID);
        }

        public DataTable Search_location_by_name(string name)
        {
            string nameLocation = name;
            return conn.Search_Location_by_Name(nameLocation);
        }

        public DataTable SearchLocationByName_Area(string name, string area)
        {            
            return conn.SearchLocationByName_Area(name,area);
        }

        public DataTable Search_location_by_ID(int id)
        {
            
            return conn.Searchr_Location_by_ID(id);
        }

        public DataTable SelectTopID()
        {
            return conn.selectTopTableID();
        }

        public DataTable SelectTopNewCreate()
        {
            return conn.selectTopNewCreate();
        }

        public DataTable SelectTopView()
        {
            return conn.selectTopView();
        }

        public DataTable SelectTopRate()
        {
            return conn.selectTopRate();
        }

        public int EditRateLocation(int ID, int Rate)
        {
            return conn.EditRateLocation(ID, Rate);
        }

        public DataTable Viewer_OF_Location(int ID)
        {
            return conn.Viewer_OF_Location(ID);
        }

        public int Update_Viewer(int ID, int Viewer)
        {
            return conn.Update_Viewer(ID, Viewer);
        }
    }
}
