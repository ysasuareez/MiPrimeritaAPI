using MiPrimeritaAPI.CORE.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.BL.Contracts
{
    public interface IAlumnoBL
    {
        public bool Insert(AlumnoDTO a);
        public List<AlumnoDTO> GetAlumnos();
        public AlumnoDTO? GetAlumno(string DNI);
        public void Update(AlumnoDTO alumno);
        public void Delete(string DNI);
    }
}
