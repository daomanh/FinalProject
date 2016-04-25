using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Public;

namespace DataAccess
{
    public class TblContactData
    {
        DataConnection conn = new DataConnection();
        public DataTable LoadAllContact()
        {
            return conn.LoadAllContact();
        }

        public DataTable Load_Contact_NOREAD()
        {
            return conn.Load_Contact_NOREAD();
        }

        public DataTable Load_Contact_READ_NO_REPLY()
        {

            return conn.Load_Contact_READ_NO_REPLY();
        }

        public DataTable Load_Contact_REPLY()
        {
           
            return conn.Load_Contact_REPLY();
        }

        public int INSERT_CONTACT(TblContact tblCT)
        {
            int npar = 5;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@Name";
            values[0] = tblCT.Name;
            name[1] = "@Email";
            values[1] = tblCT.Email;
            name[2] = "@PhoneNumber";
            values[2] = tblCT.PhoneNumber;
            name[3] = "@Mesage";
            values[3] = tblCT.Mesage;
            name[4] = "@STT";
            values[4] = tblCT.Stt;

            return conn.INSERT_CONTACT(name, values, npar);
        }

        public int UPDATE_CONTACT(string STT, int ID)
        {
            return conn.UPDATE_CONTACT(ID,STT);
        }
    }
}
