using EjerciciosDePrueba.Clases;
using EjerciciosDePrueba.Enums;
using System.Runtime.CompilerServices;

public class Program
{

    private static void Main(string[] args)
    {

        //Console es una Clase que permite gestionar a la consola
        //PedirNombreYSaludar();
        //CalcularDiasdeVida();
        //valoresTrianguloYTipo();
        //menorDeCuatro();
        //mostrarHoras();
        //CalcularValorPago();
        //PruebaDeObjetoSplit();
        //PruebaDeObjetosPersona();
        //PruebaDeObjetosPavaElectrica();
        //PruebaStereo();
        //fechasValidasInvalidas();
        //Console.WriteLine(Triangulo(1,1,1));
        //PruebaClasesAbstractasHerencias();
        PruebaDeClasesGenericas();
    }

    private static void PruebaDeClasesGenericas()
    {
        Empresa<Empleado> empresa = new Empresa<Empleado>("Neumaticos Debona");
        Gerente empleado1 = new Gerente("Juan", "Perez");
        Gerente empleado2 = new Gerente("Pedro", "Piriz");
        empresa.agregarEmpleado(empleado1);
        empresa.agregarEmpleado(empleado2);
        Console.WriteLine(empresa.ListarPersonas());
        empresa.quitarEmpleado(empleado2);
        Console.WriteLine(empresa.ListarPersonas());

    }



    #region Demas

    private static void PruebaClasesAbstractasHerencias()
    {
        Gerente Juan = new Gerente("Javier", "Milei");
        Console.WriteLine(Juan.imprimirDatos());
    }

    private static void fechasValidasInvalidas()

    {
        //definir variables  
        int dia, mes, año;

        // Pedir Informacion al usuario
        Console.WriteLine("Ingrese el día");
        dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el mes");
        mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el año");
        año = int.Parse(Console.ReadLine());


        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            Console.WriteLine("Fecha Valida");

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            Console.WriteLine("Fecha Valida ");

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            Console.WriteLine("Fecha Valida ");

        else
            Console.WriteLine("Fecha Invalida");

    }

    public static bool ControlFechasValidasInvalidas(int dia, int mes, int año)

