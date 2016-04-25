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
    public class tblReviewData
    {
        DataConnection conn = new DataConnection();
        public DataTable loadDataReview()
        {
            return conn.LoadReview();
        }

        public DataTable loadDataReviewByLocationID(int id)
        {
            return conn.LoadReviewByLocationID(id);
        }

        public DataTable loadDataReviewByLocationID_NOTREPLY(int id)
        {
            return conn.LoadReviewByLocationID_NOTREPLY(id);
        }

        public DataTable ViewAllTblReviewByLocationID_Reply(int id)
        {
            return conn.ViewAllTblReviewByLocationID_Reply(id);
        }

        public DataTable LoadReviewByID(int ID)
        {
            return conn.LoadReviewByID(ID);
        }

        public DataTable LoadCountReview()
        {
            return conn.LoadCount();
        }

        public int InsertReview(TblReview Rv)
        {
            int npar = 4;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@LocationID";
            values[0] = Rv.LocationID;
            name[1] = "@U_ID";
            values[1] = Rv.U_ID;
            name[2] = "@DateReview";
            values[2] = Rv.DateCreate;
            name[3] = "@ReviewContent";
            values[3] = Rv.ReviewContent;

            return conn.InsertReview(name, values, npar);
        }

        public int UpdateReview(TblReview Rv)
        {
            int LocationID = Rv.LocationID;
            int U_ID = Rv.U_ID;
            string ReviewContent = Rv.ReviewContent;
            int id = Rv.Id;

            return conn.EditReview(LocationID, U_ID, ReviewContent, id);
        }

        public int UpdateSTTReview(int id, string stt)
        {
            return conn.EditSTTReview(stt,id);
        }

        public int DeleteReview(TblReview Rv)
        {
            int id = Rv.Id;
            return conn.DeleteReview(id);
        }
    }
}
