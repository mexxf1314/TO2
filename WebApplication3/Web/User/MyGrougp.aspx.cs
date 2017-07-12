using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3.Web.User
{
    public partial class MyGrougp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Form["xfx"] !=null&& Request.Form["xfx"] !="")
            {
                Response.Write("<script>alert('"+ Request.Form["xfx"].ToString() + Request.Form["xff"].ToString()+"')</script>");
            }
        }
    }
}