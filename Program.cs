namespace _7._1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 5, 4, 1 };
            SelectionSort(array);
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }

        public static void SelectionSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                //loop to find index less than i
                for (int j = i + 1; j < array.Length; j++)
                {
                    //update min index
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    //swap if differnt from i
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
