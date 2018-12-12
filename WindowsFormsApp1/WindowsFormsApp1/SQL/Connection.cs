using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp1.SQL
{
    class Connection
    {
        SqlConnection con = null; 

        public Connection()
        {
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=CET;Trusted_Connection=True;");
        }

        public SqlConnection getConnection()
        {
            con.Open(); 
            return con; 
        }

        public void closeConnection()
        {
            con.Close(); 
        }
    }
}
