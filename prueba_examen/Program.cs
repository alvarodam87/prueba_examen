using System;
//En el metodo Main de tu Console App, usando la clase Libro del ejercicio anterior:

class Program
{
    static void Main(string[] args)
    {
        // Crea una instancia de la clase Libro con valores de tu elección.
        Libro libro1 = new Libro("El Quijote", "Miguel de Cervantes", 1605, true);
        // Imprime la información del libro utilizando el método ToString().
        Console.WriteLine(libro1.ToString());
        // Cambia el estado de disponibilidad del libro a false.
        libro1.SetDisponible(false);
        // Imprime nuevamente la información del libro para reflejar el cambio en la disponibilidad.
        Console.WriteLine(libro1.ToString());
    }
}
