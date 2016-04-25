using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{

    public class DataConnection
    {
        SqlConnection conn = new SqlConnection();
        public DataConnection()
        {
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Vietnam_Tourism_2"].ConnectionString;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //TBLArea
        public DataTable LoadArea()
        {
            SqlCommand cmd = new SqlCommand("AllArea", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        //TblLocation
        public DataTable LoadLocation()
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblLocation", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }
        //insert location
        public int InsertLocation(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("InsertTblLocation", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }
        //edit location
        public int EditLocation(string NameLocation, string Area, string LocationContent, string User, string dateupdate, int id)
        {

            SqlCommand cmd = new SqlCommand("UpdateTblLocation", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("NameLocation", NameLocation);
            cmd.Parameters.AddWithValue("Area", Area);
            cmd.Parameters.AddWithValue("LocationContent", LocationContent);
            cmd.Parameters.AddWithValue("Username", User);
            cmd.Parameters.AddWithValue("DateUpdate", dateupdate);
            cmd.Parameters.AddWithValue("ID", id);

            return cmd.ExecuteNonQuery();
        }
        //delete location
        public int DeleteLocation(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteTblLocation", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);

            return cmd.ExecuteNonQuery();
        }
        //search by name
        public DataTable Search_Location_by_Name(string name)
        {
            SqlCommand cmd = new SqlCommand("SearchLocationByName", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("NameLocation", name);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable SearchLocationByName_Area(string name,string area)
        {
            SqlCommand cmd = new SqlCommand("SearchLocationByName_Area", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("NameLocation", name);
            cmd.Parameters.AddWithValue("Area", area);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable Searchr_Location_by_ID(int ID)
        {
            SqlCommand cmd = new SqlCommand("SearchLocationByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", ID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable selectTopTableID()
        {
            SqlCommand cmd = new SqlCommand("SelectTopID", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable selectTopNewCreate()
        {
            SqlCommand cmd = new SqlCommand("SelectTopNews", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable selectTopView()
        {
            SqlCommand cmd = new SqlCommand("SelectTopViewer", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable selectTopRate()
        {
            SqlCommand cmd = new SqlCommand("SelectTopRate", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public int EditRateLocation(int id, int rate)
        {
            SqlCommand cmd = new SqlCommand("updateRate", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Rate", rate);
            cmd.Parameters.AddWithValue("ID", id);

            return cmd.ExecuteNonQuery();
        }

        public DataTable Viewer_OF_Location(int ID)
        {
            SqlCommand cmd = new SqlCommand("Viewer_OF_Location", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", ID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int Update_Viewer(int ID, int Viewer)
        {
            SqlCommand cmd = new SqlCommand("Update_Viewer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Viewer", Viewer);
            cmd.Parameters.AddWithValue("ID", ID);

            return cmd.ExecuteNonQuery();
        }


        //-----------------------------------//
        //Picture
        public DataTable LoadPicture()
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblPicture", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable LoadPictureByRoll(string roll)
        {
            SqlCommand cmd = new SqlCommand("ViewTblPictureByRoll", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Roll", roll);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable LoadPictureByLocationID(int LocationID)
        {
            SqlCommand cmd = new SqlCommand("ViewTblPictureByLocationID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("LocationID", LocationID);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public int InsertPicture(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("InsertTblPicture", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public int EditPicture(int LocationID, string PicName, string PicUrl, int id)
        {

            SqlCommand cmd = new SqlCommand("UpdateCruise", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("LocationID", LocationID);
            cmd.Parameters.AddWithValue("PicName", PicName);
            cmd.Parameters.AddWithValue("PicUrl", PicUrl);

            return cmd.ExecuteNonQuery();
        }

        public int DeletePicture(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteTblPicture", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);

            return cmd.ExecuteNonQuery();
        }

        public DataTable LoadAllLocationAndPicture()
        {
            SqlCommand cmd = new SqlCommand("SelecttblLocationANDTblPicture", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }
        //------------------------------------//

        //TblReview
        public DataTable LoadReview()
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblReview", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }


        public DataTable LoadReviewByLocationID(int id)
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblReviewByLocationID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("LocationID", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable LoadReviewByLocationID_NOTREPLY(int id)
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblReviewByLocationID_NOTREPLY", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("LocationID", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable ViewAllTblReviewByLocationID_Reply(int id)
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblReviewByLocationID_Reply", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("LocationID", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable LoadReviewByID(int id)
        {
            SqlCommand cmd = new SqlCommand("showContentByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable LoadCount()
        {
            SqlCommand cmd = new SqlCommand("countReviewOFLocation", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }
        public int InsertReview(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("InsertTblReview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public int EditReview(int LocationID, int U_ID, string ReviewContent, int id)
        {

            SqlCommand cmd = new SqlCommand("UpdateTblReview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("LocationID", LocationID);
            cmd.Parameters.AddWithValue("U_ID", U_ID);
            cmd.Parameters.AddWithValue("ReviewContent", ReviewContent);

            return cmd.ExecuteNonQuery();
        }

        public int EditSTTReview(string stt, int id)
        {
            SqlCommand cmd = new SqlCommand("UpdateSTTTblReview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("ReviewStt", stt);

            return cmd.ExecuteNonQuery();
        }

        public int DeleteReview(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteTblReview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);

            return cmd.ExecuteNonQuery();
        }

        //------------------------------------//

        //Reply Review
        public DataTable showReply_By_ReviewID(int IDReview)
        {
            SqlCommand cmd = new SqlCommand("showReply_By_ReviewID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("IDReview", IDReview);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int InsertRepylReview(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("InsertRepylReview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public int UpdateReplyReview(int id, string UserName, string Date, string Content)
        {

            SqlCommand cmd = new SqlCommand("UpdateReplyReview", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("IDRep", id);
            cmd.Parameters.AddWithValue("UserName", UserName);
            cmd.Parameters.AddWithValue("DateReply", Date);
            cmd.Parameters.AddWithValue("Content", Content);

            return cmd.ExecuteNonQuery();
        }

        //------------------------------------//

        //tblUser
        public DataTable LoadUser()
        {
            SqlCommand cmd = new SqlCommand("ViewAllTblUser", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable selectUserByID(int id)
        {
            SqlCommand cmd = new SqlCommand("selectUserByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        public int InsertUser(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("InsertTblUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public int EditUser(string Username, string Pass, string Fullname, string PhoneNumber, string Gender, string Email, string Addres, string Roll, int id)
        {

            SqlCommand cmd = new SqlCommand("UpdateTblUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("Username", Username);
            cmd.Parameters.AddWithValue("Pass", Pass);
            cmd.Parameters.AddWithValue("Fullname", Fullname);
            cmd.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
            cmd.Parameters.AddWithValue("Gender", Gender);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("Addres", Addres);
            cmd.Parameters.AddWithValue("Roll", Roll);

            return cmd.ExecuteNonQuery();
        }

        public int DeleteUser(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteTblUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);

            return cmd.ExecuteNonQuery();
        }

        public bool Login(string username, string pass)
        {
            SqlCommand cmd = new SqlCommand("LoginUSer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Username", username);
            cmd.Parameters.AddWithValue("Pass", pass);
            bool stt = false;
            stt = Convert.ToBoolean(cmd.ExecuteScalar());
            return stt;
        }

        public DataTable Login2(string username, string pass)
        {
            SqlCommand cmd = new SqlCommand("LoginUSer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Username", username);
            cmd.Parameters.AddWithValue("Pass", pass);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt;
        }

        //------------------------------------//

        //Booking
        public DataTable LoadAllBooking()
        {
            SqlCommand cmd = new SqlCommand("selectAllBooking", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable selectBookingAndLocation()
        {
            SqlCommand cmd = new SqlCommand("selectBookingAndLocation", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable selectBookingAndLocation_BY_U_ID(int id)
        {
            SqlCommand cmd = new SqlCommand("selectBookingAndLocation_BY_U_ID", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("U_ID", id);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int insertBooking(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("InsertBooking", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public int updateBooking(int U_ID,string NameOFcustomer, int Age, string Adress, string Phonenumber, string Email, int LocationID, int NumberPeople, string Statut, int id)
        {
            SqlCommand cmd = new SqlCommand("UpdateBooking", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", id);
            cmd.Parameters.AddWithValue("U_ID", U_ID);
            cmd.Parameters.AddWithValue("NameOFcustomer", NameOFcustomer);
            cmd.Parameters.AddWithValue("Age", Age);
            cmd.Parameters.AddWithValue("Adress", Adress);
            cmd.Parameters.AddWithValue("Phonenumber", Phonenumber);
            cmd.Parameters.AddWithValue("Email", Email);
            cmd.Parameters.AddWithValue("LocationID", LocationID);
            cmd.Parameters.AddWithValue("NumberPeople", NumberPeople);
            cmd.Parameters.AddWithValue("Statut", Statut);

            return cmd.ExecuteNonQuery();
        }

        public int updateSTTBoking(int id, string Statut)
        {
            SqlCommand cmd = new SqlCommand("Update_STT_BYID_Booking", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("IDB", id);
            cmd.Parameters.AddWithValue("Statut", Statut);

            return cmd.ExecuteNonQuery();
        }

        //------------------------------------//

        //Contact
        public DataTable LoadAllContact()
        {
            SqlCommand cmd = new SqlCommand("AllContact", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            return dt;
        }

        public DataTable Load_Contact_NOREAD()
        {
            SqlCommand cmd = new SqlCommand("AllContact_STT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("STT", "NOREAD");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable Load_Contact_READ_NO_REPLY()
        {
            SqlCommand cmd = new SqlCommand("AllContact_STT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("STT", "NotReply");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable Load_Contact_REPLY()
        {
            SqlCommand cmd = new SqlCommand("AllContact_STT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("STT", "REPLY");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public int INSERT_CONTACT(string[] name, object[] value, int nparameter)
        {
            SqlCommand cmd = new SqlCommand("Insert_Contact", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < nparameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public int UPDATE_CONTACT(int ID, string STT)
        {
            SqlCommand cmd = new SqlCommand("Update_STT_Contact", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("ID", ID);
            cmd.Parameters.AddWithValue("STT", STT);


            return cmd.ExecuteNonQuery();
        }
    }
}
