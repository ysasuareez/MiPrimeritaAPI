using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeritaAPI.DAL.Tables
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? DNI { get; set; }
        public int PIN { get; set; }
    }
}
