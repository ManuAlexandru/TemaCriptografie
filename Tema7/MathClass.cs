namespace Tema7
{
    public class MathClass
    {
        // prime modulo value
        static long N = 1000000007L;

        public static (long, long) exponentiation(long bas, long exp, long step)
        {
            if (exp == 0)
                return (1, step);

            if (exp == 1)
                return (bas % N, step);

            (long t, long steps) = exponentiation(bas, exp / 2, step + 1);
            t = (t * t) % N;

            // if exponent is even value
            if (exp % 2 == 0)
                return (t, steps + 1);

            // if exponent is odd value
            else
                return (((bas % N) * t) % N, steps + 1);
        }
    }
}
