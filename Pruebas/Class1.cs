using System;
using CONTROLADOR;
using NUnit.Framework;

namespace Pruebas
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePort_COM1_Returns1()
        {
            int result = ControladorAlimentos.PruebasAlimentos("COM1");
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
