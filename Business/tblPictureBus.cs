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
    public class tblPictureBus
    {
        tblPictureData pd = new tblPictureData();

        public DataTable Picture()
        {
            return pd.loadDataTblPicture();
        }
        public DataTable LoadDataPictureByRoll(string roll)
        {
            return pd.LoadDataTblPictureByRoll(roll);
        }

        public DataTable LoadDataPictureByLocationID(int locationID)
        {
            return pd.LoadDataTblPictureByLocationID(locationID);
        }
        public int InsertTblPicture(TblPicture pt)
        {
            return pd.InsertPicture(pt);
        }

        public int UpdateTblPicture(TblPicture pt)
        {
            return pd.UpdatePicture(pt);
        }

        public int DeleteTblPicture(int ID)
        {
            return pd.DeletePicture(ID);
        }
        public DataTable LoadLocationAndpicture()
        {
            return pd.LoadLocationAndpicture();
        }
    }
}
