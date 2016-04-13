using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SutoLorem
{
    public static class ListExtensions
    {
        public static T GetRandom<T>(this List<T> list)
        {
            Random rand = new Random();
            return list[rand.Next(list.Count)];
        }
    }
}
