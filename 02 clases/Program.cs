using _02_clases;
using System.Collections;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Security.Cryptography;

int ejercicio = -1;
do
{
    Console.WriteLine("0. Manejar fechas");
    Console.WriteLine("1. Clase Libros");
    Console.WriteLine("2. Salir");
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
            Console.WriteLine("Hasta la proxima");
            break;
        default:
            Console.WriteLine("introduca un numero valido");
            break;
    }
} while (ejercicio != 3);


//ejercicio 1
void Ejercicio1()
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

void diaSemana()
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

void IncrementarFecha()
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
void DiferenciaFecha()
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
    Console.WriteLine("El resultado es " + (fecha1 - fecha2).ToString("dd/M/yyyy"));
}
void ComparaFechas()
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
    int result = DateTime.Compare(fecha1, fecha2);
    if (result < 0)
        Console.WriteLine("la primera fecha es menor que la segunda");
    else if (result == 0)
        Console.WriteLine("la primera fecha es igual que la segunda");
    else
        Console.WriteLine("la primera fecha es mayor que la segunda");
}
void MosLargo()
{
    Console.WriteLine("Escribe la fecha en formato corto (“dd/mm/aa)");
    String fechatext = Console.ReadLine();
    DateTime fecha = DateTime.ParseExact(fechatext, "dd/mm/aa", new CultureInfo("es-Es"));
    Console.WriteLine(fecha.ToString("dddd, MMMM dd, yyyy", new CultureInfo("es-Es")));
}

//Ejercicioo2
void Ejercicio2()
{
    int select = 0;
    ArrayList biblioteca = new ArrayList();
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
                biblioteca = InsertarLibro(biblioteca);
                Console.WriteLine("libro añadido");
                break;
            case 1:
                for (int i = 0; i < biblioteca.Count; i++)
                {
                    Libro aux = (Libro)biblioteca[i];
                    Console.WriteLine("libro" + i);
                    Console.WriteLine("Titulo: " + aux.Titulo + "Autor: " + aux.Autor + "Estilo: " + aux.Estilo + "Editorial" + aux.Editorial);
                }
                break;
            case 2:
                modificarLibro(biblioteca);
                break;
            case 3:
                Console.WriteLine("Introduce la posicion del libro que desea eliminar");
                int posicion = Convert.ToInt32(Console.ReadLine());
                biblioteca.RemoveAt(posicion);
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

ArrayList modificarLibro(ArrayList biblioteca)
{
    int select;
    String dato;
    Console.WriteLine("introduce la posicion del libro");
    int pos = Convert.ToInt32(Console.ReadLine());
    Libro aux1 = (Libro)biblioteca[pos];
    do
    {
        Console.WriteLine("1. Modificar titulo");
        Console.WriteLine("2. Modificar autor");
        Console.WriteLine("3. Modificar estilo");
        Console.WriteLine("4. Modificar editorial");
        Console.WriteLine("5. salir");
        select = Convert.ToInt32(Console.ReadLine());
        switch (select)
        {
            case 1:
                Console.WriteLine("Introduce el nuevo titulo");
                dato = Console.ReadLine();
                aux1.Titulo = dato;
                break;
            case 2:
                Console.WriteLine("Introduce el nuevo autor");
                dato = Console.ReadLine();
                aux1.Autor = dato;
                break;
            case 3:
                Console.WriteLine("Introduce el nuevo estilo");
                dato = Console.ReadLine();
                aux1.Estilo = dato;
                break;
            case 4:
                Console.WriteLine("Introduce la nueva editorial");
                dato = Console.ReadLine();
                aux1.Editorial = dato;
                break;
            case 5:
                Console.WriteLine("Libro modificado");
                break;
            default:
                Console.WriteLine("introduca un numero valido");
                break;
        }
    }while (select != 4);
    biblioteca[pos]=aux1;
    return biblioteca;
}

ArrayList InsertarLibro(ArrayList biblioteca)
{
    Console.WriteLine("introduce el titulo del libro");
    String titulo = Console.ReadLine();
    Console.WriteLine("introduce el autor del libro");
    String autor = Console.ReadLine();
    Console.WriteLine("introduce el estilo del libro");
    String estilo = Console.ReadLine();
    Console.WriteLine("introduce la editorial del libro");
    String editorial = Console.ReadLine();
    Libro aux = new Libro(titulo, autor, estilo, editorial);
    biblioteca.Add(aux);
    return new ArrayList();
}