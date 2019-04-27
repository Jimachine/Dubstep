using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dubstep
{
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            while (input.Contains("WUB"))
            {
                int i = input.IndexOf("WUB");
                input = input.Remove(i, 3);
                input = input.Insert(i, " ");
                int newI = input.IndexOf("WUB");
            }
            input = input = input.Trim(' ');

            while (input.Contains("  "))
            {
                int i = input.IndexOf("  ");
                input = input.Remove(i, 1);
            }
            Console.WriteLine(input);
            return input;
        }
    }
}
