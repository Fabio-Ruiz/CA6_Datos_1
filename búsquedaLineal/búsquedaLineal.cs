public class Program
{
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        // Si el número no está, retorna -1
        return -1;
    }


    // Lo siguiente es para realizar una prueba rápida
    public static void Main()
    {
        // Arreglo desordenado
        int[] arr1 = { 15, 13, 99, 36, 22, 71, 1, 27, 72 };
        int target1 = 72;

        // Ejemplo de búsqueda lineal
        int resultLinear = LinearSearch(arr1, target1);
        if (resultLinear != -1)
        {
            Console.WriteLine($"Búsqueda Lineal: {target1} encontrado en índice: {resultLinear}");
        }
        else
        {
            Console.WriteLine($"Búsqueda Lineal: {target1} no encontrado.");
        }

        // Ejemplo de búsqueda lineal con un número que no está
        target1 = 10;
        resultLinear = LinearSearch(arr1, target1);
        if (resultLinear != -1)
        {
            Console.WriteLine($"Búsqueda Lineal: {target1} encontrado en índice: {resultLinear}");
        }
        else
        {
            Console.WriteLine($"Búsqueda Lineal: {target1} no encontrado.");
        }
    }
}