using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class TblContact
    {
        private int id;
        private string name;
        private string email;
        private string phoneNumber;
        private string mesage;
        private string stt;

        public TblContact() { }

        public TblContact(string Name, string Email, string PhoneNumber, string Mesage,string STT)
        {
            this.name = Name;
            this.email = Email;
            this.phoneNumber = PhoneNumber;
            this.mesage = Mesage;
            this.stt = STT;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Mesage
        {
            get
            {
                return mesage;
            }

            set
            {
                mesage = value;
            }
        }

        public string Stt
        {
            get
            {
                return stt;
            }

            set
            {
                stt = value;
            }
        }
    }
}
