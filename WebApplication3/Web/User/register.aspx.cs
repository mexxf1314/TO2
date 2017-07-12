using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.Model;
using WebApplication3.Model.Repository;

namespace WebApplication3.Web.User
{
    public partial class Addcount : System.Web.UI.Page
    {
        AllPublicMethod am = new AllPublicMethod();
        EFDbContext context = new EFDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

            var addnewcount = new User_Count()
            {
                Users_Name = username.Text,
                Users_Password = password.Text,
                Users_Phone = phone.Text,
                Users_Email = email.Text,
                Users_School=school.Text,
                Users_CreateTO = "",
                Users_TO = "",
                Users_Photo = "no",
                Users_Signature = "no",
                Users_StudyNumber = ""

            };
            int adds = am.AddUser_Count(addnewcount);
            if (adds == 0)
            {
                Response.Write("<script>alert(' 该电话号码已存在')</script>");
            }
            else if (adds == 1)
            {
                Response.Write("<script>alert('该邮箱已存在')</script>");
            }
            else if (adds == 2)
            {
                Response.Write("<script>alert('数据异常请联系管理员')</script>");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
          
           

        }

    }
}