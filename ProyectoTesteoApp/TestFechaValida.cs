using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestFechaValida
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test31Abril()
        {
            bool resultado = Program.ControlFechasValidasInvalidas(31, 4, 2024);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void Test31Junio()
        {
            bool resultado = Program.ControlFechasValidasInvalidas(31, 6, 2024);
            Assert.IsFalse(resultado);
        }
        
        [Test]
        public void Test29Febrero2023()
        {
            bool resultado = Program.ControlFechasValidasInvalidas(29, 2, 2023);
            Assert.IsFalse(resultado);
        }

        [Test]
        public void Test29Febrero2024()
        {
            bool resultado = Program.ControlFechasValidasInvalidas(29, 2, 2024);
            Assert.IsTrue(resultado);
        }

        [Test]
        public void Test30Febrero2024()
        {
            bool resultado = Program.ControlFechasValidasInvalidas(30, 2, 2024);
            Assert.IsFalse(resultado);
        }
    }
}
