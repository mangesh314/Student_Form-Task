using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessObject
{
    public class StudentDAL
    {
        public DataSet GetAllDetails()
        {
            DataSet ds = new DataSet();
            string constr = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                SqlCommand cmd = new SqlCommand("usp_GetStudentAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        public DataTable GetLanguage()
        {
            DataTable dt = new DataTable();
            string constr = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                SqlCommand cmd = new SqlCommand("usp_GetLanguage", con);
                con.Open();
                SqlDataAdapter osqlDataAdapter = new SqlDataAdapter(cmd);
                osqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                con.Close();
            }
            return dt;

        }
        public bool SaveData(BeanRespository.User ouser)
        {
            string constr = ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            bool result = false;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_InsertDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();               
                cmd.Parameters.AddWithValue("Name", ouser.Name);
                cmd.Parameters.AddWithValue("DOB", ouser.DOB);
                cmd.Parameters.AddWithValue("@Gender", ouser.Gender);
                cmd.Parameters.AddWithValue("@Email", ouser.Email);               
                cmd.Parameters.AddWithValue("@Language", ouser.Language);
               
                result = cmd.ExecuteNonQuery() == 1 ? true : false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return result;
        }



    }
}
