using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySimulation
{
    public interface IRoulette
    {
        int Spin();
    }

    public class Roulette : IRoulette
    {
        private Random random;
        public Roulette()
        {
            random = new Random();
        }
        public int Spin()
        {
            return random.Next(0, 37);
        }
    }
}
