using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Public;
namespace DataAccess
{
    public class ReplyReviewData
    {
        DataConnection conn = new DataConnection();
        public DataTable showReply_By_ReviewID(int IDReview)
        {
            return conn.showReply_By_ReviewID(IDReview);
        }

        public int InsertRepylReview(ReplyReview rr)
        {
            int npar = 4;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@IDReview";
            values[0] = rr.IdReview;
            name[1] = "@UserName";
            values[1] = rr.UserName;
            name[2] = "@DateReply";
            values[2] = rr.Date;
            name[3] = "@Content";
            values[3] = rr.Content;

            return conn.InsertRepylReview(name, values, npar);
        }

        public int UpdateReplyReview(Public.ReplyReview rr)
        {
            int id = rr.IdReview;
            string UserName = rr.UserName;
            string date = rr.Date;
            string content = rr.Content;
            return conn.UpdateReplyReview(id, UserName, date, content);
        }
    }
}
