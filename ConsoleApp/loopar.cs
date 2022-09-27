using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class loopar
    {
        public static void ForExample()
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++) {

                int j = random.Next(1, 101);
                numbers[i] = j;
                Console.WriteLine("Tal" + i + "är" + j);
            }
            Console.WriteLine("Klar");
            ForEachExample(numbers);
        }

        static void ForEachExample(int[] num)
        {
            foreach(int i in num)
            {
                Console.WriteLine("Tal är" + i);
            }
        }

        public static void WhileExample()
        {
            string password = "GodJul";
            bool youPass = false;

            Console.WriteLine("Ange lösenord");
            while (youPass == false)
            {
                string pass = Console.ReadLine();
                if (pass == password)
                {
                    youPass = true;
                }
                else
                {
                    Console.WriteLine("Fel lösen - försök igen!");
                }
            }
            Console.WriteLine("Grrattis - du är inloggad!");
        }

        public static void LooparUppgift()
        {
            for(int i = 10; i>0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("NU KÖR VI");
        }

      public static void LooparGissa()
        {
            bool dittSvar = false;

            Random random = new Random();
            int svar = random.Next(1, 101);

            Console.WriteLine("Skriv in ett tal mellan 1 -100");
            Console.WriteLine(svar);
            
            while (dittSvar == false)
            {
                string k = Console.ReadLine();
                int j = int.Parse(k);
                if (svar > j)
                {
                    Console.WriteLine("för lågt");
                }
                else if(svar == j)
                {
                    dittSvar = true;
                    Console.WriteLine("Grattis du gissade rätt");
                }
                else
                {
                    Console.WriteLine("för högt");
                }

           
            }
        


        }
    }
}
