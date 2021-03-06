﻿using System;

namespace FASE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string city1, city2, city3, city4, city5, city6;

            city1 = CityName();
            city2 = CityName();
            city3 = CityName();
            city4 = CityName();
            city5 = CityName();
            city6 = CityName();

            Console.WriteLine("\nMostrem ciutats introduÏdes");
            PrintCity(city1);
            PrintCity(city2);
            PrintCity(city3);
            PrintCity(city4);
            PrintCity(city5);
            PrintCity(city6);

            char[] arrayCity1 = new char[city1.Length];
            char[] arrayCity2 = new char[city2.Length];
            char[] arrayCity3 = new char[city3.Length];
            char[] arrayCity4 = new char[city4.Length];
            char[] arrayCity5 = new char[city5.Length];
            char[] arrayCity6 = new char[city6.Length];

            arrayCity1 = city1.ToCharArray();
            arrayCity2 = city2.ToCharArray();
            arrayCity3 = city3.ToCharArray();
            arrayCity4 = city4.ToCharArray();
            arrayCity5 = city5.ToCharArray();
            arrayCity6 = city6.ToCharArray();

            Console.WriteLine("\nArrays amb els noms invertits");
            PrintCityReverse(arrayCity1);
            PrintCityReverse(arrayCity2);
            PrintCityReverse(arrayCity3);
            PrintCityReverse(arrayCity4);
            PrintCityReverse(arrayCity5);
            PrintCityReverse(arrayCity6);

        }
        static string CityName()
        {
            Console.WriteLine("Introdueix el nom d'una ciutat:");
            return Console.ReadLine();
        }

        static void PrintCity(string city)
        {
            Console.WriteLine(city);
        }

        static void PrintCityReverse(char[] arrayCity)
        {
            Array.Reverse(arrayCity);

            for (int i = 0; i < arrayCity.Length; i++)
            {
                Console.Write(arrayCity[i]);
            }
            Console.WriteLine();
        }
    }
}
