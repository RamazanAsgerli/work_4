namespace homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 23, 5, 30, 10 };
            int minNum = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if(minNum > nums[i])
                {
                    minNum = nums[i]; 
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
