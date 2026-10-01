namespace Array_sum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            Console.WriteLine($"The sum of the numbers is: {sum}");
            //int[] number = {10, 20, 30};
            //int sum = 0;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}
