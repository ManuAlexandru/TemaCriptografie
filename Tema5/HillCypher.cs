namespace Tema5
{
    public class HillCypher
    {
        public void Encode(string text)
        {
            int i, j, sum = 0, end = 0;
            int[,] mtrx = new int[25, 25];
            int[,] ans = new int[25, 1];

            char[] txt = text.ToCharArray();
            end = txt.Length;

            Random rnd = new Random();
            for (i = 0; i < end; i++)
            {
                for (j = 0; j < end; j++)
                {

                    mtrx[i, j] = rnd.Next();
                }

            }

            for (i = 0; i < end; i++)
            {

                sum = 0;
                for (j = 0; j < end; j++)
                {
                    sum += mtrx[i, j] * (int)txt[j];
                }
                ans[i, 0] = sum;
            }

            Console.Write("Your CipherText is:");
            for (i = 0; i < end; i++)
            {
                char cipher = (char)(((ans[i, 0]) % 26) + 97);
                Console.Write(cipher);

            }

        }
    }
}
