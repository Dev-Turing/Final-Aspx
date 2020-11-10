using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class listItem : System.Web.UI.Page
    {
        connection con = new connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            fetchData();
        }

        protected void fetchData() 
        {
            string query = "SELECT * FROM SANPHAM WHERE LoaiHang='" + Request.QueryString["sanpham"] + "'";
            DataTable dt = new DataTable();
            con.handle_table(query, dt);
            Master.label1.Text = Convert.ToString(dt.Rows.Count);
            this.DataList.DataSource = dt;
            this.DataList.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/chitiet.aspx?masp=" + ((LinkButton)sender).CommandArgument);
        }
    }
}