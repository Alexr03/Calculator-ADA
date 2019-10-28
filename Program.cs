using System;
using FirstAdaTask.Databases;
using FirstAdaTask.Utilities;

namespace FirstAdaTask
{
    internal class Program
    {
        public static readonly MiniDb GlobalDb = new MiniDb();
        
        public static void Main(string[] args)
        {
            Console.WriteLine("ADA Program");

            GlobalDb.SetValue(MiniDb.PredefinedKeys.Name, InputUtilities.GetResponse("Please enter your name: "));
            Console.WriteLine($"Hello {GlobalDb.GetValue(MiniDb.PredefinedKeys.Name)}!");
            
            new Menu().InitiateMenu();

//            var numbers =
//                InputUtilities.GetResponseArray("Please enter a list of numbers separated by a ',' to sum together.");
//
//            Console.WriteLine("Answer: " + SumOfNumbers(numbers));
        }
    }
}