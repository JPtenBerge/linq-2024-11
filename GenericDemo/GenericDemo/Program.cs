﻿using System.Collections;

namespace GenericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tekst = "Hallo ik ben JP en ik heb er zin in";

            var dict = new Dictionary<char, int>();

            foreach (var charachter in tekst)
            {
                if (!dict.ContainsKey(charachter))
                {
                    dict.Add(charachter, 0);
                }

                dict[charachter]++;
            }


            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " komt " + pair.Value + " keer voor");
            }


            new GenericClass<int>();
            new GenericClass<string>();


            //new GenericClass<List<int>>();
        }
    }
}