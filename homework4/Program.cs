namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 3, 4, -5 };
            string[] strArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                strArr[i] = arr[i].ToString();
            }
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.Write(strArr[i] + " ");
            }
        }
    }
}
