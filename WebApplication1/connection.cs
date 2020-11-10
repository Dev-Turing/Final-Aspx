using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public class connection
    {
        string stcn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vuvan\source\repos\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        public void conOpen() {
            con = new SqlConnection(stcn);
            con.Open();
        }

        public void conClose() {
            if ((con.State & ConnectionState.Open) > 0) 
            {
                con.Close();
            }
        }

        public int handle(string query) 
        {
            int kq = 0;
            try 
            {
                conOpen();
                SqlCommand cm = new SqlCommand(query, con);
                kq = cm.ExecuteNonQuery();
            }
            catch 
            {
                kq = 0;
            }
            finally
            {
                conClose();
            }
            return kq;
        }

        public DataTable handle_table(string query , DataTable dt) {
            try
            {
                conOpen();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }
            catch 
            {
                dt = null;
            }
            
            return dt;
        }
    }
}