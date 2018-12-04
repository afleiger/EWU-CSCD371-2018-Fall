using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAnalyzer
{
    public static class PatentDataAnalyzer
    {
        public static List<string> InventorNames(string country)
        {
            List<string> result = PatentData.Inventors
                .Where(i => i.Country.Equals(country))
                .Select(i => i.Name).ToList();

            return result;
        }

        public static List<string> InventorLastNames()
        {
            List<string> result = PatentData.Inventors
                .OrderByDescending(i => i.Id)
                .Select(i => i.Name.Split().Last()).ToList();

            return result;
        }

        public static string LocationsWithInventors()
        {
            string result = string.Join(',', PatentData.Inventors
                .Select(i => $"{i.State}-{i.Country}")
                .Distinct());

            return result;
        }
    }

    public static class Enumerable
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> enumerable)
        {
            List<T> original = enumerable.ToList();
            Random rand = new Random();

            while(original.Any())
            {
                int nextIndex = rand.Next(0, original.Count);
                T item = original[nextIndex];
                original.RemoveAt(nextIndex);

                yield return item;
            }
        }
    }
}
