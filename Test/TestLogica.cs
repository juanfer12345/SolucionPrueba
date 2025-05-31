using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class TestLogica
    {
        [Test]
        public void TestLogicaRango1a10()
        {
            List<long> numerosPerfectos1a10 = new List<long>()
            {
                6
            };
            long inicio = 1;
            long fin = 10;

            var numerosPefectos = NumeroPerfecto.NumerosPerfectosEnRango(inicio, fin);

            Assert.AreEqual(numerosPerfectos1a10, numerosPefectos);
        }

        [Test]
        public void TestLogicaRango1A1000()
        {
            var esperados = new List<long> { 6, 28, 496 };
            long inicio = 1;
            long fin = 1000;

            var numerosPefectos = NumeroPerfecto.NumerosPerfectosEnRango(inicio, fin);

            Assert.AreEqual(esperados, numerosPefectos);
        }

        [Test]
        public void TestLogicaRango1A1000Mersenne()
        {
            var esperados = new List<long> { 6, 28, 496 };
            long inicio = 1;
            long fin = 1000;

            var numerosPefectos = NumeroPerfecto.NumerosPerfectosEnRangoMersenne(inicio, fin);

            Assert.AreEqual(esperados, numerosPefectos);
        }
    }
}
