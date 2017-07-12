using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Model.Repository
{
    public class ChangeTO
    {
        EFDbContext context = new EFDbContext();
        public int GetTO_number(string phone)
        {
            string [] arry ;
            if (phone != null && phone != "")
            {
                var user = context.User_Counts.FirstOrDefault(p => p.Users_Phone == phone);
                string te = user.Users_CreateTO;
                arry = te.Split(',');
                return arry.Length;
            }
            else
            {
                return 0;
            }
        } 
    }
}