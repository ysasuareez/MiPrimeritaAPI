
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Contracts
{
    public interface IAlumnoDAL
    {
        public void Insert(Alumno a);
        public List<Alumno> GetAlumnos();
        public Alumno? GetAlumno(string DNI);
        public void Update(Alumno alumno);
        public void Delete(string DNI);

    }
}
