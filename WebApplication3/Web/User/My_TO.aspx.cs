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
    public partial class WebForm2 : System.Web.UI.Page
    {
        EFDbContext context = new EFDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //返回用户的创建的社团
        public IEnumerable<Team_Organizations> myTeam_Organizations()
        {
             List<Team_Organizations> data = new List<Team_Organizations> { };
            try
            {
                string pho = Session["UserCount_Someone"].ToString();
                var user = context.User_Counts.FirstOrDefault(p => p.Users_Phone == pho);
                string To = user.Users_CreateTO;
                string[] arry = To.Split(',');
                for (int i = 0; i <= arry.Length; i++)
                {
                    int na = int.Parse(arry[i]);
                    var xx = context.Team_Organization.FirstOrDefault(p => p.TO_Id == na);
                    data.Add(xx);
                }
                return data;
            } catch (Exception)
            {
                return data;
            }

        }
        //返回用户加入的社团
        public IEnumerable<Team_Organizations> JoinTeam_Organizations()
        {
            List<Team_Organizations> data = new List<Team_Organizations> { };
            try
            {
                string pho = Session["UserCount_Someone"].ToString();
                var user = context.User_Counts.FirstOrDefault(p => p.Users_Phone == pho);
                string To = user.Users_TO;
                string[] arry = To.Split(',');
                for (int i = 0; i <= arry.Length; i++)
                {
                    int na = int.Parse(arry[i]);
                    var xx = context.Team_Organization.FirstOrDefault(p => p.TO_Id == na);
                    data.Add(xx);
                }
                return data;
            }
            catch (Exception)
            {
                return data;
            }

        }

    }
}