using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class chitiet : System.Web.UI.Page
    {
        connection con = new connection();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            fetchDate();
        }

        protected void fetchDate() {
            string s = Request.QueryString["masp"];
            string query = "SELECT * FROM SANPHAM WHERE MaSP ='" + s +"'";
            con.handle_table(query, dt);

            if(dt.Rows.Count > 0) 
            {
                foreach (DataRow row in dt.Rows) {
                    this.Label1.Text = row["TenSP"].ToString();
                    this.Image1.ImageUrl = "./image/" + row["Hinh"].ToString();
                    this.Label2.Text = row["ChitietSP"].ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["id"] == null) {
                Master.label1.Text = "Đăng nhập để mua hàng";
            }
            else 
            {
                string query = null;
                foreach (DataRow row in dt.Rows) 
                {
                    query = "INSERT INTO DONHANG(MaKH,MaSP,TongTien)  VALUES('" + Session["id"].ToString() + "','" + row["MaSP"].ToString() +"','" + row["Gia"].ToString() + "')";
                }
                int k = con.handle(query);
                if (k > 0)
                {
                    Master.label1.Text = "Mua hàng thành công";
                }
                if (k == 0)
                {
                    Master.label1.Text = dt.Columns["MaSp"].ToString();
                    //Master.label1.Text = "Mua hàng không thành công";
                }
            }
        }
    }
}