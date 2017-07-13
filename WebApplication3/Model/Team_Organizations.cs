using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
    [Table("Team_Organizations")]
    public class Team_Organizations
    {
        [Key]
        public int TO_Id { set; get; }
        public string TO_Name { set; get; }
        public string TO_Unversity { set; get; }
        public string TO_Create_Person { set; get; }
        public DateTime TO_CreateTime { set; get; }
        public string TO_Signature { set; get; }
        public string TO_State { set; get; }
        public string TO_PersonStudyNumber { set; get; }
        public string TO_Image { set; get; }
        public int To_Star { set; get; }
    }
}