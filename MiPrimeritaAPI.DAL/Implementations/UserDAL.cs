using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Implementations
{
    public class UserDAL : IUserDAL
    {
        public IESContext Context { get; set; }

        public UserDAL(IESContext Context)
        {
            this.Context = Context;
        }

        public User? GetUser(string Email)
        {
            return Context.Users.FirstOrDefault(user=>user.Email==Email);
        }

        public void Delete(string Email)
        {
            var user = GetUser(Email);
            if (user != null)
                Context.Users.Remove(user);
            Context.SaveChanges();
        }


        public void Insert(User a)
        {
            Context.Users.Add(a);
            Context.SaveChanges();
        }

        public void Update(User u)
        {

            var userBD = GetUser(u!.Email);
            if (userBD != null)
            {
                userBD.Username = u.Email;
            }
            Context.Users.Update(userBD);
            Context.SaveChanges();
        }


        public List<User> GetUsers()
        {
            return Context.Users.ToList();
            
        }

        


        


    }
}
