using NUnit.Framework;
using MartingaleTheorySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySimulation.Tests
{
    [TestFixture()]
    public class RouletteTests
    {
        

        [Test()]
        public void SpinTest()
        {
            Roulette roulette = new Roulette();
            for (int i = 0; i < 1000; i++)
            {
                int rNum = roulette.Spin();
                Assert.IsTrue(rNum <= 36 && rNum >= 0);
            }

            
        }
    }
}