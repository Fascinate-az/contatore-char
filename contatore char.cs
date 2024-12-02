Console.WriteLine("inserire una frase");

var frase = Console.ReadLine();
int vocali = 0;
int consonanti = 0;
int punteggiatura = 0;
int numeri = 0;


foreach(char c in frase)
{
    if ("aeiou".Contains(c))
        vocali++;
    else if (char.IsLetter(char.ToLower(c)))
        consonanti++;
    else if (char.IsPunctuation(c))
        punteggiatura++;
    else if (char.IsDigit(c))
        numeri++;
}
Console.WriteLine($"sono state trovate {vocali} vocali, {consonanti} consonanti, {punteggiatura} simboli di punteggiatura, {numeri} numeri; ");


Console.ReadKey();
