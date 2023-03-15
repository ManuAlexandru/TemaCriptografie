namespace Tema1
{
    public class CaesarCipher
    {
        public static string Encrypt(string sir, string sirNou, int cheie)
        {
            int contor = 0;
            foreach (var caracter in sir)
            {

                if (caracter > 64 && caracter < 91)//Verific daca face parte din intervalul A-Z
                {
                    if ((caracter + cheie) > 90)//Daca pozitia unde vreau sa ajung e >Z, deci trebuie sa ma intorc la inceput
                    {
                        contor = caracter + cheie;
                        contor = 64 + contor - 90;//Adun la A cu cat a trecut contorul peste Z 
                        sirNou = sirNou + Convert.ToChar(contor);//Introduc in noul sir caracterul schimbat

                    }
                    else
                        sirNou = sirNou + Convert.ToChar(caracter + cheie);//Introduc in noul sir caracterul schimbat
                }
                else
                    if (caracter > 96 && caracter < 123)
                {
                    if ((caracter + cheie) > 122)//Daca pozitia unde vreau sa ajung e >z, deci trebuie sa ma intorc la inceput
                    {
                        contor = caracter + cheie;
                        contor = 96 + contor - 122;//Adun la a cu cat a trecut contorul peste z 
                        sirNou = sirNou + Convert.ToChar(contor);//Introduc in noul sir caracterul schimbat
                    }
                    else
                        sirNou = sirNou + Convert.ToChar(caracter + cheie);//Introduc in noul sir caracterul schimbat

                }
                else
                    sirNou = sirNou + Convert.ToChar(caracter);//Caracterul nu apartine alfabetului, deci nu il schimb
            }

            return sirNou;
        }
    }
}
