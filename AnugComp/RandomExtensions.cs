using System;
using System.Collections.Generic;
using System.Linq;

namespace AnugComp
{
    public static class RandomExtensions
    {
        public static IEnumerable<T> InRandomOrder<T>(this IEnumerable<T> elements)
        {
            var list = elements.ToList();
            var random = new Random(DateTime.Now.GetHashCode());
            var iterations = list.Count;

            Action swapElements = () =>
            {
                var index1 = random.Next(list.Count);
                var index2 = random.Next(list.Count);
                var elem1 = list[index1];
                var elem2 = list[index2];
                list[index2] = elem1;
                list[index1] = elem2;
            };

            while (iterations-- > 0)
            {
                swapElements();
            }

            return list;
        }
    }
}