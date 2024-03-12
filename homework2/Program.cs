namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Ramazan", "Elnur", "Rehman", "Niyaz" };
            int n = Convert.ToInt32(Console.ReadLine());
            if(n >= 0 &&  n < arr.Length) 
            {
                for (int i = arr[n].Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[n][i]);
                }
            }
            else
            {
                Console.WriteLine("duzgun index daxil edin");
            }
 
        }
        
    }
}
