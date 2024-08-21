using CiclismoDesktopPorCodigo.DataContext;
using CiclismoDesktopPorCodigo.Modelos;
using CiclismoDesktopPorCodigo.Models;
using CiclismoDesktopPorCodigo.ModelsArg;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CiclismoDesktopPorCodigo.Views.Linq
{
    public partial class PruebasLinqView : Form
    {
        #region Definimos array de JSON
        JArray JSONarrayPeliculas = JArray.Parse("[\r\n  { \"title\": \"El laberinto del fauno\", \"director\": \"Guillermo del Toro\", \"year\": 2006, \"genre\": \"Fantasía\" },\r\n  { \"title\": \"Amores perros\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2000, \"genre\": \"Drama\" },\r\n  { \"title\": \"Mar adentro\", \"director\": \"Alejandro Amenábar\", \"year\": 2004, \"genre\": \"Drama\" },\r\n  { \"title\": \"Todo sobre mi madre\", \"director\": \"Pedro Almodóvar\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"El secreto de sus ojos\", \"director\": \"Juan José Campanella\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"Roma\", \"director\": \"Alfonso Cuarón\", \"year\": 2018, \"genre\": \"Drama\" },\r\n  { \"title\": \"Y tu mamá también\", \"director\": \"Alfonso Cuarón\", \"year\": 2001, \"genre\": \"Drama\" },\r\n  { \"title\": \"La lengua de las mariposas\", \"director\": \"José Luis Cuerda\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"Biutiful\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2010, \"genre\": \"Drama\" },\r\n  { \"title\": \"La vida secreta de las palabras\", \"director\": \"Isabel Coixet\", \"year\": 2005, \"genre\": \"Drama\" },\r\n  { \"title\": \"Relatos salvajes\", \"director\": \"Damián Szifron\", \"year\": 2014, \"genre\": \"Comedia negra\" },\r\n  { \"title\": \"Hable con ella\", \"director\": \"Pedro Almodóvar\", \"year\": 2002, \"genre\": \"Drama\" },\r\n  { \"title\": \"El orfanato\", \"director\": \"J.A. Bayona\", \"year\": 2007, \"genre\": \"Terror\" },\r\n  { \"title\": \"Volver\", \"director\": \"Pedro Almodóvar\", \"year\": 2006, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"Abre los ojos\", \"director\": \"Alejandro Amenábar\", \"year\": 1997, \"genre\": \"Ciencia ficción\" },\r\n  { \"title\": \"Celda 211\", \"director\": \"Daniel Monzón\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"El hijo de la novia\", \"director\": \"Juan José Campanella\", \"year\": 2001, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"El espinazo del diablo\", \"director\": \"Guillermo del Toro\", \"year\": 2001, \"genre\": \"Terror\" },\r\n  { \"title\": \"La piel que habito\", \"director\": \"Pedro Almodóvar\", \"year\": 2011, \"genre\": \"Thriller\" },\r\n  { \"title\": \"La historia oficial\", \"director\": \"Luis Puenzo\", \"year\": 1985, \"genre\": \"Drama\" }\r\n]\r\n");
        #endregion
        public PruebasLinqView()
        {
            InitializeComponent();
        }

        private void btnPruebaArray_Click(object sender, EventArgs e)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = (from num in numeros
                                where num % 2 == 0
                                select new { Numero = num }).ToList();

            dataGridResultados.DataSource = numerosPares;
        }

        private void btnSqlLinq_Click(object sender, EventArgs e)
        {
            using (var context = new Ciclismo2Context())
            {
                var query = from Cliente in context.Clientes
                            select Cliente;

                dataGridResultados.DataSource = query.ToList();
            }
        }

        private void btnXMLlinq_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XML", "Libros.xml");

            XDocument doc = XDocument.Load(path);
            var libros = (from book in doc.Descendants("book")
                          select new
                          {
                              Titulo = book.Element("title")?.Value,
                              Autor = book.Element("author")?.Value,
                              Year = book.Element("year")?.Value,
                              Genero = book.Element("genre")?.Value
                          }).ToList();

            dataGridResultados.DataSource = libros;

        }

        private void btnJsonLinq_Click(object sender, EventArgs e)
        {
            var peliculas = (from pelicula in JSONarrayPeliculas
                             select new
                             {
                                 Titulo = pelicula["title"],
                                 Director = pelicula["director"],
                                 Año = pelicula["year"],
                                 Genero = pelicula["genre"]
                             }).ToList();

            dataGridResultados.DataSource = peliculas;
        }

        private void btnSelectLinq_Click(object sender, EventArgs e)
        {
            var peliculas = JSONarrayPeliculas.Select(pelicula => new
            {
                Titulo = pelicula["title"],
                Director = pelicula["director"],
                Año = pelicula["year"],
                Genero = pelicula["genre"]
            }).ToList();

            dataGridResultados.DataSource = peliculas;
        }

        private void btnSelectManyLinq_Click(object sender, EventArgs e)
        {
            object[] objectos = { 1, "San Justo", true, new string[] { "Hola", "Mundo" }, true, new string[] { "Santa Fe", "San Justo" }, 5, "Lucio", 7.5f, false, 9, new int[] { 1, 2, 3 } };
            var ArrayString = objectos.OfType<string[]>().SelectMany(a => a).Select(s => new
            {
                Texto = s
            }).ToList();
            dataGridResultados.DataSource = ArrayString;
        }

        private void btnWhereLinq_Click(object sender, EventArgs e)
        {
            var pelis = JSONarrayPeliculas.ToObject<List<Pelicula>>();
            var peliculas = pelis.Where(p => p.year > 2000).ToList();
            dataGridResultados.DataSource = peliculas;
        }

        private void btnOfType_Click(object sender, EventArgs e)
        {
            object[] objects = { 1, "San Justo", true, new string[] { "Hola", "Mundo" }, 5, "Lucio", 7.5f, false, 9, new int[] { 1, 2, 3 } };
            var textoEnArray = objects.OfType<string>();
            dataGridResultados.DataSource = textoEnArray.Select(texto => new { Texto = texto }).ToList();
        }

        private void btnWhereLinqAvanz_Click(object sender, EventArgs e)
        {
            var filtro = txtFiltro.Text;
            var pelis = JSONarrayPeliculas.ToObject<List<Pelicula>>();
            var peliculas = pelis.Where(p => p.title.Contains(filtro) || p.director.Contains(filtro) || p.genre.Contains(filtro)).ToList();
            dataGridResultados.DataSource = peliculas;
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            using (var context = new Ciclismo2Context())
            {
                var clientes = context.Clientes.OrderBy(c => c.Nombre).ToList();

                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnOrderByAvanzado_Click(object sender, EventArgs e)
        {
            using (var context = new Ciclismo2Context())
            {
                var clientes = context.Clientes.OrderBy(c => c.Pais).ThenBy(c => c.Nombre).ToList();

                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnOrderByDesc_Click(object sender, EventArgs e)
        {
            using (var context = new argentinaContext())
            {
                //Extension Methods
                //var provincias = context.Provincias.OrderByDescending(p => p.Nombre).ToList();
                //dataGridResultados.DataSource = provincias;

                var provincias = from provincia in context.Provincias
                                 orderby provincia.Nombre descending
                                 select provincia;
                dataGridResultados.DataSource = provincias.ToList();
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            using (var context = new argentinaContext())
            {
                var departamentosAgrupadosPorProvincia = context.Departamentos.Include(d=>d.Provincias).GroupBy(d => d.ProvinciasId).Select(d=> new
                {
                    NumeroProvincia = d.Key,
                    NombreProvincia = d.First().Provincias.Nombre,
                    NumeroDepartamento = d.Count()
                }).ToList();
                dataGridResultados.DataSource = departamentosAgrupadosPorProvincia;
            }
        }
    }
}

