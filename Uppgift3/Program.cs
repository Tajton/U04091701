using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int value = 0;
            int suit = 0;
            int n = 0;
            string svar;
            int cardValue = 0;
            int pointSum = 0;

            String[] deck = new String[52];

            for (int i = 0; i < 52; i++)
            {
                value = rand.Next(1, 14);
                suit = rand.Next(1, 5);

                if (!deck.Contains(suit.ToString() + ' ' + value.ToString()))
                {


                    deck[i] = suit.ToString().Replace("1", "Hjärter").Replace("2", "Klöver")
                        .Replace("3", "Ruter").Replace("4", "Spader") + ' ' + value.ToString();
                }
            }

            do
            {
                Console.WriteLine("Vill du dra ett kort? ja/nej");
                svar = Console.ReadLine();

                if (svar.ToLower().Contains("ja"))
                {
                    string[] cardsDrawn = deck[n].Split(' ');
                    cardValue = Convert.ToInt32(cardsDrawn[1]);
                    pointSum += cardValue;
                    Console.WriteLine("Du drog " + deck[n] + " och din poängsumma är " + pointSum);
                    n++;
                }
                
                if (pointSum == 21)
                {
                    Console.WriteLine("Grattis! Du vann!");
                    break;
                }
                else if (pointSum > 21)
                {
                    Console.WriteLine("Poängsumman överskred 21. Du förlorade :(");
                    break;
                }

            } while (!svar.ToLower().Contains("nej"));

            
            if (pointSum<21)
                Console.WriteLine("Din poängsumma är " + pointSum);
        }
    }
}
