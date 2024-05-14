using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           List<Autor> autors = new List<Autor>();
            Repository<Autor> repository = new Repository<Autor>();
            repository.Add(new Autor{
                Name = txtNombre.Text
            });
        }
    }
}
