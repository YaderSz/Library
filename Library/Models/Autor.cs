using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Autor
    {


        public int AutorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Autor> Autores { get; set; }


    }
}
