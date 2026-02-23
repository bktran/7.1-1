namespace _7._1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    if (minIndex != i)
                    {
                        int temp = array[i];
                        array[i] = array[minIndex];
                        array[minIndex] = temp;
                    }
                }
            }
        }
    }
}
