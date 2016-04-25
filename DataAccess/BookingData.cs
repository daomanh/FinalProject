using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Public;


namespace DataAccess
{
    public class BookingData
    {
        DataConnection conn = new DataConnection();
        public DataTable LoadAllBooking() {
            return conn.LoadAllBooking();
        }

        public DataTable selectBookingAndLocation()
        {
            return conn.selectBookingAndLocation();
        }

        public DataTable selectBookingAndLocation_BY_U_ID(int id)
        {
            return conn.selectBookingAndLocation_BY_U_ID(id);
        }

        public int insertBooking(Booking bk)
        {
            int npar = 8;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@U_ID";
            values[0] = bk.U_ID;
            name[1] = "@NameOFcustomer";
            values[1] = bk.NameOFcustomer;
            name[2] = "@Adress";
            values[2] = bk.Adress;
            name[3] = "@Phonenumber";
            values[3] = bk.Phonenumber;
            name[4] = "@Email";
            values[4] = bk.Email;
            name[5] = "@LocationID";
            values[5] = bk.LocationID;
            name[6] = "@NumberPeople";
            values[6] = bk.NumberPeople;
            name[7] = "@DateStart";
            values[7] = bk.DateStart;
            return conn.insertBooking(name, values, npar);
        }

        public int updateBooking(Booking bk)
        {            
            return conn.updateBooking(bk.U_ID,bk.NameOFcustomer,bk.Age,bk.Adress,bk.Phonenumber,bk.Email,bk.LocationID,bk.NumberPeople,bk.Statut,bk.Id);
        }

        public int updateSTTBoking(Booking bk)
        {
            return conn.updateSTTBoking(bk.Id, bk.Statut);
        }
    }
}
