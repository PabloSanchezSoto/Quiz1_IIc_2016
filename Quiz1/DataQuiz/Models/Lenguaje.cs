using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using DataQuiz.Models.Queries;

namespace DataQuiz.Models
{
    public class Lenguaje
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public static List<LenguajeQuery> GetAll(ApplicationDbContext db)
        {
            List<LenguajeQuery> lenguajes = (
                from leng in db.Lenguajes
                select new LenguajeQuery
                {
                    id = leng.Id,
                    nombre = leng.Nombre
                }
            ).ToList();
            return lenguajes;
        }
    }
}