using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Model.Repository;

namespace WebApplication3.Web.User
{
    public partial class login : System.Web.UI.Page
    {
        EFDbContext context = new EFDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            int count = context.User_Counts.Where(p => p.Users_Phone == Username.Text && p.Users_Password == Password.Text).Count();
            if (count > 0)
            {
                Session["UserCount_Someone"] = Username.Text.ToString();
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("<script>alert('密码或账号错误')</script>");
            }
        }
    }
}