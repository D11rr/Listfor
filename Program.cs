﻿namespace Listfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("No of elements: " + primeNumbers.Count);

            var cities = new List<string>() ;
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Rome");
            cities.Add(null);

            Console.WriteLine("no of elements " + cities.Count);
        }
    }
}