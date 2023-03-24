namespace Tema3
{
    public class PermutationEncypher
    {
        public string Encypher(string text, List<int> permutation)
        {
            string enchypheredText = string.Empty;
            int perCount = permutation.Count;
            int newChar = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    enchypheredText += 'Q';
                    continue;
                }

                if (!((text[i] > 64 && text[i] < 91) || (text[i] > 96 && text[i] < 123)))
                {
                    enchypheredText += text[i];
                    continue;
                }

                if ((text[i] + permutation[i % perCount]) > 122)
                {
                    enchypheredText += EncryptLetter(text[i], permutation, i, 26, perCount);

                    continue;
                }

                if ((text[i] + permutation[i % perCount]) > 90)
                {
                    enchypheredText += EncryptLetter(text[i], permutation, i, 26, perCount);

                    continue;
                }

                enchypheredText += EncryptLetter(text[i], permutation, i, 0, perCount);

            }

            return enchypheredText;
        }

        private char EncryptLetter(char character, List<int> permutation, int poz, int divider, int permutationCounter)
        {

            return Convert.ToChar(character + permutation[poz % permutationCounter] - divider);
        }



    }
}
