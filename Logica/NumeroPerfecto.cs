using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class NumeroPerfecto
    {
        private static readonly int[] pValues = { 2, 3, 5, 7, 13, 17, 19, 31 };

        public static List<long> NumerosPerfectosEnRango(long inicio, long fin)
        {
            var resultado = new List<long>();

            for (long n = inicio; n <= fin; n++)
            {
                if (EsPerfecto(n))
                {
                    resultado.Add(n);
                }
            }

            return resultado;
        }

        private static bool EsPerfecto(long n)
        {
            if (n < 2)
            {
                return false;
            }

            long suma = 1;
            long raiz = (int)Math.Sqrt(n);

            for (int i = 2; i <= raiz; i++)
            {
                if (n % i == 0)
                {
                    suma += i;
                    long otroDivisor = n / i;
                    if (otroDivisor != i) // Evitar sumar la raíz dos veces si es cuadrado perfecto
                    {
                        suma += otroDivisor;
                    }
                }
            }

            return suma == n;
        }

        public static List<long> NumerosPerfectosEnRangoMersenne(long inicio, long fin)
        {
            List<long> perfectos = new();

            foreach (int p in pValues)
            {
                long mersenne = (1L << p) - 1; // 2^p - 1
                long perfecto = (1L << (p - 1)) * mersenne; // 2^(p-1) * (2^p - 1)

                if (perfecto >= inicio && perfecto <= fin)
                {
                    perfectos.Add(perfecto);
                }
            }

            return perfectos;
        }
    }
}
