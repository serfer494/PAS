using Microsoft.VisualStudio.TestTools.UnitTesting;
using CONTROLADOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR.Tests
{
    [TestClass()]
    public class ValidacionTests
    {
        [TestMethod()]
        public void LongitudTest()
        {
            Validacion val = new Validacion();
            Assert.IsTrue(val.Longitud("Prueba", 1, 6));
        }

        [TestMethod()]
        public void MayorATest()
        {
            Validacion val = new Validacion();
            Assert.IsTrue(val.MayorA(5, 4));
        }

        [TestMethod()]
        public void MenorATest()
        {
            Validacion val = new Validacion();
            Assert.IsTrue(val.MenorA(4, 5));
        }

        [TestMethod()]
        public void ContieneMayusculasTest()
        {
            Validacion val = new Validacion();
            Assert.IsTrue(val.ContieneMayusculas("Prueba"));
        }

        [TestMethod()]
        public void ContieneMinusculasTest()
        {
            Validacion val = new Validacion();
            Assert.IsTrue(val.ContieneMinusculas("Prueba"));
        }

        [TestMethod()]
        public void ContieneNumerosTest()
        {
            Validacion val = new Validacion();
            Assert.IsTrue(val.ContieneNumeros("Prueba123"));
        }

        [TestMethod()]
        public void FechaMayorATest()
        {
            Validacion val = new Validacion();
            var fechaMayor = new DateTime(2009, 5, 1, 8, 30, 52);
            var FechaLimite = new DateTime(2008, 5, 1, 8, 30, 52);
            Assert.IsTrue(val.FechaMayorA(fechaMayor, FechaLimite));
        }

        [TestMethod()]
        public void FechaMenorATest()
        {
            Validacion val = new Validacion();
            var fechaMenor = new DateTime(2008, 5, 1, 8, 30, 52);
            var FechaLimite = new DateTime(2009, 5, 1, 8, 30, 52);
            Assert.IsTrue(val.FechaMenorA(fechaMenor, FechaLimite));
        }

        [TestMethod()]
        public void FechaMayorIgualATest()
        {
            Validacion val = new Validacion();
            var fecha = new DateTime(2008, 5, 1, 8, 30, 52);
            var FechaLimite = new DateTime(2008, 5, 1, 8, 30, 52);
            Assert.IsTrue(val.FechaMayorIgualA(fecha, FechaLimite));
        }

        [TestMethod()]
        public void FechaMenorIgualATest()
        {
            Validacion val = new Validacion();
            var fecha = new DateTime(2008, 5, 1, 8, 30, 52);
            var FechaLimite = new DateTime(2008, 5, 1, 8, 30, 52);
            Assert.IsTrue(val.FechaMayorIgualA(fecha, FechaLimite));
        }
    }
}