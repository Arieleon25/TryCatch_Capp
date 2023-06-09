﻿using System;
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
           
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numList)
                {
                    int total = num / userInput;
                    Console.WriteLine(total);
                }
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
            finally
            {
                Console.WriteLine("Program has emerged from try/catch block and continued on with program execution.");
                Console.ReadLine();
            }
            //Console.WriteLine("Program has emerged from try/catch block and continued on with program execution.");
            //Console.ReadLine();
        }
    }
}
