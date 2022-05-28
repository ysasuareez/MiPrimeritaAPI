using MiPrimeritaAPI.CORE.DTO;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.BL.Contracts
{
    public interface IUserBL
    {
        public bool Insert(UserDTO a);
        public List<UserDTO> GetUsers();
        public UserDTO? GetUser(string Email);
        public void Update(UserDTO user);
        public void Delete(string Email);
    }
}

