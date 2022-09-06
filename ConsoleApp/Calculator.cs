using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Calculator
    {
        public static void CalcAge()
        {
            Console.WriteLine("Ange vilket år du är född");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            int myAge = DateTime.Now.Year - ageInt;
            int penFinal = 65 - myAge;
            Console.WriteLine("Du är " + myAge + "år gamal och har" + penFinal + "kvar år till pensionen");
        }

        public static void CalcMoms1()
        {
            Console.WriteLine("Skriv in priset på varan");
            string pris = Console.ReadLine();
            int prisInt = int.Parse(pris);

            Console.WriteLine("Skriv in moms");
            string moms = Console.ReadLine();
            int momsInt = int.Parse(moms);

            double momsReal = (momsInt * 0.01 + 1);
            double prisFinal = (momsReal * prisInt);
            Console.WriteLine("Nettopris blir:" + prisFinal + ":)");
        }

        public static void CalcMoms2()
        {
            Console.WriteLine("Skriv in priset på varan");
            string pris = Console.ReadLine();
            int prisInt = int.Parse(pris);

            Console.WriteLine("Skriv in moms");
            string moms = Console.ReadLine();
            int momsInt = int.Parse(moms);

            double tempPris = 0.01 * momsInt * prisInt;
            double finalPris = prisInt - tempPris;
            Console.WriteLine("Priset utan moms blir:" + finalPris + " :)");

        }
    }
}
