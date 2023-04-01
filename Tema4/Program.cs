using Tema4;

ExerciseCypher1 cypher1 = new ExerciseCypher1();
ExerciseCypher2 cypher2 = new ExerciseCypher2();

string text = "ManuAlexandru";

var result1 = cypher1.Enchypher(13, text);
var result2 = cypher2.Enchypher(13, text);
Console.WriteLine("Sirul care va fi criptat este: " + text);
Console.WriteLine("Sirul criptat cu prima formula este: " + result1);
Console.WriteLine("Sirul criptat cu a doua formula este: " + result2);
