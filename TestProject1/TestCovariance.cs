using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaAvanzada1;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class TestCovariance
    {
        [TestMethod]
        public void TestInvariance()
        {
            List<Persona> persona = new List<Persona>()
            {
                new Pediatra(),
                new Cirujano()
            };

            UsingCovariance.ShowList(persona);
            
        }

        //Covariance

        [TestMethod]
        public void ConvarianceTest()
        {
            List<Pediatra> pediatra = new List<Pediatra>()
            {
                new Pediatra(),
                new Pediatra()
            };

            UsingCovariance.ShowList(pediatra);

        }

        //Contravariance

        [TestMethod]
        public void TestContravariance()
        {
           var operar = new Action<Cirujano>(a => Console.WriteLine("Preparado para operar"));
            UsingCovariance.AssignSurgeon(operar);

        }
    }
}