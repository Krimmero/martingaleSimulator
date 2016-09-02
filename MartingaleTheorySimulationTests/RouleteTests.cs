using Microsoft.VisualStudio.TestTools.UnitTesting;
using MartingaleTheorySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartingaleTheorySimulation.Tests
{
    [TestClass()]
    public class RouleteTests
    {
        [TestMethod()]
        public void spinTest()
        {
            Roulette r = new Roulette();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = r.spin();
                Assert.IsTrue(randomNumber <= 36 && randomNumber >= 0);
            }
            r.spin();
        }
    }
}