using EjerciciosDePrueba.Models;
using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosDesktop.Views
{
    public partial class AgregarEditarLibroView : Form
    {
        LibroRepository repo = new LibroRepository();
        private Libro? libro;

        //constructor
        public AgregarEditarLibroView()
        {
            InitializeComponent();
            this.libro = new Libro();
        }
        public AgregarEditarLibroView(Libro libro)
        {
            InitializeComponent();
            this.libro = libro;
            CargarDatosLibroEnPantalla();

        }

        private void CargarDatosLibroEnPantalla()
        {
                numericPaginas.Value = libro.pagina;
                txtEditorial.Text = libro.editorial;
                txtAutor.Text = libro.autor;
                txtNombre.Text = libro.nombre;
                txtPortadaUrl.Text = libro.portada_url;
                txtSinopsis.Text = libro.sinopsis;
                txtGenero.Text = libro.genero;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            this.libro.nombre= txtNombre.Text;
            this.libro.autor= txtAutor.Text;
            this.libro.genero = txtGenero.Text;
            this.libro.portada_url = txtPortadaUrl.Text;
            this.libro.sinopsis = txtSinopsis.Text;
            this.libro.editorial = txtEditorial.Text;
            this.libro.pagina = (int)numericPaginas.Value;
            if (this.libro._id != null)
            {
                await repo.ActualizarAsync(this.libro);
            }
            else
            {
                await repo.AgregarAsync(this.libro);
            }

            this.Close();
        }
    }
}
