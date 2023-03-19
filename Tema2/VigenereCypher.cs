namespace Tema2
{
    public class VigenereCypher
    {
        public static string Encrypt(string sir, string sirNou, List<int> cheie1)
        {
            int contor = 0;
            int i = 0;
            foreach (var caracter in sir)
            {

                if (caracter > 64 && caracter < 91)//Verific daca face parte din intervalul A-Z
                {
                    if ((caracter + cheie1[i]) > 90)//Daca pozitia unde vreau sa ajung e >Z, deci trebuie sa ma intorc la inceput
                    {
                        contor = caracter + cheie1[i];
                        contor = 64 + contor - 90;//Adun la A cu cat a trecut contorul peste Z 
                        sirNou = sirNou + Convert.ToChar(contor);//Introduc in noul sir caracterul schimbat
                        i++;
                    }
                    else
                    {
                        sirNou = sirNou + Convert.ToChar(caracter + cheie1[i]);//Introduc in noul sir caracterul schimbat
                        i++;
                    }
                }
                else
                        if (caracter > 96 && caracter < 123)
                {
                    if ((caracter + cheie1[i]) > 122)//Daca pozitia unde vreau sa ajung e >z, deci trebuie sa ma intorc la inceput
                    {
                        contor = caracter + cheie1[i];
                        contor = 96 + contor - 122;//Adun la a cu cat a trecut contorul peste z 
                        sirNou = sirNou + Convert.ToChar(contor);//Introduc in noul sir caracterul schimbat
                        i++;
                    }
                    else
                    {
                        sirNou = sirNou + Convert.ToChar(caracter + cheie1[i]);//Introduc in noul sir caracterul schimbat
                        i++;
                    }
                }
                else
                    sirNou = sirNou + Convert.ToChar(caracter);//Caracterul nu apartine alfabetului, deci nu il schimb

                if (i == cheie1.Count)
                    i = 0;

            }

            return sirNou;
        }
    }
}
