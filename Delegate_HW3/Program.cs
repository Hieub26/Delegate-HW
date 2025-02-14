namespace Delegate_HW3
{
    internal class Program
    {
        delegate bool Predicate(int x);
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Odd numbers:");
            Filter(array, x => x % 2 != 0);
            Console.WriteLine("Even numbers:");
            Filter(array, x => x % 2 == 0);
            Console.WriteLine("Numbers greater than 5:");
            Filter(array, x => x > 5);
        }
        static void Filter(int[] array, Predicate predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
