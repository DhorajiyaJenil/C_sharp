/*Write a program to Create a divide by zero exception and handle it*/

namespace ConsoleApp1
{
    internal class L4P1
    {
        public static void Main(string[] args)
        {
            int a, b = 0;
            Console.WriteLine("Enter value a:");
            a = Convert.ToInt32(Console.ReadLine());

            try
            {
                int ans = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
