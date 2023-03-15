
using Tema1;

//Caesar
string sirCaesar = "COMPUTERS ARE LIKE OLD TESTAMENT GODS, LOTS OF RULES AND NO MERCY";
string sirNouCaesar = String.Empty;
var cheieCeaser = 8;

sirNouCaesar = CaesarCipher.Encrypt(sirCaesar, sirNouCaesar, cheieCeaser);
Console.WriteLine($"Sirul este: {sirCaesar}");
Console.WriteLine($"Sirul criptat dupa metoda ceaser este: {sirNouCaesar}");

//Vigenere
var cheieVigenere = new List<int>();
string sirVigenere = "COMPUTERS ARE LIKE OLD TESTAMENT GODS, LOTS OF RULES AND NO MERCY";
string sirNouVigenere = String.Empty;

string cheieSir = "FIRST";
foreach (var caracter in cheieSir)
{
    cheieVigenere.Add(caracter - 65);
}

sirNouVigenere = VigenereCypher.Encrypt(sirVigenere, sirNouVigenere, cheieVigenere);

Console.WriteLine($"Sirul este: {sirVigenere}");
Console.WriteLine($"Sirul criptat dupa metoda vigenere este: {sirNouVigenere}");
