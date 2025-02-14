using System;

class Program
{
    // Método de búsqueda secuencial
    static int BusquedaSecuencial(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
                return i; // Retorna la posición donde se encontró
        }
        return -1; // Retorna -1 si no se encuentra
    }

    // Método de búsqueda binaria (requiere que el arreglo esté ordenado)
    static int BusquedaBinaria(int[] arreglo, int valor)
    {
        int izquierda = 0, derecha = arreglo.Length - 1;

        while (izquierda <= derecha)
        {
            int medio = (izquierda + derecha) / 2;

            if (arreglo[medio] == valor)
                return medio; // Se encontró el valor

            if (arreglo[medio] < valor)
                izquierda = medio + 1; // Buscar en la mitad derecha
            else
                derecha = medio - 1; // Buscar en la mitad izquierda
        }
        return -1; // No se encontró el valor
    }

    static void Main()
    {
        int[] numeros = { 3, 7, 12, 18, 25, 32, 45, 50, 64, 78 }; // Arreglo ordenado
        Console.WriteLine("Ingrese el número a buscar:");
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione el método de búsqueda:");
        Console.WriteLine("1. Búsqueda Secuencial");
        Console.WriteLine("2. Búsqueda Binaria");
        int opcion = int.Parse(Console.ReadLine());

        int resultado = (opcion == 1) ? BusquedaSecuencial(numeros, valor) : BusquedaBinaria(numeros, valor);

        if (resultado != -1)
            Console.WriteLine($"Número encontrado en la posición {resultado}");
        else
            Console.WriteLine("Número no encontrado");
    }
}
