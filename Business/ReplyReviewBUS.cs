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
    public class ReplyReviewBUS
    {
        ReplyReviewData rrdata = new ReplyReviewData();
        public DataTable showReply_By_ReviewID(int IDReview)
        {
            return rrdata.showReply_By_ReviewID(IDReview);
        }

        public int InsertRepylReview(ReplyReview rr)
        {
            return rrdata.InsertRepylReview(rr);
        }

        public int UpdateReplyReview(ReplyReview rr)
        {
            return rrdata.UpdateReplyReview(rr);
        }
    }
}
