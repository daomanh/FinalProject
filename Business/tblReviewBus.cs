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
    public class tblReviewBus
    {
        tblReviewData Rd = new tblReviewData();

        public DataTable LoadReview()
        {
            return Rd.loadDataReview();
        }
        public DataTable LoadCountReview()
        {
            return Rd.LoadCountReview();
        }

        public DataTable LoadReviewByLocationID(int id)
        {
            return Rd.loadDataReviewByLocationID(id);
        }

        public DataTable LoadReviewByLocationID_NOTREPLY(int id)
        {
            return Rd.loadDataReviewByLocationID_NOTREPLY(id);
        }

        public DataTable ViewAllTblReviewByLocationID_Reply(int id)
        {
            return Rd.ViewAllTblReviewByLocationID_Reply(id);
        }

        public DataTable LoadReviewByID(int id)
        {
            return Rd.LoadReviewByID(id);
        }

        public int InsertTblReview(TblReview rv)
        {
            return Rd.InsertReview(rv);
        }

        public int UpdateTblReview(TblReview rv)
        {
            return Rd.UpdateReview(rv);
        }

        public int UpdateSTTTblReview(string stt,int id)
        {
            return Rd.UpdateSTTReview(id, stt);
        }

        public int DeleteTblReview(TblReview rv)
        {
            return Rd.DeleteReview(rv);
        }
    }
}
