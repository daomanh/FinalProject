using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class TblLocation
    {
        private int id;
        private string nameLocation;
        private string area;
        private string locationContent;
        private string user;
        private string dateCreate;
        private string dateUpdate;
        private int viewer;
        private int rate;

        //ctrl+R+E
        public TblLocation(string NameLocation, string Area, string LocationContent, string User,int Rate, int Id)
        {            
            this.nameLocation = NameLocation;
            this.area = Area;
            this.locationContent = LocationContent;
            this.user = User;
            this.rate = Rate;
            this.id = Id;
        }

        public TblLocation(string NameLocation, string Area, string LocationContent,string DateCreate, string User)
        {
            this.nameLocation = NameLocation;
            this.area = Area;
            this.locationContent = LocationContent;
            this.user = User;
            this.dateCreate = DateCreate;
        }

        public TblLocation(int ID, int Rate)
        {
            this.id = ID;            
            this.rate = Rate;
        }

        public TblLocation(string NameLocation)
        {
            this.nameLocation = NameLocation;            
        }

        public TblLocation(int ID)
        {
            this.id = ID;
        }


        public TblLocation()
        {            
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

        public string NameLocation
        {
            get
            {
                return nameLocation;
            }

            set
            {
                nameLocation = value;
            }
        }

        public string Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public string LocationContent
        {
            get
            {
                return locationContent;
            }

            set
            {
                locationContent = value;
            }
        }

        public int Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
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

        public string DateUpdate
        {
            get
            {
                return dateUpdate;
            }

            set
            {
                dateUpdate = value;
            }
        }

        public int Viewer
        {
            get
            {
                return viewer;
            }

            set
            {
                viewer = value;
            }
        }
    }
}
