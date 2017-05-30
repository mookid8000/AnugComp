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
            var iterations = list.Count * 2;

            int GetRandomIndex() => random.Next(list.Count);

            void SwapElements()
            {
                var (index1, index2) = (GetRandomIndex(), GetRandomIndex());

                (list[index2], list[index1]) = (list[index1], list[index2]);
            }

            while (iterations-- > 0)
            {
                SwapElements();
            }

            return list;
        }
    }
}