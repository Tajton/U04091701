using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int kort = 0;
            int suit = 0;
            

            String[] kortlek = new String[52];
            


            for (int i = 0; i < 52; i++)
            {
                kort = rand.Next(1, 14);
                suit = rand.Next(1, 5);

                if (!kortlek.Contains(kort.ToString() + ' ' + suit.ToString()))
                {
                    

                    kortlek[i] = suit.ToString().Replace("1", "Hjärter").Replace("2", "Klöver")
                        .Replace("3", "Ruter").Replace("4", "Spader") + ' ' + kort.ToString();
                }

                Console.WriteLine(kortlek[i]);
                
            }
            



        }
    }
}
