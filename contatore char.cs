Console.WriteLine("inserire una frase");

var frase = Console.ReadLine();
int vocali = 0;
int consonanti = 0;
int punteggiatura = 0;
int numeri = 0;


 foreach(char c in frase)
{
    if ("aeiou".Contains(char.ToLower(c)))
        vocali++;
    else if (char.IsLetter(c))
        consonanti++;
    else if (char.IsPunctuation(c))
        punteggiatura++;
    else if (char.IsDigit(c))
        numeri++;
    
}
Console.WriteLine($"sono state trovate {vocali} vocali, {consonanti} consonanti, {numeri} numeri e {punteggiatura} simboli di punteggiatura per un totale di {frase.Length} caratteri");

Console.ReadKey();
