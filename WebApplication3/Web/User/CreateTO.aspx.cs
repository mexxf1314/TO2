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
    public partial class CreateTO : System.Web.UI.Page
    {
        EFDbContext context = new EFDbContext();
        AllPublicMethod apm = new AllPublicMethod();
        ChangeTO cto= new ChangeTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (Session["UserCount_Someone"] == null || Session["UserCount_Someone"].ToString() == "")
            {
                Response.Write("<script>alert('请先登录')</script>");
                Response.Redirect("login.aspx");
            }
            else if (teamname.Text == "" || cologename.Text == "" || cologenumber.Text == "")
            {
                Response.Write("<script>alert('请填写正确的信息')</script>");
            }
            else if (cto.GetTO_number(Session["UserCount_Someone"].ToString()) > 3)
            {
                Response.Write("<script>alert('你已经超过建立社团的上限')</script>");
            }
            else{
                var TO = new Team_Organizations()
                {
                    TO_Name = teamname.Text,
                    TO_Unversity = cologename.Text,
                    TO_PersonStudyNumber = cologenumber.Text,
                    TO_Signature = teaminstraction.Text,
                    TO_CreateTime = DateTime.Now,
                    TO_Create_Person = Session["UserCount_Someone"].ToString(),
                    TO_State = "available",
                    To_Star=0
                };

               int message = apm.AddTeam_Organizations(TO);
                if (message!=0)
                {
                    try
                    {
                        string pho = Session["UserCount_Someone"].ToString();
                    var xx = context.User_Counts.FirstOrDefault(p => p.Users_Phone ==pho);
                    if (xx != null)
                    {
                        xx.Users_CreateTO = xx.Users_CreateTO  + message.ToString() + ",";
                        context.SaveChanges();
                        Response.Write("<script>alert('success')</script>");
                    }
                    }
                    catch (Exception)
                    {
                        Response.Write("<script>alert('将社团ID添加至用户表出错')</script>");
                    }

                }
                else
                {
                    Response.Write("<script>alert('"+message+"')</script>");
                }
            }
           
        }
    }
}