using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task3 : IRunnable
    {
        private static Random random = new Random();
        private List<string> newList;
        private const int length = 4;
        private const int quantity = 100;

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static List<string> GenerateStrings()
        {
            List<string> generatedStrings = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                generatedStrings.Add(RandomString());
            }

            return generatedStrings;
        }

        private List<string> NewListWithoutZ(List<string> stringList)
        {
            List<string> resultList = new List<string>();
            for (int i = 0; i < stringList.Count; i++)
            {
                if(!stringList[i].StartsWith("Z"))
                    resultList.Add(stringList[i]);
            }
            return resultList;
        }

        private void DisplayPage(int pageNumber)
        {
            if(pageNumber > 20 || pageNumber < 0)
                return;
            for (int i = pageNumber - 1; i < pageNumber+ 4; i++)
            {
                Console.WriteLine(newList[i]);
            }
            
        }

        public void Run()
        {
            Console.WriteLine($"Initial lenght: {quantity}");
            List<string> generatedStrings = GenerateStrings();

            newList = NewListWithoutZ(generatedStrings);
            Console.WriteLine($"Items without Z char: {newList.Count}");

            //Descending sorting
            newList = newList.OrderByDescending(i => i).ToList();

            Console.Write("Input page number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            DisplayPage(input);

            Console.ReadKey();

        }

    }
}
