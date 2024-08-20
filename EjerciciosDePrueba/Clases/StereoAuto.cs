using EjerciciosDePrueba.Enums;

namespace EjerciciosDePrueba.Clases
{
    internal class StereoAuto
    {

        public bool Encendido { get; private set; }

        public int Volumen { get; private set; }

        public double FrecuenciaFM { get; private set; }

        public int EstacionAM { get; private set; }

        public StereoEnum Modo { get; private set; }


        public StereoAuto()

        {

            Encendido = false;

            Volumen = 10;

            FrecuenciaFM = 99.9;

            EstacionAM = 810;

            Modo = StereoEnum.FM;

        }

        public void Encender()

        {

            Encendido = true;

            Console.WriteLine("Stereo encendido.");

        }

        public void Apagar()

        {

            Encendido = false;

            Console.WriteLine("Stereo apagado.");

        }

        public void AjustarVolumen(int nuevoVolumen)

        {

            if (nuevoVolumen >= 0 && nuevoVolumen <= 100)

            {

                Volumen = nuevoVolumen;

                //Console.WriteLine($"Volumen ajustado a: {Volumen}");

            }

            else

            {

                Console.WriteLine("Volumen fuera de rango. Debe estar entre 0 y 100.");

            }

        }

        public void AjustarFrecuenciaFM(double nuevaFrecuencia)

        {

            if (nuevaFrecuencia >= 87.5 && nuevaFrecuencia <= 108.0)

            {

                FrecuenciaFM = nuevaFrecuencia;

                //Console.WriteLine($"Frecuencia FM ajustada a: {FrecuenciaFM} MHz");

            }

            else

            {

                Console.WriteLine("Frecuencia FM fuera de rango. Debe estar entre 87.5 y 108.0 MHz.");

            }

        }

        public void AjustarEstacionAM(int nuevaEstacion)

        {

            if (nuevaEstacion >= 520 && nuevaEstacion <= 1710)

            {

                EstacionAM = nuevaEstacion;

                //Console.WriteLine($"Estación AM ajustada a: {EstacionAM} kHz");

            }

            else

            {

                Console.WriteLine("Estación AM fuera de rango. Debe estar entre 520 y 1710 kHz.");

            }

        }

        public void Display(StereoEnum nuevoModo)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Estado del estéreo:");

            if (Encendido)
            {
                Console.WriteLine("Encendido: Sí");
                Console.WriteLine($"Volumen: {Volumen}");

                switch (nuevoModo)
                {
                    case StereoEnum.FM:
                        Console.WriteLine("Modo FM seleccionado");
                        Console.WriteLine($"Frecuencia FM: {FrecuenciaFM} MHz");
                        break;
                    case StereoEnum.AM:
                        Console.WriteLine("Modo AM seleccionado");
                        Console.WriteLine($"Frecuencia AM: {EstacionAM} kHz");
                        break;
                    case StereoEnum.AUX:
                        Console.WriteLine("Modo AUX seleccionado");
                        break;
                    case StereoEnum.Bluetooth:
                        Console.WriteLine("Modo Bluetooth seleccionado");
                        break;
                    case StereoEnum.CD:
                        Console.WriteLine("Modo CD seleccionado");
                        break;
                    default:
                        Console.WriteLine("Modo no reconocido");
                        break;

                }
            }
            Console.WriteLine("---------------------------------------------------------");
        }



    }
}
