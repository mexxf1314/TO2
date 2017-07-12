using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Model.Repository
{
    
    public class AllPublicMethod
    {
        EFDbContext context = new EFDbContext();
        //关于用户表操作
        public IEnumerable<User_Count> GetUser_Count()
        {
            return context.User_Counts;
        }
        public IEnumerable<User_Count> GetUser_Count(int id)
        {
            return context.User_Counts.Where(p=>p.Users_Id==id); 
        }
        public int AddUser_Count(User_Count usercount)
        {
            int phone = context.User_Counts.Where(p => p.Users_Phone == usercount.Users_Phone).Count();
            int email = context.User_Counts.Where(p => p.Users_Phone == usercount.Users_Phone).Count();
            if (phone>0)
            {
                return 0;
            }
            else if (email > 0)
            {
                return 1;
            }
            else
            {
                var Usercount = new User_Count() {
                    Users_Name=usercount.Users_Name,
                    Users_Email=usercount.Users_Email,
                    Users_Phone=usercount.Users_Phone,
                    Users_Password=usercount.Users_Password,
                    Users_CreateTO=usercount.Users_CreateTO,
                    Users_TO=usercount.Users_TO,
                    Users_Photo=usercount.Users_Photo,
                    Users_Signature=usercount.Users_Signature,
                    Users_StudyNumber=usercount.Users_StudyNumber,
                    Users_School=usercount.Users_School
                };
                context.Set<User_Count>().Add(Usercount);
                try
                {
                    context.SaveChanges();
                    return Usercount.Users_Id;

                }
                catch (Exception)
                {
                    return 2;
                }

            }
        }
        public string RemoveUser(User_Count usercount)
        {
            var Re = context.User_Counts.FirstOrDefault(d => d.Users_Id == usercount.Users_Id);
            if (Re != null)
            {
                try
                {
                    context.User_Counts.Remove(Re);
                    context.SaveChanges();
                    return "Success";
                }
                catch (Exception)
                {
                    return "error";
                }

            }
            else
            {
                return "该用户不存在";
            }
        }
        public string UpdateUser(User_Count usercount)
        {
            var Re = context.User_Counts.FirstOrDefault(d => d.Users_Id == usercount.Users_Id);
            if (Re != null)
            {
                Re.Users_Name = usercount.Users_Name;
                Re.Users_Password = usercount.Users_Password;
                Re.Users_Phone = usercount.Users_Phone;
                Re.Users_Email = usercount.Users_Email;
                Re.Users_CreateTO = usercount.Users_CreateTO;
                Re.Users_TO = usercount.Users_TO;
                Re.Users_Photo = usercount.Users_Photo;
                Re.Users_Signature = usercount.Users_Signature;
                Re.Users_StudyNumber = usercount.Users_StudyNumber;
                Re.Users_School = usercount.Users_School;
                try
                {
                    context.SaveChanges();
                    return "Success";
                }
                catch (Exception)
                {
                    return "error";
                }

            }
            else
            {
                return "该用户不存在";
            }
        }
        //关于社团表操作
        public IEnumerable<Team_Organizations> GetTeam_Organizations()
        {
            return context.Team_Organization;
        }
        public IEnumerable<Team_Organizations> GetTeam_Organizations(int id)
        {
            return context.Team_Organization.Where(p=>p.TO_Id==id);
        }
        public int AddTeam_Organizations( Team_Organizations to)
        {
            var To = new Team_Organizations() {
                TO_Name=to.TO_Name,
                TO_Unversity=to.TO_Unversity,
                TO_Create_Person=to.TO_Create_Person,
                TO_CreateTime=to.TO_CreateTime,
                TO_Signature=to.TO_Signature,
                TO_State=to.TO_State,
                TO_PersonStudyNumber=to.TO_PersonStudyNumber,
                TO_Image=to.TO_Image

            };
            context.Set<Team_Organizations>().Add(To);
            try {
                context.SaveChanges();
                return To.TO_Id;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public string RemoveTeam_Organizations(Team_Organizations to)
        {
            var To = context.Team_Organization.FirstOrDefault(p => p.TO_Id == to.TO_Id);
            if (To != null)
            {
                try
                {
                    context.Team_Organization.Remove(To);
                    context.SaveChanges();
                    return "该社团已经被删除";
                } catch (Exception)
                {
                    return "删除失败";
                }

            }
            else
            {
                return "社团不存在";
            }
        }
        public string UpdateTeam_Organizations(Team_Organizations To)
        {
            var Re = context.Team_Organization.FirstOrDefault(d => d.TO_Id == To.TO_Id);
            if (Re != null)
            {
                Re.TO_Name = To.TO_Name;
                Re.TO_Unversity = To.TO_Unversity;
                Re.TO_Create_Person = To.TO_Create_Person;
                Re.TO_CreateTime = To.TO_CreateTime;
                Re.TO_PersonStudyNumber = To.TO_PersonStudyNumber;
                Re.TO_Signature = To.TO_Signature;
                Re.TO_State = To.TO_State;
                Re.TO_Image = To.TO_Image;
            
                try
                {
                    context.SaveChanges();
                    return "Success";
                }
                catch (Exception)
                {
                    return "error";
                }

            }
            else
            {
                return "该用户不存在";
            }
        }

    }
}