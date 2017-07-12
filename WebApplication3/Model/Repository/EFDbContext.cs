using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Model.Repository
{
    public class EFDbContext:DbContext
    {
        public DbSet<User_Count> User_Counts { set; get; }
        public DbSet<Team_Organizations> Team_Organization { set; get; }

    }
}