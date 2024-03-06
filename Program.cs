using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

namespace Oppgave2
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            bool ofAge = false;

            Console.WriteLine("What is your age?");
            
            Console.WriteLine("ofAge is a " + ofAge.GetType().ToString());
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("you are " + age + " year's old.");
                if (age >= 18) 
                {
                    ofAge = true;
                    Console.WriteLine("you are of age to drink in Norway. Welcome.");
                }
                else
                {
                    var years = 18 - age;
                    Console.WriteLine("You are not of age, please come back in.. " + years + " years");
                    Console.WriteLine(years.GetType().ToString());
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("entered string is not a number. Please restart the program and use intergers. 0 - 9");
            }
            
            Console.WriteLine("\n");

            string[] largeStrings = { "hei", "på", "deg", "min", "gode", "venn" };

            foreach (string str in largeStrings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\n");

            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < numberArray.Count(); i++)
            {
                Console.WriteLine(i);
            }
            
            
        }
    }
    
}