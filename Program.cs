using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace caReadingTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int intCounter = 0;
            List<string> playercards = new List<string>();
            
            string [] strPlayers = new string[5];
            string[,] strCardsDealt = new string[5,5]; 

             
            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"d:\dealt.txt"))
            {
                System.Console.WriteLine(line);
                playercards.Add(line); 
                intCounter++;
            }

            Console.WriteLine();
            System.Console.WriteLine("There were {0} lines.", intCounter);

            int intCount1 = 0; 
            int intCount2 = 0;
            
            foreach (string playerline in playercards)
            {
                Console.WriteLine("Full Line extracted - " + playerline);
                Console.WriteLine();

                int index = playerline.IndexOf(":");
                Console.WriteLine("Name: " + playerline.Substring(0, index) + " - index: " + index);
                strPlayers[intCount1] = playerline.Substring(0, index) + " - index: " + index; //loading the names in one array

                Console.WriteLine(": is at " + (index + 1) + " - length " + playerline.Length);
                
                Console.WriteLine("All 5 cards -- " + playerline[index..]);

                string cards = playerline[index..];
                cards = cards.Remove(0, 1); // for some reason the ':' stayed in the list of cards 
                string[] dealtArray =  cards.Split(',');

                foreach (string dealtCard in dealtArray)
                {
                    strCardsDealt[intCount1, intCount2] = dealtCard;
                    intCount2++;
                    if (intCount2 == 5)
                    {
                        intCount2 = 0; 
                    }
                }
                Console.WriteLine();
                intCount1++;
            }

            Console.WriteLine("Their cards again ");
            for (intCount1 = 0; intCount1 <= 4; intCount1++)
            {
                Console.WriteLine(strPlayers[intCount1]);
                for (intCount2 = 0; intCount2 <= 4; intCount2++)
                {
                    Console.WriteLine("Card " + (intCount2 + 1) + " -- " + strCardsDealt[intCount1, intCount2]);
                }
                Console.WriteLine();
            }

            /*              0   1   2   3   4       Points
             * 0    John    AH  3C  8C  2D  JD      __      0		John,AH,3C,8C,2D,JD
               1    Jack    KD  QH  10C 4C  AC      __      1
               2    Jane    6S  8D  3D  JH  2D      __      2
               3    Jenny   5H  3S  KH  AS  9D      __      3
               4    Jake    JS  3H  2H  2C  4D      __      4
            */

            int[] Points = new int[5];
            int intSumPoints; 

            for (intCount1 = 0; intCount1 <= 4; intCount1++)
            {
                intSumPoints = 0;
                for (intCount2 = 0; intCount2 <= 4; intCount2++)
                {
                    /*
                     * Since I now have each card in a separate cell - 
                     * I can use the following cell code to read the card strCardsDealt[intCount1, intCount2]
                     * and then split it again to calculate the points for that card and accumulate it to the 
                     * intSumPoints variable - intSumPoints = intSumPoints + ?? POINTS CALCULATED ??
                     */
                   
                    // split the card to get the points - for example - what is the points for AH 
                    // add the points to the sum variable 
                }
                Points[intCount1] = intSumPoints; 
            }
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
