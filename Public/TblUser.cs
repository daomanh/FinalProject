using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class TblUser
    {
        private int id;
        private string username;
        private string pass;
        private string fullname;
        private string phoneNumber;
        private string gender;
        private string email;
        private string addres;
        private string roll;
        
        public TblUser() { }

        public TblUser(string UserName, string Pass, string Fullname, string Phone, string Gender, string Email, string Addresss, string Roll)
        {
            this.username = UserName;
            this.pass = Pass;
            this.fullname = Fullname;
            this.phoneNumber = Phone;
            this.gender = Gender;
            this.email = Email;
            this.addres = Addresss;            
            this.roll = Roll;
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

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Fullname
        {
            get
            {
                return fullname;
            }

            set
            {
                fullname = value;
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

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
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

        public string Addres
        {
            get
            {
                return addres;
            }

            set
            {
                addres = value;
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
