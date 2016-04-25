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
    public class BookingBus
    {
        BookingData bd = new BookingData();

        public DataTable LoadAllBooking()
        {
            return bd.LoadAllBooking();
        }

        public DataTable selectBookingAndLocation()
        {
            return bd.selectBookingAndLocation();
        }

        public DataTable selectBookingAndLocation_BY_U_ID(int id)
        {
            return bd.selectBookingAndLocation_BY_U_ID(id);
        }

        public int insertBooking(Booking bk)
        {            
            return bd.insertBooking(bk);
        }

        public int updateBooking(Booking bk)
        {
            return bd.updateBooking(bk);
        }

        public int updateSTTBoking(Booking bk)
        {
            return bd.updateSTTBoking(bk);
        }
    }
}
