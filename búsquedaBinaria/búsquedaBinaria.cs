public class Program
{
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        // Si el número no está, retorna -1
        return -1;
    }


    // Lo siguiente es para realizar una prueba rápida
    public static void Main()
    {
        

        // Arreglo ordenado
        int[] arr2 = { 10, 15, 23, 40, 78, 79, 85, 90, 91 };
        int target2 = 23;

        // Ejemplo de búsqueda binaria
        int resultBinary = BinarySearch(arr2, target2);
        if (resultBinary != -1)
        {
            Console.WriteLine($"Búsqueda Binaria: {target2} encontrado en índice: {resultBinary}");
        }
        else
        {
            Console.WriteLine($"Búsqueda Binaria: {target2} no encontrado.");
        }

        // Ejemplo de búsqueda binaria con un número que no está
        target2 = 100;
        resultBinary = BinarySearch(arr2, target2);
        if (resultBinary != -1)
        {
            Console.WriteLine($"Búsqueda Binaria: {target2} encontrado en índice: {resultBinary}");
        }
        else
        {
            Console.WriteLine($"Búsqueda Binaria: {target2} no encontrado.");
        }
    }
}