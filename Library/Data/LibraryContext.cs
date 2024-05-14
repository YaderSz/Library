using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Library.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection
                = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            optionsBuilder.UseSqlServer(connection);
        }
    }

  



}
