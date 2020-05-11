using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var balls = new List<int>();
            var stars = new List<int>();

            for(int i = 1; i <= 50; i++)
            {
                balls.Add(i);
            }

            for(int i = 1; i <= 12; i++)
            {
                stars.Add(i);
            }

            foreach (var ball in balls)
                    {
                    Console.Write($"{ball} ");
                    }

            Console.WriteLine();

            foreach (var star in stars)
                    {
                    Console.Write($"{star} ");
                    }

            Console.WriteLine();

            for (int j = 1; j <= 5; j++)
            {
            balls.Shuffle();
            int k = Randomiser.rng.Next(balls.Count); 
            Console.WriteLine($"Ball {j} is {balls[k]}.");
            balls.RemoveAt(k);
            }
            
            for (int j = 1; j <= 2; j++)
            {
            stars.Shuffle();
            int k = Randomiser.rng.Next(stars.Count); 
            Console.WriteLine($"Star {j} is {stars[k]}.");
            stars.RemoveAt(k);
            }

            foreach (var ball in balls)
                    {
                    Console.Write($"{ball} ");
                    }
            Console.WriteLine();

            foreach (var star in stars)
                    {
                    Console.Write($"{star} ");
                    }
            Console.WriteLine();
        }

    }

    public static class Randomiser
        {
        public static Random rng = new Random();
        }

    public static class Shuffler
        {
            public static void Shuffle<T>(this IList<T> list)  
            {  
                for (int i = 0; i <= 1000; i++)
                {
                int n = list.Count;  
                while (n > 1)
                {  
                n--;  
                int k = Randomiser.rng.Next(n + 1);  
                T value = list[k];  
                list[k] = list[n];  
                list[n] = value;  
                }  
                }
            }   
        }   

}
