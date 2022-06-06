using System;
using System.Collections.Generic;

namespace iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i <testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);

            //    }


            //}
            //Console.ReadLine();

            //string[] name = { "Jesse", "Hunter", "Erik", "Daniel" };
            //for(int j = 0; j< name.Length; j++)
            //{
            //    if (name[j] == "Jesse")
            //    {
            //        Console.WriteLine(name[j]);
            //    }
            //}


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names)
            {
                if (name == "Jesse")
                {
                    Console.WriteLine(name);
                }
            } Console.ReadLine();


            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingSCores = new List<int>();
            foreach (int score in testScores)
            {
                if(score > 85)
                {
                    passingSCores.Add(score);
                }
            }
            Console.WriteLine(passingSCores.Count);
            Console.ReadLine();
        }
    }
}
