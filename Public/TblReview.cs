using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class TblReview
    {
        private int id;
        private int locationID;
        private int u_ID;
        private string dateCreate;
        private string reviewContent;

        public TblReview() { }

        public TblReview(int LocationID, int U_ID,string DateReview, string ReviewContent) {
            this.locationID = LocationID;
            this.u_ID = U_ID;
            this.dateCreate = DateReview;
            this.reviewContent = ReviewContent;
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

        public int LocationID
        {
            get
            {
                return locationID;
            }

            set
            {
                locationID = value;
            }
        }

        public int U_ID
        {
            get
            {
                return u_ID;
            }

            set
            {
                u_ID = value;
            }
        }

        public string ReviewContent
        {
            get
            {
                return reviewContent;
            }

            set
            {
                reviewContent = value;
            }
        }

        public string DateCreate
        {
            get
            {
                return dateCreate;
            }

            set
            {
                dateCreate = value;
            }
        }
    }
}