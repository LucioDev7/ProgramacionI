using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Split
    {
        //Declaramos los campos y propiedades
        //Campos: Las variables privadas de las clases
        //Propiedades: Las variables públicas de las clases

        private string color;
        private int frigorias;
        private string marca;
        private bool encendido;

        public int temperatura = 24;
        public string modo = "Frio";



        //Constructor es el metodo que se ejecuta cuando la clase se crea, se instancia en memoria, es decir se construye el objeto 
        public Split(string color, int frigorias, string marca)
        {
            this.color = color;
            this.frigorias = frigorias;
            this.marca = marca;
            this.encendido = false;
        }

        public void PresionarBotonEncendido()
        {
            this.encendido =! this.encendido;
        }

        public void SubirTemperatura()
        {
            if (this.encendido)
            {
               this.temperatura++;
            }
            else
            {
                Console.WriteLine("El Split esta apagado");
            }
            
        }

        public void BajarTemperatura()
        {
            if (this.encendido)
            {
                this.temperatura--;
            }
            else
            {
                Console.WriteLine("El Split esta apagado");
            }

        }

        public void CambiarModo(string modo)
        {
            if (this.encendido)
            {
                this.modo = modo;
            }
            else
            {
                Console.WriteLine("El Split esta apagado");
            }
        }
    }
}
