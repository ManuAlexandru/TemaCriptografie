namespace Tema4
{
    public class ExerciseCypher2
    {
        public string Enchypher(int key, string text)
        {

            string textToEncypher = string.Empty;

            string encryptedText = string.Empty;

            foreach (var elem in text.Split(' '))
            {
                textToEncypher = textToEncypher + elem;
            }

            foreach (var elem in textToEncypher)
            {
                var encryptedChar = (elem + 3 * key) % 26;
                encryptedText = encryptedText + Convert.ToChar(65 + encryptedChar);
            }

            return encryptedText;
        }
    }
}
