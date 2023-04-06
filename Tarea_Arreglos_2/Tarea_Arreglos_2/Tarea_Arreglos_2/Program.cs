using System;

public class Program
{
    static void Main(string[] args)
    {
        const int MaximoAlumnos = 6;

        string[] nombres = new string[MaximoAlumnos];
        int[] puntajes = new int[MaximoAlumnos];

        int cantidadAlumnos = 0;

        while (cantidadAlumnos < MaximoAlumnos)
        {
            Console.Write("Ingrese el nombre del alumno " + (cantidadAlumnos + 1) + ": ");
            nombres[cantidadAlumnos] = Console.ReadLine();

            Console.Write("Ingrese el puntaje del alumno " + (cantidadAlumnos + 1) + ": ");
            puntajes[cantidadAlumnos] = int.Parse(Console.ReadLine());

            cantidadAlumnos++;
        }

        int puntajeMaximo = puntajes[0];
        int puntajeMinimo = puntajes[0];

        foreach (int puntaje in puntajes)
        {
            if (puntaje > puntajeMaximo)
            {
                puntajeMaximo = puntaje;
            }

            if (puntaje < puntajeMinimo)
            {
                puntajeMinimo = puntaje;
            }
        }

        Console.WriteLine("Los puntajes son: ");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine(nombres[i] + " = " + puntajes[i]);
        }

        Console.WriteLine("El puntaje máximo es: " + puntajeMaximo);
        Console.WriteLine("El puntaje mínimo es: " + puntajeMinimo);
    }
}
