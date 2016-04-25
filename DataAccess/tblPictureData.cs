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
    public class tblPictureData
    {
        DataConnection conn = new DataConnection();
        public DataTable loadDataTblPicture()
        {
            return conn.LoadPicture();
        }

        public DataTable LoadDataTblPictureByLocationID(int locationID)
        {
            return conn.LoadPictureByLocationID(locationID);
        }

        public DataTable LoadDataTblPictureByRoll(string roll)
        {            
            return conn.LoadPictureByRoll(roll);
        }
        public int InsertPicture(TblPicture Pt)
        {
            int npar = 5;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@LocationID";
            values[0] = Pt.LocationID;
            name[1] = "@PicName";
            values[1] = Pt.PicName;
            name[2] = "@PicUrl";
            values[2] = Pt.PicUrl;
            name[3] = "@Statut";
            values[3] = Pt.Statut;
            name[4] = "@Roll";
            values[4] = Pt.Roll;
            return conn.InsertPicture(name, values, npar);
        }

        public int UpdatePicture(TblPicture Pt)
        {
            int LocationID = Pt.LocationID;
            string PicName = Pt.PicName;
            string PicUrl = Pt.PicUrl;
            int id = Pt.Id;

            return conn.EditPicture(LocationID, PicName, PicUrl, id);
        }

        public int DeletePicture(int id)
        {            
            return conn.DeletePicture(id);
        }

        public DataTable LoadLocationAndpicture()
        {
            return conn.LoadAllLocationAndPicture();
        }
    }
}
