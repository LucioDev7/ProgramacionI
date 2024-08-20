using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    public class Persona
    {

        private string nombre;
        private string direccion;
        private string anio_nac;

        public Persona(string nombre, string direccion, string anio_nac)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.anio_nac = anio_nac;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{this.nombre} dice: {texto}");
        }
    }
}

