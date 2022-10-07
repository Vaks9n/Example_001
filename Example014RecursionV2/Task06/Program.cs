// Перебор слов
// В некотором машинном алфавите имеются 4 буквы 
// "а" "и" "с" и "в". Покажите все слова 
// состоящие из Т букв, которые можно построить из букв
// этого алфавита

//Если однобуквенные слова

char[] s = { 'a', 'и', 'с' ,'в'};
int count = s.Length;
int n = 1;

for (int i = 0; i < count; i++)
{
  //  Console.WriteLine($"{n++, -5}{s[i]}");
}

// Двухбуквенные

 for (int i = 0; i < count; i++)
 {
    for (int j = 0; j < count; j++)
    {
       // Console.WriteLine($"{n++, -5}{s[i]}{s[j]}");
    }
 }

 /// Трехбуквенные и тд

 for (int i = 0; i < count; i++)
 {
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
           // Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}");
        }
    }
 }

//  Рекурсия

void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
{
    word[length] = alphabet[i];
    FindWords(alphabet, word, length + 1);
}
}



FindWords("аисв", new char[2]);