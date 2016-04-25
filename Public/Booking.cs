using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public
{
    public class Booking
    {
        private int id;

        private int u_ID;
        private string nameOFcustomer;
        private int age;
        private string adress;
        private string phonenumber;
        private string email;

        private int locationID;
        private int numberPeople;
        private string dateStart;
        private string statut;

        public Booking() { }

        public Booking(int Id,string NameOFcustomer, int Age,string Adress,string PhoneNumber,string Email,int LocationID,int NumberPeople,string stt)
        {
            this.id = Id;
            this.nameOFcustomer = NameOFcustomer;
            this.age = Age;
            this.adress = Adress;
            this.phonenumber = PhoneNumber;
            this.email = Email;
            this.locationID = LocationID;
            this.numberPeople = NumberPeople;
            this.statut = stt;
        }

        public Booking(int U_ID,string NameOFcustomer, string Adress, string PhoneNumber, string Email, int LocationID, int NumberPeople,string DateStart, string stt)
        {
            this.u_ID = U_ID;
            this.nameOFcustomer = NameOFcustomer;
            this.adress = Adress;
            this.phonenumber = PhoneNumber;
            this.email = Email;
            this.locationID = LocationID;
            this.numberPeople = NumberPeople;
            this.dateStart = DateStart;
            this.statut = stt;
        }
        
        public Booking(int ID, string STT)
        {
            this.id = ID;
            this.statut = STT;
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

        public string NameOFcustomer
        {
            get
            {
                return nameOFcustomer;
            }

            set
            {
                nameOFcustomer = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string Phonenumber
        {
            get
            {
                return phonenumber;
            }

            set
            {
                phonenumber = value;
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

        public int NumberPeople
        {
            get
            {
                return numberPeople;
            }

            set
            {
                numberPeople = value;
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

        public string DateStart
        {
            get
            {
                return dateStart;
            }

            set
            {
                dateStart = value;
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
    }
}
