using System;

namespace FASE_3
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

            string[] arrayCities = { city1, city2, city3, city4, city5, city6 };
            string[] arrayCitiesModify = new string[arrayCities.Length];

            for (int i = 0; i < arrayCities.Length; i++)
            {
                arrayCitiesModify[i] = arrayCities[i].Replace('a', '4');
            }

            Array.Sort(arrayCitiesModify);

            Console.WriteLine("\nArray modificat i ordenat");
            for (int i = 0; i < arrayCitiesModify.Length; i++)
            {
                PrintCity(arrayCitiesModify[i]);
            }

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
    }
}
