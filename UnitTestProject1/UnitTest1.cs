using System;
using DogRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Punter newPunter = new Shivam();
        [TestMethod]
        public void Test1() // Tests to make sure the Instantiation has worked by making sure the cash amounts are correct
        {

            int ExpectedCash = 50;
            int ActualCash = newPunter.Cash;
            Assert.AreEqual(ExpectedCash, ActualCash);
        }
        [TestMethod]
        public void Test2() // Tests to check how many punters are there
        {
            Punter newPunter = Factory.GetAPunter(0);
            Punter secPunter = Factory.GetAPunter(1);
           

            int num = Factory.count;

            Assert.AreEqual(num, 2);
        }
    }
}
