using DesafioTecnico.Core.Helpers;
using System.Collections.Generic;

namespace DesafioTecnico.Core.Service
{
    public class DivisorService
    {
        public List<long> Calcular(int numero, bool calcularPrimo = false)
        {
            List<long> divisores = new List<long>();

            for (long i = 1; i <= numero; i++)
            {
                if (Utils.EDivisor(numero, i)) divisores.Add(i);
            }

            if (calcularPrimo)
            {
                List<long> divisoresPrimos = new List<long>();

                foreach (var item in divisores)
                {
                    if (Utils.ENumeroPrimo(item)) divisoresPrimos.Add(item);
                }

                divisores = divisoresPrimos;
            }

            return divisores;
        }
    }
}
