using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class PavaElectrica
    {
        private string marca;
        private string modelo;
        private double capacidad;
        private bool encendida;
        private double temperaturaActual;

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
       
        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public double Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }

        public bool Encendida
        {
            get { return this.encendida; }
            set { this.encendida = value; }
        }

        public double TemperaturaActual
        {
            get { return this.temperaturaActual; }
            set { this.temperaturaActual = value; }
        }

        public string Modo = "Mate";


        public PavaElectrica(string marca, string modelo, string capacidad)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.capacidad = double.Parse(capacidad);
            this.encendida = false;
            this.temperaturaActual = 20; // Temperatura ambiente   
        }



        public void Encender()
        {
            this.encendida = !this.encendida;
        }
        
        public void HervirAgua()
        {
            if (this.encendida && Modo == "Mate")
            {
                Console.WriteLine($"La temperatura actual de la pava electrica es de {this.temperaturaActual}");

                while (true)
                {
                    if (this.temperaturaActual == 100)
                    {
                        Esperar();
                        Thread.Sleep(5000);
                        Console.WriteLine($"La temperatura esta llegando a {this.temperaturaActual}º, espere unos 10 segundos a que el agua este lista");
                        Thread.Sleep(10000);
                        Console.WriteLine("Ya han pasado los 10 seg. El agua esta lista para tomar mate");
                        break;
                    }
                    else
                    {
                        this.temperaturaActual++;
                    }
                }
            }
            else if (this.encendida && Modo == "Cafe")
            {
                Console.WriteLine($"La temperatura actual de la pava electrica es de {this.temperaturaActual}");
                while (true)
                {
                    if (this.temperaturaActual == 90)
                    {
                        Esperar();
                        Thread.Sleep(5000);
                        Console.WriteLine($"La temperatura esta llegando a {this.temperaturaActual}º, espere unos 10 segundos a que el agua este lista");
                        Thread.Sleep(10000);
                        Console.WriteLine("Ya han pasado los 10 seg. El agua esta lista para tomar Café");
                        break;
                    }
                    else
                    {
                        this.temperaturaActual++;
                    }
                }
            }
            else
            {
                Console.WriteLine("La Pava Electrica no está encendida. Por favor, enciendala primero.");
            }
        }

        public void Esperar()
        {
            if (this.encendida)
            {
                Console.WriteLine("Esperando a que el agua se caliente..");
            }
            else
            {
                Console.WriteLine("La Pava Electrica no está encendida. Por favor, enciendala primero.");
            }
        }

        public void CambiarModo(string modo)
        {
            if (this.encendida)
            {
                this.Modo = modo;
            }
            else
            {
                Console.WriteLine("La pava esta apagada");
            }
        }
    }
}




