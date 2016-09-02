using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySimulation
{
    class Program
    {
        private static int numberOfTests = 1000;

        private static int playerWins = 0;
        private static int playerLoose = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Martingale Theory Simulation " + numberOfTests );
            for (int i = 0; i < numberOfTests; i++)
            {
                SimulateMartingale(10, 33000);
            }
            Console.WriteLine();
            Console.WriteLine("number of times player win: " + playerWins);
            Console.WriteLine("number of times player loose: " + playerLoose);
        }

        private static void SimulateMartingale(int amount, int winningCondition)
        {
            Gambler gambler = new Gambler(30000);
            Croupier croupier = new Croupier(new Roulette());

            //amount = 100;
            //winningCondition = 5000;
            
            try
            {
                while (gambler.Cash < winningCondition)
                {
                    gambler.bet(croupier, amount);
                    croupier.spinRoulette();
                    croupier.equalize();
                            if (croupier.getRouletteNumber()%2 == 0)
                            {
                                amount = 10;
                                //Console.WriteLine("player won: " + gambler.Cash);
                            }
                            else
                            {
                                amount *= 2;
                                //Console.WriteLine("player lost: " + gambler.Cash);
                            }
                }
                Program.playerWins++;
                //Console.Write(".");
                //if (playerWins+playerLoose%10==0) Console.WriteLine(".");
            }
            catch (OutOfCashException)
            {
                //throw new OutOfCashException();
                //Console.WriteLine("PLayer out of cash");
                Program.playerLoose++;
                //Console.Write(".");
                //if (playerWins + playerLoose % 10 == 0) Console.WriteLine(".");
            }
        }
    }
}
