using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class ReplyReview
    {
        private int id;
        private int idReview;
        private string userName;
        private string date;
        private string content;
        
        
        public ReplyReview(int IDReview, string UserName, string Date, string Content)
        {
            this.idReview = IDReview;
            this.UserName = UserName;
            this.date = Date;
            this.content = Content;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdReview
        {
            get
            {
                return idReview;
            }

            set
            {
                idReview = value;
            }
        }



        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
    }
}
