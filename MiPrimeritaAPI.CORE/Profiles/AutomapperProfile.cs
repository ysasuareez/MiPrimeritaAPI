using AutoMapper;
using MiPrimeritaAPI.CORE.DTO;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.CORE.Profiles
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<AlumnoDTO, Alumno>();
            CreateMap<Alumno, AlumnoDTO>();
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }

    }
}
