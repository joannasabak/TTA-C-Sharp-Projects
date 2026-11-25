using System;
using System.Collections.Generic;
class Iterations
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine($"Passing test score: {testScores[i]}");
        //    }
        //}
        //Console.ReadLine();


        //string[] names = { "Jesse", "Joanna", "Guillaume", "Kotowka" };

        //for (int j=0; j < names.Length; j++)
        //{
        //    if (names[j] == "Jesse")
        //    {
        //        Console.WriteLine($"The name at index {j} is Jesse");
        //    }
        //}

        List<int> testScores = new List<int>();
        testScores.Add(98);
        testScores.Add(99);
        testScores.Add(98);
        testScores.Add(81);
        testScores.Add(54);
        testScores.Add(70);


        foreach (int score in testScores)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing score: " + score);
            }
        }

        List<string> names = new List<string>() { "Jesse", "Joanna", "Guillaume", "Kotowka" };
        List<string> cats = new List<string>();


        foreach (string name in names)
        {
            if (name == "Kotowka")
            {
                cats.Add(name);              
            }
        }

        Console.WriteLine(cats.Count);
        Console.WriteLine(string.Join("", cats));
    }
}