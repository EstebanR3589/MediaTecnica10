using System;

namespace CalculadoraDeCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();

            int cantidadCaracteres = frase.Length;

            Console.WriteLine($"La frase '{frase}' tiene {cantidadCaracteres} caracteres.");
        }
    }
}
