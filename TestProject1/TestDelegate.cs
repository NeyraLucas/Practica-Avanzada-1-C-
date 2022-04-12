using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaAvanzada1;
using System;
using System.Collections.Generic;


namespace TestProject1
{
    [TestClass]
    public class TestDelegate
    {

        [TestMethod]
        public void Test1()
        {
            Delegates example1 = new Delegates();
            example1.ExampleAction();
        }

        //Test func
        [TestMethod]
        public void TestFunct()
        {
            Delegates example1 = new Delegates();
            example1.ExampleFunc();
        }

        //Predicate
        [TestMethod]
        public void TestPredicate()
        {
            Delegates example3 = new Delegates();
            example3.ExamplePredicate();
        }

    }
}
