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
    public class tblUserBus
    {
        tblUserData Ud = new tblUserData();

        public DataTable LoadUser()
        {
            return Ud.loadDataUser();
        }

        public int InsertUser(TblUser us)
        {
            return Ud.InsertUser(us);
        }

        public int UpdateUser(TblUser us)
        {
            return Ud.UpdateUser(us);
        }

        public int DeleteUser(TblUser us)
        {
            return Ud.DeleteUser(us);
        }

        public bool Login(string a, string b)
        {
            return Ud.Login(a,b);
        }

        public DataTable Login2(string a, string b)
        {
            return Ud.Login2(a, b);
        }

        public DataTable selectUserByID(int id)
        {
            return Ud.selectUserByID(id);
        }
    }
}
