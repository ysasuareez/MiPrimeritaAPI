using MiPrimeritaAPI.DAL.Contracts;
using MiPrimeritaAPI.DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Implementations
{
    public class AlumnoDAL : IAlumnoDAL
    {
        public IESContext Context { get; set; }

        public AlumnoDAL(IESContext Context)
        {
            this.Context=Context;
        }
        public void Delete(string DNI)
        {
            var alumno = GetAlumno(DNI);
            if (alumno != null)
                Context.Alumnos.Remove(alumno);
            Context.SaveChanges();
        }

        public Alumno? GetAlumno(string DNI)
        {
            return Context.Alumnos.FirstOrDefault(a => a.DNI == DNI);
        }

        public List<Alumno> GetAlumnos()
        {
            return Context.Alumnos.ToList();
        }

        public void Insert(Alumno a)
        {
            Context.Alumnos.Add(a);
            Context.SaveChanges();
        }

        public void Update(Alumno alumno)
        {
            
            var alumnoBD = GetAlumno(alumno!.DNI);
            if (alumnoBD != null)
            {
                alumnoBD.Nombre = alumno.Nombre;
            }
            Context.Alumnos.Update(alumnoBD);
            Context.SaveChanges();
        }
    }
}
