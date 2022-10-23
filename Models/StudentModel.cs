using System;
using System.ComponentModel.DataAnnotations;

namespace LoginMysql.Models
{
    public class StudentModel
    {
        [Key]
        public int idAlumno { get; set; }  
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public DateTime FecAlta { get; set; }
        public int edad { get; set; }
    }
}
