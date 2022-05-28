using AutoMapper;
using MiPrimeritaAPI.BL.Contracts;
using MiPrimeritaAPI.CORE.DTO;
using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;

namespace MiPrimeritaAPI.BL.Implementations
{
    public class AlumnoBL : IAlumnoBL
    {
        public IAlumnoDAL alumnoDAL { get; set; }
        public IMapper mapper { get; set; }

        public AlumnoBL(IAlumnoDAL alumnoDAL, IMapper mapper)
        {
            this.alumnoDAL = alumnoDAL;
            this.mapper = mapper;
        }
        public void Delete(string DNI)
        {
            alumnoDAL.Delete(DNI);
        }

        public AlumnoDTO? GetAlumno(string DNI)
        {
            var alumno = alumnoDAL.GetAlumno(DNI);
            if(alumno != null)
            {
                //var alumnoDTO = new AlumnoDTO()
                //{
                //    DNI = alumno.DNI,
                //    Nombre = alumno.Nombre,
                //    PIN = alumno.PIN
                //};
                var alumnoDTO = mapper.Map<AlumnoDTO>(alumno);
                return alumnoDTO;
            }
            else
            {
                return null;
            }
        }

        public List<AlumnoDTO> GetAlumnos()
        {
            var alumnos = alumnoDAL.GetAlumnos();
            var alumnoDTOs = mapper.Map<List<AlumnoDTO>>(alumnos);
            return alumnoDTOs;  
        }

        public bool Insert(AlumnoDTO alumnoDTO)
        {
            var alumno = alumnoDAL.GetAlumno(alumnoDTO.DNI);
            if(alumno == null)
            {
                alumno = mapper.Map<Alumno>(alumnoDTO);

                alumnoDAL.Insert(alumno);
                //Enviar email
                return true;
            }
            return false;
        }

        public void Update(AlumnoDTO alumnoDTO)
        {
            var alumno = mapper.Map<Alumno>(alumnoDTO);

            alumnoDAL.Update(alumno);
        }
    }
}
