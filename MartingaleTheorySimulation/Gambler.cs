using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySimulation
{
    public interface IGambler
    {
        void bet(Croupier croupier, int amount);
        void receiveCash(int amount);
    }

    public class Gambler : IGambler
    {
        public Gambler(int amount)
        {
            this.Cash = amount;
        }

        public int Cash { get; private set; }

        public void bet(Croupier croupier, int amount)
        {
            if (this.Cash >= amount)
            {
                this.Cash -= amount;
                croupier.betEven(this, amount);
            }
            else
            {
                throw new OutOfCashException();
            }
        }

        public void receiveCash(int amount)
        {
            this.Cash += amount;
        }
        
    }
}
