using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Capp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>() { 4, 6, 9, 12, 20, 40, 50 };
            Console.WriteLine("Divide List numbers by: ");

            foreach (int num in numList)
            {
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    int total = num / userInput;
                    Console.WriteLine(total);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please type a whole number");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("please don't divide by zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //finally
                //{
                //    Console.ReadLine();
                //}
            }
            Console.ReadLine();
        }
    }
}