    {
        if ((dia >= 1 && dia <= 31) && (mes == 1 || mes == 3 ||
                mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12))
            return true;

        else if ((dia >= 1 && dia <= 30) && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            return true;

        else if ((dia == 29) && (mes == 2) && (año % 4 == 0) || (dia >= 1 && dia <= 28) && (mes == 2))

            return true;

        else
            return false;

    }


    
    public static void PruebaStereo()
    {
        StereoAuto miStereo = new StereoAuto();

        miStereo.Encender();
        miStereo.Display(StereoEnum.Bluetooth);
        miStereo.AjustarVolumen(30);
        Thread.Sleep(2000);

        miStereo.AjustarEstacionAM(990);
        miStereo.Display(StereoEnum.AM);
        miStereo.AjustarVolumen(20);
        Thread.Sleep(2000);

        miStereo.AjustarFrecuenciaFM(90);
        miStereo.Display(StereoEnum.FM);
        miStereo.AjustarVolumen(99);
        Thread.Sleep(2000);

        miStereo.Display(StereoEnum.AUX);
        miStereo.AjustarVolumen(2);
        Thread.Sleep(2000);        
        
        miStereo.Apagar();
        
    }
    
    private static void PruebaDeObjetosPavaElectrica()
    {
        PavaElectrica Pavita = new PavaElectrica("Mega Express", "ME-621", "1,8");
        Console.WriteLine($"La Pava Electrica {Pavita.Marca}, modelo {Pavita.Modelo} cuenta con una capacidad de {Pavita.Capacidad} Litros. Tiene una temperatura actual de {Pavita.TemperaturaActual} ºC y se encuentra apagada");

        Console.WriteLine("");
        Pavita.Encender();
        Console.WriteLine("La pava se acaba de encender");
        Console.WriteLine($"La pava se encuentra en modo {Pavita.Modo}");
        Console.WriteLine("");
        Pavita.HervirAgua();
        Console.WriteLine("");
        Pavita.Encender();
        Console.WriteLine("La pava se acaba de apagar");
        Pavita.HervirAgua();



        Console.WriteLine("");
        Console.WriteLine("");
        PavaElectrica Pavita2 = new PavaElectrica("Mega", "ME", "2");
        Console.WriteLine($"La Pava Electrica {Pavita2.Marca}, modelo {Pavita2.Modelo} cuenta con una capacidad de {Pavita2.Capacidad} Litros. Tiene una temperatura actual de {Pavita2.TemperaturaActual} ºC y se encuentra apagada");

        Console.WriteLine("");
        Pavita2.Encender();
        Console.WriteLine("La pava se acaba de encender");
        Pavita2.CambiarModo("Cafe");
        Console.WriteLine($"La pava se encuentra en modo {Pavita2.Modo}");
        Console.WriteLine("");
        Pavita2.HervirAgua();
        Console.WriteLine("");
        Pavita2.Encender();
        Console.WriteLine("La pava se acaba de apagar");

    }

    private static void PruebaDeObjetosPersona()
    {
        Persona Albert = new Persona("Albert Eistein", "9 de Julio 1111", "1879");
        Persona Robert = new Persona("Robert Oppeheider", "Manhattan 2222", "1904");

        Robert.Decir("Albert, sabés como se despiden los químicos?");
        Albert.Decir("No, ni idea");
        Robert.Decir("Acído un placer");
    }


   
    private static void PruebaDeObjetoSplit()
    {
        //Instanciamos el objeto Split
        Split miSplit = new Split("Blanco", 3000, "Marshall");
        miSplit.SubirTemperatura();
        miSplit.SubirTemperatura();
        miSplit.PresionarBotonEncendido();
        miSplit.CambiarModo("Deshumidificación");
        miSplit.SubirTemperatura();
        Console.WriteLine("El modo definido del split es: " + miSplit.modo);
    }

    
    private static void CalcularValorPago()
    {

        double valorCuota;
        int nroDia;

        Console.Write("Ingrese valor de la cuota: ");
        valorCuota = double.Parse(Console.ReadLine());

        Console.Write("Ingrese dia: ");
        nroDia = int.Parse(Console.ReadLine());

        switch (nroDia)
        {
            case < 3:
                valorCuota = valorCuota - (valorCuota * 0.03);
                break;
            case >= 6 and <= 10:
                valorCuota = valorCuota + (valorCuota * 0.01);
                break;
            case >= 11 and <= 20:
                valorCuota = valorCuota + (valorCuota * 0.12);
                break;
            case >= 21 and <= 31:
                valorCuota = valorCuota + (valorCuota * 0.15);
                break;
        }

        Console.WriteLine($"El valor de la cuota para el dia de pago es: {valorCuota}");

    }


    /*Creamos un metodo que pida el nombre y apellido del usuario
    y posteriormente lo salude con "Bienvenido [Apellido], [Nombre]*/

    private static void PedirNombreYSaludar()
    {

        /* Declaramos las variables */
        string nombre, apellido;
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese su Apellido: ");
        apellido = Console.ReadLine();
        //Console.WriteLine("Bienvenido " + apellido + ", " + nombre);
        Console.WriteLine($"Bienvenido {apellido}, {nombre}");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkBlue;


    }

    /*Creamos un metodo que nos pida los años, meses y dias de vida
    y muestre al final la cantidad total de dias de vida*/

    private static void CalcularDiasdeVida()
    {

        int años, meses, dias, diasDeVida;
        Console.Write("Ingrese la cantidad de años que tiene: ");
        años = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de meses que tiene: ");
        meses = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad de dias que tiene: ");
        dias = int.Parse(Console.ReadLine());

        diasDeVida = (años * 365) + (meses * 30) + dias;
        Console.WriteLine($"Sus dias de vida son {diasDeVida}");

    }

    public static int CalcularDiasDeVida(int dias, int meses, int años)
    {
        int diasDeVida;
        diasDeVida = (años * 365) + (meses * 30) + dias;
        return diasDeVida;
    }

    private static void Triangulos()
    {
        int lado1, lado2, lado3;
        Console.Write("Ingrese el primer lado: ");
        lado1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo lado: ");
        lado2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer lado: ");
        lado3 = int.Parse(Console.ReadLine());

        if (lado1 == lado2 && lado2 == lado3)
            Console.WriteLine("Es un triangulo Equilatero");
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            Console.WriteLine("Es un triangulo Isósceles");
        else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            Console.WriteLine("Es un triangulo Escaleno");
    }
    //public static string Triangulos(int lado1, int lado2, int lado3)
    //{
    //    if (lado1 == lado2 && lado2 == lado3)
    //       return "Equilatero";
    //    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    //        return "Isósceles";
    //    else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
    //        return "Escaleno";
    //}

    private static void menorDeCuatro()
    {
        int num1, num2, num3, num4;
        Console.Write("Ingrese el primer numero: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        num3 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el cuarto numero: ");
        num4 = int.Parse(Console.ReadLine());

        if (num1 < num2 && num1 < num3 && num1 < num4)
            Console.WriteLine($"El numero {num1} es el menor entre los 4, primer valor ingresado");
        else if (num2 < num1 && num2 < num3 && num2 < num4)
            Console.WriteLine($"El numero {num2} es el menor entre los 4, segundo valor ingresado");
        else if (num3 < num1 && num3 < num2 && num3 < num4)
            Console.WriteLine($"El numero {num3} es el menor entre los 4, tercer valor ingresado");
        else if (num4 < num1 && num4 < num3 && num4 < num2)
            Console.WriteLine($"El numero {num4} es el menor entre los 4, cuarto valor ingresado");

    }
    private static void mostrarHoras()
    {
        int horasTrabajadas;
        string dia;
        Console.Write("Ingrese las horas trabajadas: ");
        horasTrabajadas = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el dia de hoy: ");
        dia = Console.ReadLine();

        int horasFaltantes = 5 - horasTrabajadas;

        if (dia == "Jueves" || dia == "jueves")
            Console.WriteLine($"Faltan {horasFaltantes + 2} horas restantes");
        else
            Console.WriteLine($"Faltan {horasFaltantes} horas restantes");
    }
    #endregion
}
