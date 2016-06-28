using DataQuiz.Models.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataQuiz.Models
{
    public class Proyecto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Puesto: ")]
        public string Puesto { get; set; }

        [DisplayName("Nombre Empreza: ")]
        public string NombreEmpreza { get; set; }

        [DisplayName("Fecha en la que laboro: ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fecha { get; set; }

        [DisplayName("Descripcíon :")]
        public string descripcion { get; set; }

        public static List<ProyectoQuery> GetAll(ApplicationDbContext db)
        {
            List<ProyectoQuery> proyectos = (
                from proy in db.Proyectos
                select new ProyectoQuery
                {
                    id = proy.Id,
                    puesto = proy.Puesto,
                    nombreEmpreza = proy.NombreEmpreza,
                    fecha= proy.fecha,
                    descripcion = proy.descripcion
                }
            ).ToList();
            return proyectos;
        }
    }
}
}