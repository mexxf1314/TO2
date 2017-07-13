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
    public partial class WebForm3 : System.Web.UI.Page
    {
        EFDbContext context = new EFDbContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public IEnumerable<Team_Organizations> School_Organizations()
        {
            if ( Session["User_School"]!= null)
            {
                string school = Session["User_School"].ToString();
                return context.Team_Organization.Where(p=>p.TO_Unversity ==school );
            }
            else
            {
                return context.Team_Organization.OrderByDescending(p=>p.TO_Id);
            }

        }
    }
}