using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.SQL
{
    class ExecuteQuery
    {
        SqlConnection con = null; 

        public void addCall(string date, string time, string callerName, string callerPhone, string callerCompany, string askingFor, string details, string branch)
        {
            Connection connection = new Connection();
            string query = "INSERT INTO dbo.calls(Time, Date, CallerName, CallerCompany, CallerPhone, AskingFor, Details, Branch) VALUES(@TimeValue, @DateValue," +
                    " @CallerNameValue, @CallerCompanyValue, @CallerPhoneValue, @AskingForValue, @DetailsValue, @BranchValue)";

            con = connection.getConnection();

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                // set the parameter value
                cmd.Parameters.Add("@TimeValue", SqlDbType.Time).Value = TimeSpan.Parse(time);
                cmd.Parameters.Add("@DateValue", SqlDbType.Date).Value = DateTime.Parse(date); //"12/10/2018"
                cmd.Parameters.Add("@CallerNameValue", SqlDbType.NChar).Value = callerName;
                cmd.Parameters.Add("@CallerCompanyValue", SqlDbType.NChar).Value = callerCompany;
                cmd.Parameters.Add("@AskingForValue", SqlDbType.NChar).Value = askingFor;
                cmd.Parameters.Add("@DetailsValue", SqlDbType.NVarChar).Value = details;
                cmd.Parameters.Add("@BranchValue", SqlDbType.NChar).Value = branch;
                cmd.Parameters.Add("@CallerPhoneValue", SqlDbType.NChar).Value = callerPhone;

               
                cmd.ExecuteNonQuery();
               
            }

            connection.closeConnection(); 


        }

        public int getAllEntries(string name)
        {
            int valueToReturn = 0; 

            Connection connection = new Connection();
            string query = "SELECT COUNT(*) FROM DBO.CALLS where CallerName=@Name";

            con = connection.getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Name", name); 

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine("Number of rows: " + reader[0]);
                    valueToReturn = Convert.ToInt32(reader[0]); 
                }

            }

            connection.closeConnection();

            return valueToReturn; 
        }
    }
}
