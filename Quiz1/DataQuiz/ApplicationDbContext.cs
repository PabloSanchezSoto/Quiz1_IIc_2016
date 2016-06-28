using DataQuiz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataQuiz
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Lenguaje> Lenguajes { set; get; }

        public DbSet<Proyecto> Proyectos { set; get; }

        public DbSet<LenguajesProyecto> LenguajeProyectos { set; get; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}