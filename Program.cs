using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool utflykt = true;
            while (utflykt)
            {
                Console.WriteLine("=== UTFLYKTSKALKYLATOR ===");

                Console.Write("Hur många personer ska följa med? ");
                Console.WriteLine("Skriver du fel, väljs automatiskt 1 person.");
                //Antal blir nu alltid en int.
                int antal = int.TryParse(Console.ReadLine(), out antal) ? antal : 1;

                //Ingen som ska med, avbryter spelet.
                if (antal == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Jaså... ingen ska med.");
                    Console.WriteLine("slut. (Tråkig ending)");
                    break;
                }
                // Minus easter egg.
                else if (antal < 0)
                {
                    Console.WriteLine("Jaså... du vill leka med djävulen? :,)");
                    Console.WriteLine("Slå en tärning för ditt liv, du måste få en sexa");
                    Console.WriteLine("Tryck på en tangent för att slå tärningen...");
                    Console.ReadKey();
                    Console.WriteLine("HAHAHAHAHAH DU TRODDE, DU ÄR DÖDENS NU!");
                    Console.WriteLine("Du är död och brinner i helvetet.");
                    Console.WriteLine("slut. (Hellvetes ending)");
                    break;
                }
                else if ((0 < antal) && (antal < 5))
                {
                    Console.WriteLine("Du valde " + antal + " personer till att följa med på utflykten.");
                }
                else
                {
                    Console.WriteLine("Sweet! Du får en rabatt :)");
                }


                    Console.Write("Vad kostar resan per person? ");
                int resa = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vad kostar maten per person? ");
                int mat = Convert.ToInt32(Console.ReadLine());

                // Räknar ut kostnaden för en person.
                int kostnadPerPerson = resa + mat;

                // Räknar ut kostnaden för hela gruppen.
                int totalKostnad = kostnadPerPerson * antal;

                Console.WriteLine("");

                //Grupprabatt
                if (antal > 4)
                {
                    kostnadPerPerson -= 100 / antal;
                    totalKostnad -= 100;
                    Console.WriteLine();
                    Console.WriteLine("Kostnad per person: " + kostnadPerPerson + " kr, mycket billigare tack vare din rabatt...");
                    Console.WriteLine("Total kostnad: " + totalKostnad + " kr tack vare din läckra rabatt :)");
                    Console.WriteLine("slut. (Rabatt ending) OBS! Det finns flera endings...");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Kostnad per person: " + kostnadPerPerson + " kr");
                    Console.WriteLine("Total kostnad: " + totalKostnad + " kr");
                    Console.WriteLine("slut. (Vanlig ending) OBS! Det finns flera endings...");
                    break;
                }
                break;
            }
            
        }
    }
}
