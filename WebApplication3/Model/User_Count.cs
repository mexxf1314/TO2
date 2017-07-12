using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Model
{
    [Table("User_Count")]
    public class User_Count
    {
        [Key]
        public int Users_Id { set; get; }
        public string Users_Name { set; get; }
        public string Users_Password { set; get; }
        public string Users_Phone { set; get; }
        public string Users_Email { set; get; }
        public string Users_CreateTO { set; get; }
        public string Users_TO { set; get; }
        public string Users_Photo { set; get; }
        public string Users_Signature { set; get; }
        public string Users_StudyNumber { set; get; }
        public string Users_School { set; get; }
    }
}