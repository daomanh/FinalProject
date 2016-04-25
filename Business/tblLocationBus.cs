using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Public;
using DataAccess;
using System.Data;

namespace Business
{
    public class tblLocationBus
    {
        tblLocationData ld = new tblLocationData();

        public DataTable LoadLocation()
        {
            return ld.loadDataTblLocation();
        }

        public int InsertTblLocation(TblLocation lc)
        {
            return ld.InsertLocation(lc);
        }

        public int UpdateTblLocation(TblLocation lc)
        {
            return ld.Updatelocation(lc);
        }

        public int DeleteTblLocation(int ID)
        {
            return ld.DeleteLocation(ID);
        }
        public DataTable Search_location_by_name(string name)
        {
            return ld.Search_location_by_name(name);
        }

        public DataTable SearchLocationByName_Area(string name, string area)
        {
            return ld.SearchLocationByName_Area(name, area);
        }

        public DataTable Search_location_by_id(int id)
        {
            return ld.Search_location_by_ID(id);
        }
        public DataTable SelectTopID()
        {
            return ld.SelectTopID();
        }
        public DataTable SelectTopNewCreate()
        {
            return ld.SelectTopNewCreate();
        }
        public DataTable SelectTopView()
        {
            return ld.SelectTopView();
        }
        public DataTable SelectTopRate()
        {
            return ld.SelectTopRate();
        }

        public int EditRateLocation(int ID, int Rate)
        {
            return ld.EditRateLocation(ID,Rate);
        }

        public DataTable Viewer_OF_Location(int ID)
        {
            return ld.Viewer_OF_Location(ID);
        }

        public int Update_Viewer(int ID, int Viewer)
        {
            return ld.Update_Viewer(ID, Viewer);
        }
    }
}
