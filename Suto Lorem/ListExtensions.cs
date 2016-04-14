using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    internal static class ListExtensions
    {
        static Random rand = new Random();
        internal static T GetRandom<T>(this List<T> list)
        {
            return list[rand.Next(list.Count)];
        }
    }
}
