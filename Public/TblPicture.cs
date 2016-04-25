using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class TblPicture
    {
        private int id;
        private int locationID;
        private string picName;
        private string picUrl;
        private string statut;
        private string roll;
        public TblPicture(int LocationID, string PicName, string PicUrl, string Statut, string Roll  )
        {
            this.locationID = LocationID;
            this.picName = PicName;
            this.picUrl = PicUrl;
            this.statut = Statut;
            this.roll = Roll;              
        }

        public TblPicture(int ID)
        {
            this.id = ID;
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

        public string PicName
        {
            get
            {
                return picName;
            }

            set
            {
                picName = value;
            }
        }

        public string PicUrl
        {
            get
            {
                return picUrl;
            }

            set
            {
                picUrl = value;
            }
        }

        public string Statut
        {
            get
            {
                return statut;
            }

            set
            {
                statut = value;
            }
        }

        public string Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }
    }
}
