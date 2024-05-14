using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Libro
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }


    }
}
