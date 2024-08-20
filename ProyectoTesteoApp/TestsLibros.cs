using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class TestsLibros
    {
        [SetUp]
        public void Setup()
        {
            
        }

        //[Test]
        //public async Task TestObtenerLibros()
        //{
        //    LibroRepository libroRepository = new LibroRepository();
        //    var libros = await libroRepository.ObtenerLibrosAsync();
        //    Assert.That(libros.Count, Is.Not.EqualTo(0));
        //}

        //[Test]
        //public async Task TestAgregarLibro()
        //{
        //    LibroRepository libroRepository = new LibroRepository();
        //    var libro = await libroRepository.AgregarAsync(900, "TestAgregar", "Lucio", "PruebaTest", "https://http2.mlstatic.com/D_NQ_NP_692542-MLA46483098859_062021-O.webp", "Holaaaaaaaa","Programador" );
        //    Assert.That(libro.nombre, Is.EqualTo("PruebaTest"));
        //}

        //[Test]
        //public async Task TestEliminarLibro()
        //{
        //    LibroRepository libroRepository = new LibroRepository();
        //    var borrado = await libroRepository.EliminarAsync("665a1506b384736b000011f3");
        //    Assert.That(borrado, Is.EqualTo(true));
        //}

        //[Test]
        //public async Task TestObtenerLibro() 
        //{
        //    LibroRepository libroRepository = new LibroRepository();
        //    var libro = await libroRepository.ObtenerPorIdAsync("65147d31c3119e6f000001ee");
        //    Assert.That(libro.nombre, Is.EqualTo("Veinte mil leguas de viaje submarino"));
        //}

        //[Test]
        //public async Task TestActualizarLibro()
        //{
        //    LibroRepository libroRepository = new LibroRepository();
        //    var libro = await libroRepository.ActualizarAsync(900, "TestAgregar", "Test", "Test123", "https://http2.mlstatic.com/D_NQ_NP_692542-MLA46483098859_062021-O.webp", "Holaaaaaaaa", "Programador", "654db479aedafa2100000004");
        //    Assert.That(libro.nombre, Is.EqualTo("Test123"));
        //}
    }
}