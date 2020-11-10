using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public Label label1 {
            get { return this.Label1; }
            set { this.Label1 = value; }
        }
        connection con = new connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            listType();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            btnDangNhap();
        }

        protected void listType() {
            string query = "SELECT * FROM LOAIHANG";
            DataTable dt = new DataTable();
            con.handle_table(query, dt);
            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();
        }

        protected void btnDangNhap() {
            string txtTenKH = TextBox1.Text;
            string txtMatKhau = TextBox2.Text;
            if (txtTenKH != "" && txtMatKhau != "")
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM KHACHHANG WHERE TenKH='" + txtTenKH + "' AND  MatKhau='" + txtMatKhau + "'";
                con.handle_table(query, dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Session["id"] = row["MaKH"].ToString();
                    }
                    Label1.Text = "Đăng nhập thành công";
                }
                if (dt.Rows.Count == 0)
                {
                    Label1.Text = "Đăng nhập không thành công vui lòng kiểm tra lại tài khoản";
                }
            }
            else 
            {
                Label1.Text = "Đăng nhập không thành công vui lòng kiểm tra lại tài khoản";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string s = ((LinkButton)sender).CommandArgument.Trim();
            Response.Redirect("~/listItem.aspx?sanpham="+s);
        }
    }
}