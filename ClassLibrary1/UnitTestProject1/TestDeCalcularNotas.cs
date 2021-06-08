using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class TestDeCalcularNotas
    {
        [TestMethod]
        public void calcularNotas()
        {
            estaditicasNotas nots = new estaditicasNotas();
            List<int> notas = new List<int>();

            notas.Add(1);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.14;
        


            nots.CalcularEstadisticasNotas(notas);
           

            double actual = nots.CalcularEstadisticasNotas(notas);

          
            Assert.AreEqual(mediaEsperada, actual);
           
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void calcularNotasfueraderango()
        {
            estaditicasNotas nots = new estaditicasNotas();
            List<int> notas = new List<int>();

            notas.Add(-1);
            notas.Add(35);
            notas.Add(94);
            notas.Add(53);
            notas.Add(37);
            notas.Add(45);
            notas.Add(38);

            double mediaEsperada = 5.143;
            


            nots.CalcularEstadisticasNotas(notas);


            double actual = nots.CalcularEstadisticasNotas(notas);

            
            Assert.AreEqual(mediaEsperada, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void calcularListasVacias()
        {
            estaditicasNotas nots = new estaditicasNotas();
            List<int> notas = new List<int>();

           

            double mediaEsperada = 5.143;
          


            nots.CalcularEstadisticasNotas(notas);


            double actual = nots.CalcularEstadisticasNotas(notas);

          
            Assert.AreEqual(mediaEsperada, actual);

        }
    
}
}
