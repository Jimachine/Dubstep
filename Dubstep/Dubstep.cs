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

                if (i != 0)
                {
                    input = input.Insert(i, " ");
                }
            }

            Console.WriteLine(input);
            return input;
        }
    }
}
