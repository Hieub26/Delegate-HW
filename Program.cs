namespace Delegate_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 3, 8, 4, 2 };
            int[] array2 = { 5, 7, 4, 8, 3, 1 };

            Action<int[]> action = BubbleSort;
            action(array1);
            action = Quicksort;
            action(array2);

            Console.WriteLine("Sorted array: " + string.Join(", ", array1));
            Console.WriteLine("Sorted array: " + string.Join(", ", array2));
        }
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void Quicksort(int[] array)
        {
            Quicksort(array, 0, array.Length - 1);
        }

        static void Quicksort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                Quicksort(array, low, pi - 1);
                Quicksort(array, pi + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
