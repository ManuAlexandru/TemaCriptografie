using Tema2;


//Vigenere
var cheieVigenere = new List<int>();
string sirVigenere = "ALL I WANT TO DO IS BE MORE LIKE ME AND LESS LIKE YOU";
string sirNouVigenere = String.Empty;

string cheieSir = "IOAN";
foreach (var caracter in cheieSir)
{
    cheieVigenere.Add(caracter - 65);
}

sirNouVigenere = VigenereCypher.Encrypt(sirVigenere, sirNouVigenere, cheieVigenere);

Console.WriteLine($"Sirul este: {sirVigenere}");
Console.WriteLine($"Sirul criptat dupa metoda vigenere este: {sirNouVigenere}");

//PlayFair
string text = "Hello World";
string cipherText = PlayFairCypher.Encipher(text, "cipher");
string plainText = PlayFairCypher.Decipher(cipherText, "cipher");

Console.WriteLine($"Sirul este: {plainText}");
Console.WriteLine($"Sirul criptat dupa metoda playfair este: {cipherText}");
