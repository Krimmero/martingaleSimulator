using NUnit.Framework;
using MartingaleTheorySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MartingaleTheorySimulation.Tests
{
    [TestFixture()]
    public class CroupierTests
    {
     
        [Test()]
        public void SpinRouletteTest()
        {
            Mock<IRoulette> mockRoulette = new Mock<IRoulette>();
            IRoulette roulette = mockRoulette.Object;
            mockRoulette.Setup(r => r.Spin()).Returns(7);

            Croupier croupier = new Croupier(roulette);
            croupier.spinRoulette();
            Assert.IsTrue(croupier.getRouletteNumber() == 7);
        }

      
    }
}