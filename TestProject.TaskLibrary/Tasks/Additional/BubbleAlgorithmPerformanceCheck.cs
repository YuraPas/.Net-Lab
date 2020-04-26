using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Additional
{

    public interface ISortAlgorithm
    {
        void Sort(int[] array);
    }

    public class BubbleSort : ISortAlgorithm
    {

        public void Sort(int[] array)
        {
            Console.WriteLine("BubbleSort: ");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }


    public class OptimizedBubbleSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Optimized BubbleSort: ");
            int length = array.Length;
            int temp = array[0];

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }


    public class BubbleAlgorithmPerformanceCheck : IRunnable
    {

        private static void Initialize(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-1000, 1000);
            }
        }


        public void Run()
        {
            var array = new int[2000];
            var arrayCopy = new int[2000];

            var timer = new Stopwatch();

            BubbleSort bubbleSort = new BubbleSort();
            OptimizedBubbleSort optimizedBubbleSort = new OptimizedBubbleSort();


            Initialize(array);
            Array.Copy(array, arrayCopy, 2000);


            timer.Start();
            bubbleSort.Sort(array);
            timer.Stop();

            Console.WriteLine(timer.ElapsedTicks);

            timer.Restart();
            optimizedBubbleSort.Sort(array);
            timer.Stop();

            Console.WriteLine(timer.ElapsedTicks);

            //Results : 
            //First Run : n = 2000
            //BubbleSort:            71450
            //Optimized BubbleSort:  21833

            //Second Run: n = 2000
            //BubbleSort:            83966
            //Optimized BubbleSort:  22682

            //Third Run: n = 5
            //BubbleSort:            12201
            //Optimized BubbleSort:  671


            // On the smal arrays difference is more significant ( around 10x-15x )

            //The algorithm colmplexity is the same O(n^2)
            //I think the maid point is memory usage.Every time in Bubble sort in for loop we are accsesing array lenght
            //but in optimized sort we assing value to vaiable and in if statement in simple sort
            //we are cleating local variable temp every time the statement is correct
            // but in optimized we created separate variale for that purpose.
            Console.ReadKey();

        }
    }
}
