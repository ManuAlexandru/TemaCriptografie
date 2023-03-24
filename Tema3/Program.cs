
using Tema3;

PermutationEncypher encypher = new PermutationEncypher();

string text = "ANA ARE MERE, CIRESEL VINE SI CERE.";

var permutation = new List<int>();
permutation.Add(5);
permutation.Add(3);
permutation.Add(1);
permutation.Add(2);
permutation.Add(4);

Console.WriteLine("Textul normal: " + text);
Console.WriteLine("Textul criptat: " + encypher.Encypher(text, permutation));
