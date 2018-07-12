using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraMetodoSOLID
{
    [TestClass]
    public class PruebaOperaciones
    {
        float datoObtenido;
        float datoEsperado;

        [TestMethod]
        public void PruebaSuma()
        {
            datoEsperado = 6.00f;
            Suma suma = new Suma() { x = 2, y = 4 };
            Calculacion calc = new Calculacion();
            datoObtenido = calc.Calcula(suma);
            Assert.AreEqual(datoEsperado,datoObtenido);
        }
        [TestMethod]
        public void PruebaResta()
        {
            datoEsperado = 1.00f;
            Resta resta = new Resta() { x = 8, y = 7 };
            Calculacion calc = new Calculacion();
            datoObtenido = calc.Calcula(resta);
            Assert.AreEqual(datoEsperado, datoObtenido);
        }
        [TestMethod]
        public void PruebaMultiplica()
        {
            datoEsperado = 8.00f;
            Multiplica multiplica = new Multiplica() { x = 2, y = 4 };
            Calculacion calc = new Calculacion();
            datoObtenido = calc.Calcula(multiplica);
            Assert.AreEqual(datoEsperado, datoObtenido);
        }
        [TestMethod]
        public void PruebaDivision()
        {
            datoEsperado = 0.5f;
            Divide divide = new Divide() { x = 2.00f, y = 4.00f };
            Calculacion calc = new Calculacion();
            datoObtenido = calc.Calcula(divide);
            Assert.AreEqual(datoEsperado, datoObtenido);
        }
    }
}
