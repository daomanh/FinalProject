using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using Public;

namespace Business
{
    public class TblContactBus
    {
        TblContactData tcd = new TblContactData();

        public DataTable LoadAllContact()
        {
            return tcd.LoadAllContact();
        }

        public DataTable Load_Contact_NOREAD()
        {
            return tcd.Load_Contact_NOREAD();
        }

        public DataTable Load_Contact_READ_NO_REPLY()
        {

            return tcd.Load_Contact_READ_NO_REPLY();
        }

        public DataTable Load_Contact_REPLY()
        {

            return tcd.Load_Contact_REPLY();
        }

        public int INSERT_CONTACT(TblContact tblCT)
        {
            return tcd.INSERT_CONTACT(tblCT);
        }

        public int UPDATE_CONTACT(string STT, int ID)
        {
            return tcd.UPDATE_CONTACT(STT, ID);
        }
    }
}
