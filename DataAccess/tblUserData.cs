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
    public class tblUserData
    {
        DataConnection conn = new DataConnection();
        public DataTable loadDataUser()
        {
            return conn.LoadUser();
        }

        public int InsertUser(TblUser Us)
        {
            int npar = 8;
            string[] name = new string[npar];
            object[] values = new object[npar];

            name[0] = "@Username";
            values[0] = Us.Username;
            name[1] = "@Pass";
            values[1] = Us.Pass;
            name[2] = "@Fullname";
            values[2] = Us.Fullname;
            name[3] = "@PhoneNumber";
            values[3] = Us.PhoneNumber;
            name[4] = "@Gender";
            values[4] = Us.Gender;
            name[5] = "@Email";
            values[5] = Us.Email;
            name[6] = "@Addres";
            values[6] = Us.Addres;
            name[7] = "@Roll";
            values[7] = Us.Roll;

            return conn.InsertUser(name, values, npar);
        }

        public int UpdateUser(TblUser Us)
        {
            string Username = Us.Username;
            string Pass = Us.Pass;
            string Fullname = Us.Fullname;
            string PhoneNumber = Us.PhoneNumber;
            string Gender = Us.Gender;
            string Email = Us.Email;
            string Addres = Us.Addres;
            string Roll = Us.Roll;            
            int id = Us.Id;

            return conn.EditUser(Username, Pass, Fullname, PhoneNumber, Gender, Email, Addres,Roll, id);
        }

        public int DeleteUser(TblUser Us)
        {
            int id = Us.Id;
            return conn.DeleteUser(id);
        }

        public bool Login(string a, string b)
        {
            return conn.Login(a, b);
        }

        public DataTable Login2(string a, string b)
        {
            return conn.Login2(a, b);
        }

        public DataTable selectUserByID(int id)
        {
            return conn.selectUserByID(id);
        }
    }
}

