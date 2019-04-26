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
            // if index 0 is W, is index 2 U and index 3 B?
            string decodedString = input;
            int test = input.Length;

            while (decodedString.Contains("WUB"))
            {
                for (int c = 0; c < decodedString.Length; c++)
                {
                    if (decodedString[c] == 'W' & decodedString[c + 1] == 'U' & decodedString[c + 2] == 'B')
                    {
                        decodedString = decodedString.Remove(c, 3);
                        c = 0;
                    }
                }
            }
            Console.WriteLine(decodedString);
            return decodedString;
        }
    }
}
