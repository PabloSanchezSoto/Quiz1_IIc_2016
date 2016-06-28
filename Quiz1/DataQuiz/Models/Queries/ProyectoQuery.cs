using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataQuiz.Models.Queries
{
    public class ProyectoQuery
    {

        public int id { get; set; }
        public string puesto { get; set; }
        public string nombreEmpreza { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
    }
}