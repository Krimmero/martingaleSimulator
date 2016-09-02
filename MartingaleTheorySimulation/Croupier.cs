using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySimulation
{
    public class Croupier
    {
        public Croupier(IRoulette roulette)
        {
            this.roulette = roulette;
        }

        private int rouletteNumber;

        IRoulette roulette;


        Dictionary<IGambler, int> betOnEven = new Dictionary<IGambler, int>();
        Dictionary<IGambler, int> betOnOdd = new Dictionary<IGambler, int>();

        public Dictionary<IGambler, int> BetOnEven
        {
            get { return betOnEven; }
        }

        public Dictionary<IGambler, int> BetOnOdd
        {
            get { return betOnOdd; }
        }


        public void betEven(IGambler gambler, int amount)
        {
            betOnEven.Add(gambler, amount);
        }

        public void betOdd(IGambler gambler, int amount)
        {
            betOnOdd.Add(gambler, amount);
        }

        public void spinRoulette()
        {
            rouletteNumber = roulette.Spin();   
        }

        public int getRouletteNumber()
        {
            return rouletteNumber;
        }

        public void equalize()
        {
            if (rouletteNumber%2 == 0 && rouletteNumber != 0)
            {
                foreach (var winner in betOnEven)
                {
                    winner.Key.receiveCash(winner.Value*2);
                   
                }
            }
            if (rouletteNumber%2 == 1 && rouletteNumber != 0)
            {
                foreach (var winner in betOnOdd)
                {
                    winner.Key.receiveCash(winner.Value*2);
                    
                }
            }

            betOnEven.Clear();
            betOnOdd.Clear();

        }
    }
}
