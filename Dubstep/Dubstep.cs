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
            

            //for (int c = 0; c < input.Length; c++)
            //{
            //    if (input.Contains("WUB") & input[c] == 'W' & input[c + 1] == 'U' & input[c + 2] == 'B')
            //    {
            //        input = input.Remove(c, 3);
            //        c = -1;
            //    }
            //    else if (!input.Contains("WUB"))
            //    {
            //        break;
            //    }
            //}
            while (input.Contains("WUB"))
            {
                int i = input.IndexOf("WUB");
                
                input = input.Remove(i, 3);
            }

            Console.WriteLine(input);
            return input;
        }
    }
}
