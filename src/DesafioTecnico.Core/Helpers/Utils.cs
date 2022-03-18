namespace DesafioTecnico.Core.Helpers
{
    public static class Utils
    {
        public static bool ENumeroPrimo(long numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            long result = numero / 2;

            for (int i = 2; i <= result; i++)
                if (numero % i == 0) return false;

            return true;
        }

        public static bool EDivisor(long numero, long divisor)
        {
            return numero % divisor == 0;
        }
    }
}
