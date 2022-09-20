using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Array
    {
        public static void Start()
        {

            Random r = new Random();
            string[] someInt = new string[7];
            someInt[0] = "Yo mama's so fat, when she fell I didn't laugh, but the sidewalk cracked up.";
            someInt[1] = "Yo mama's so fat, when she skips a meal, the stock market drops.";
            someInt[2] = "Yo mama's so fat, it took me two buses and a train to get to her good side.";
            someInt[3] = "Yo mama's so fat, when she goes camping, the bears hide their food.";
            someInt[4] = "Yo mama's so fat, if she buys a fur coat, a whole species will become extinct.";
            someInt[5] = "Yo mama's so fat, she stepped on a scale and it said: To be continued.";
            someInt[6] = "Yo mama's so fat, I swerved to miss her in my car and ran out of gas.";
            Console.WriteLine(someInt[r.Next(0, 7)]);
        }
    }
}
