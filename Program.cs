using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felsökning_Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //maximillian Lunbdberg Chas Academy .NET 2024

            //------------------------------------------------ Case 1 ------------------------------------------------------

            // Det saknades ett semicolon efter Concole.writeline i första if statmentet och else if hadde inget mellanrum (elseif)

            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre");
            }
            else if (number < 3)
            {
                Console.WriteLine("Talet är mindre än tre");
            }

            //------------------------------------------------ Case 2 ------------------------------------------------------

            // Jag ändrade mindre än teknet (<) efter 100 till ett mindre en ELLER LIKAMED teken (<=)


            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            //------------------------------------------------ Case 3 ------------------------------------------------------

            // Dom lokala variablarna i och j saknar en "acction to perform" i slutet av for loopen, jag la till ++ som "action to perform" på i och j 
            // när du skriver en for loop kan du ha 3 saker
            // 1. deklarera en variabel (och dess värde om det behövs), i deta fall int i = 1 och int j =1
            // 2. ett Logiskt condition som måste uppflylas för att loppen ska köras, i <= 5 och j <= i
            // 3. en "action to performe" som görs i slutet av loopen, felet var att det inte fans någon action, uttan bara variabelnamnet

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //------------------------------------------------ Case 4 ------------------------------------------------------
  
            // Koden har ingen output eftersom både C.write och C.Writeline var toma 
            // jag la till j variabeln i C.Write så användaren kan se att forloopen räknar
            // och i While loopen la jag till ett ett meddelande som säger hur många gånger while lopen har körts inom whileloopen
            // Jag valde att skrivva utt dom sakerna eftersom det låter en se vad programet göt när man kör det

            int q = 1;
            while (q <= 5)
            {
                for (int j = 1; j <= q; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine($"\nthe for loop ran {q} times");
                q++;
            }

            // PS: var tvungen att ändra i till 1 eftersom i användes i koden ovanför också

            //------------------------------------------------ Case 5 ------------------------------------------------------


            // Jag la till ett breakstatment i Case 1, om det inte finns ett breakstatment under varje case och om caset är tomt
            // så kommer programmet automatiskt hoppa till nästa case så att den kan exita,
            // Du skulle kuna göra samma sak genom att ta bort allt i case 2, ändra P till 2 och då kommer koden hoppa till default ist

            int P = 1;

            switch (P)
            {
                case 1:
                    Console.WriteLine("\nyou nead a break statment, or else you can exit the case!\nI fixed that so now you can read this message");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            //------------------------------------------------ Case 6 ------------------------------------------------------
            //
            // jag ändrade = i if statmentet till ==
            // i programering bettyder = "gets" och == bettyder likamed(=)
            // gets skickar värdet från höger sidan till vänster om = teknet
            // medans == är en logisk jämförare som ger ett true eller false svar

            int T = 10;

            if (T == 5)
            {
                Console.WriteLine("i är 5");
            }


        }
    }
}
