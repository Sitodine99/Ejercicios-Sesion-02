using System;

namespace EjerciciosSesion2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 01 //
            Console.WriteLine("Hola, ¿Cómo te llamas?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es tú primer apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tienes?");
            string edad = Console.ReadLine();
            int años = Convert.ToInt32(edad);
            int resultado = años + 5;
            Console.WriteLine("¿Sabes programar?");
            string respuesta = Console.ReadLine();

            Console.WriteLine("Te llamas " + nombre + ", te apellidas " + apellido + " tienes " + edad + " años y " + respuesta + " sabes programar.");
            Console.WriteLine("La suma de " + años + " más cinco es " + resultado);

            //Ejercicio 02//
            Coche micoche = new Coche();
            Console.WriteLine("El coche tiene " +micoche.puertas + " puertas, " + micoche.ruedas + " ruedas, es de la marca " + micoche.marca + " y pasó la ITV en " + micoche.FechaItv + ".");

            //Ejercicio 03//

            int x = 25;
            int y = 6;
            if (x > 18)
            {
                Console.WriteLine("La variable x es mayor que 15"); 
            }

            char a = 'a';

            if (a == 'a' && y == 6)
            {
                Console.WriteLine("A es a e y es 6.");
            }
            
            if (a != 'b' && y == 6)
            {
                Console.WriteLine("A no es b e y es 6");
            }
        }
    }
    //Ejercicio 02//

    public class Coche
    {
        public int puertas = 5;
        public int ruedas = 4;
        public string marca = "Hyundai";
        public int FechaItv = 2023;
    }
}

