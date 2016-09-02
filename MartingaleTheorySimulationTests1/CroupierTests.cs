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
        private IRoulette roulette;
        private IGambler gambler;

        [SetUp]
        public void createMockObject()
        {
            Mock<IRoulette> mockRoulette = new Mock<IRoulette>();
            roulette = mockRoulette.Object;
            mockRoulette.Setup(r => r.Spin()).Returns(7);

            Mock<IGambler> mockGambler = new Mock<IGambler>();
            gambler = mockGambler.Object;
        }

        [Test()]
        public void SpinRouletteTest()
        {

            Croupier croupier = new Croupier(roulette);
            croupier.spinRoulette();
            Assert.IsTrue(croupier.getRouletteNumber() == 7);
        }

        [Test()]
        public void betEvenTest()
        {
            Croupier croupier = new Croupier(roulette);
            croupier.betEven(gambler, 778899);
            Assert.IsTrue(croupier.BetOnEven.ContainsKey(gambler));
            Assert.IsTrue(croupier.BetOnEven.ContainsValue(778899));
        }
    }
}