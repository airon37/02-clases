using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int ejercicio = -1;
        do
        {
            Console.WriteLine("0. Manejar fechas");
            Console.WriteLine("1. Clase Libros");
            Console.WriteLine("2. Alquiler puerto");
            Console.WriteLine("3. Salir");
            ejercicio = Convert.ToInt32(Console.ReadLine());
            switch (ejercicio)
            {
                case 0:
                    Ejercicio1();
                    break;
                case 1:
                    Ejercicio2();
                    break;
                case 2:
                    Ejercicio3();
                    break;
                case 3:
                    Console.WriteLine("Hasta la proxima");
                    break;
                default:
                    Console.WriteLine("introduca un numero valido");
                    break;
            }
        } while (ejercicio != 3);
    }


    //ejercicio 1
    static void Ejercicio1()
    {
        int select;
        do
        {
            Console.WriteLine("Bienvenido a Manejar fechas");
            Console.WriteLine("0. Dia semana");
            Console.WriteLine("1. Incrementar Fecha");
            Console.WriteLine("2. Diferencia Fechas");
            Console.WriteLine("3. Compara Fechas");
            Console.WriteLine("4. Mostrar fecha Formato Largo");
            Console.WriteLine("5. salir");
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 0:
                    diaSemana();
                    break;
                case 1:
                    IncrementarFecha();
                    break;
                case 2:
                    DiferenciaFecha();
                    break;
                case 3:
                    ComparaFechas();
                    break;
                case 4:
                    MosLargo();
                    break;
                case 5:
                    Console.WriteLine("Hasta la proxima");
                    break;
                default:
                    Console.WriteLine("introduca un numero valido");
                    break;
            }
        } while (select != 5);
    }

    private static void diaSemana()
    {
        Console.WriteLine("Escribe el dia");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el mes");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el año");
        int anio = Convert.ToInt32(Console.ReadLine());
        DateTime fecha = new DateTime(anio, mes, dia);
        Console.WriteLine(fecha.ToString("dddd", new CultureInfo("es-Es")));
    }

    static void IncrementarFecha()
    {
        Console.WriteLine("Escribe el dia");
        int dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el mes");
        int mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el año");
        int anio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el numero de dias que quieras incrementar");
        int aux = Convert.ToInt32(Console.ReadLine());
        DateTime fecha = new DateTime(anio, mes, dia);
        fecha.AddDays(aux);
        Console.WriteLine(fecha.ToString("dd/M/yyyy", CultureInfo.InvariantCulture));
    }
    static void DiferenciaFecha()
    {
        Console.WriteLine("Escribe el dia de primera fecha");
        int dia1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el mes de primera fecha");
        int mes1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el año de primera fecha");
        int anio1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el dia de segunda fecha");
        int dia2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el mes de segunda fecha");
        int mes2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el año de segunda fecha");
        int anio2 = Convert.ToInt32(Console.ReadLine());
        DateTime fecha1 = new DateTime(anio1, mes1, dia1);
        DateTime fecha2 = new DateTime(anio2, mes2, dia2);
        Console.WriteLine("El resultado es "+ (fecha1 - fecha2).ToString("dd/M/yyyy"));
    }
    static void ComparaFechas()
    {
        Console.WriteLine("Escribe el dia de primera fecha");
        int dia1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el mes de primera fecha");
        int mes1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el año de primera fecha");
        int anio1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el dia de segunda fecha");
        int dia2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el mes de segunda fecha");
        int mes2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe el año de segunda fecha");
        int anio2 = Convert.ToInt32(Console.ReadLine());
        DateTime fecha1 = new DateTime(anio1, mes1, dia1);
        DateTime fecha2 = new DateTime(anio2, mes2, dia2);
        int result =DateTime.Compare(fecha1, fecha2);
        if (result < 0)
            Console.WriteLine("la primera fecha es menor que la segunda");
        else if (result == 0)
            Console.WriteLine("la primera fecha es igual que la segunda");
        else
            Console.WriteLine("la primera fecha es mayor que la segunda");
    }
    static void MosLargo()
    {
        Console.WriteLine("Escribe la fecha en formato corto (“dd/mm/aa)");
        String fechatext = Console.ReadLine();
        DateTime fecha = DateTime.ParseExact(fechatext, "dd/mm/aa", new CultureInfo("es-Es"));
        Console.WriteLine(fecha.ToString("dddd, MMMM dd, yyyy", new CultureInfo("es-Es")));
    }

    //Ejercicio2
    static void Ejercicio2()
    {
        int select = 0;
        do
        {
            Console.WriteLine("Bienvenido a clase libros");
            Console.WriteLine("0. insertar libro");
            Console.WriteLine("1. ver libros");
            Console.WriteLine("2. modificar libro");
            Console.WriteLine("3. eliminar libro");
            Console.WriteLine("4. salir");
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 0:
                    
                    break;
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    Console.WriteLine("Hasta la proxima");
                    break;
                default:
                    Console.WriteLine("introduca un numero valido");
                    break;
            }
        } while (select != 4);
    }

    //Ejercicio3
    static void Ejercicio3()
    {

    }
}