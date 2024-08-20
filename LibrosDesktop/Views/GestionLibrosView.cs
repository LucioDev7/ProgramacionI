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
    public partial class GestionLibrosView : Form
    {
        BindingSource listaLibros=new BindingSource();
        LibroRepository repo = new LibroRepository();

        public GestionLibrosView()
        {
            InitializeComponent();
            dataGridLibros.DataSource = listaLibros;
            CargarLibrosALaGrilla();
        }

        private async void CargarLibrosALaGrilla()
        {
            listaLibros.DataSource = await repo.ObtenerLibrosAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView();
            agregarEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var libro = (Libro)listaLibros.Current;
            //Mostramos su messagebox que pregunta si esta seguro que desea borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el libro {libro.nombre}?",
                "Eliminar Libro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            //Si el usuario seleccionó que quiere borrar, enviamos a borrar el libro, utilizando el id y el objeto repo.
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(libro._id);
                CargarLibrosALaGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var libro = (Libro)listaLibros.Current;

            //instanciar la ventana AgregarEditarLibro y pasarle ese id a su constructor
            //(Vamos a tener que crear un nuevo constructor en ese formulario que esté preparado para recibir el id)
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView(libro);
            //llamamos a la ventana con el método showmodal que la pone por encima
            agregarEditarLibroView.ShowDialog();
            //recargar la grilla
            CargarLibrosALaGrilla();
        }
    }
}
