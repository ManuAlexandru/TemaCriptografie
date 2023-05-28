namespace Tema8
{
    public class MathClass
    {


        public static int DiscretLogarithm(int b, int g, int p)
        {
            int x = 0;
            var valueToCompare = (Math.Pow(g, x)) % p;
            while (valueToCompare != b)
            {
                x++;
                valueToCompare = (Math.Pow(g, x)) % p;
            }
            return x;
        }
    }
}
