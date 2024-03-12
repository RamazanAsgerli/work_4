namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 3, 4, -5 };
            int[] array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = arr[i]*-1;
                }
                array[arr.Length - 1 - i] = arr[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }
}
