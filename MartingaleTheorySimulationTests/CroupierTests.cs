using Microsoft.VisualStudio.TestTools.UnitTesting;
using MartingaleTheorySimulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace MartingaleTheorySimulation.Tests
{
    [TestClass()]
    public class CroupierTests
    {
       
        
        [TestInitialize]
        public void CreateMoqRoulette()
        {
            
        }


        [TestMethod()]
        public void SpinRouletteTest()
        {
            // create a mockup of the roulette
            Mock<Roulette> mockRoulette = new Mock<Roulette>();

            // get a mock roullet object
            Roulette roulette = mockRoulette.Object;

            // create a mock spin method in mock roulette (will always return 7 when you call spin method)
            mockRoulette.Setup(r => r.spin()).Returns(7);

            // create Crouper
            Croupier croupier = new Croupier(roulette);

            croupier.spinRoulette();
            Assert.IsTrue(croupier.getRouletteNumber() == 7);
        }

     
    }
}