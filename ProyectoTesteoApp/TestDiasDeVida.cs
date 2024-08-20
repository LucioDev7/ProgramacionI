using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestDiasDeVida
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1año1mes1dia()
        {
            int diasDeVida = Program.CalcularDiasDeVida(1, 1, 1);
            Assert.That(diasDeVida, Is.EqualTo(396));
        }

        [Test]
        public void Test10año10mes1dia()
        {
            int diasDeVida = Program.CalcularDiasDeVida(1, 10, 10);
            Assert.That(diasDeVida, Is.EqualTo(3951));
        }
    }
}
