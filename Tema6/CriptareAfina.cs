namespace Tema6
{
    public class CriptareAfina
    {
        public string Enchypher(string text)
        {

            string textToEncypher = string.Empty;

            string encryptedText = string.Empty;

            foreach (var elem in text.Split(' '))
            {
                textToEncypher = textToEncypher + elem;
            }

            foreach (var elem in textToEncypher)
            {
                var encryptedChar = (3 * elem + 10) % 26;
                encryptedText = encryptedText + Convert.ToChar(65 + encryptedChar);
            }

            return encryptedText;
        }
    }
}
