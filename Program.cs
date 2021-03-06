string[] favoriteFoods = { "pizza", "burgers", "sushi", "steak", "apples" };

Random random = new Random();

if (random.Next(0,2) == 0)
{
    favoriteFoods = favoriteFoods.Concat(new string[] { "carrots" }).ToArray();
}

Console.WriteLine($"Array length: {favoriteFoods.Length}");

Console.WriteLine("My favorite foods are: ");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine($"  {i + 1}. {favoriteFoods[i]}");
}

Console.WriteLine($"My favorite food of all is: {favoriteFoods[0]}");

Console.WriteLine($"My least favorite food is: {favoriteFoods[favoriteFoods.Length - 1]}");

// Bonus

if (favoriteFoods.Length % 2 == 0)
{
    Console.WriteLine($"The middle elements are: {favoriteFoods[favoriteFoods.Length / 2 - 1]} and {favoriteFoods[favoriteFoods.Length / 2]}");
}
else
{
    Console.WriteLine($"The middle element is: {favoriteFoods[favoriteFoods.Length / 2]}");
}

/* 
 Chiedere all'utente il suo cibo preferito.
 Generare un numero randomico da 0 alla lunghezza dei cibi preferiti per simulare che il computer scelga un cibo preferito
 Il cibo in classifica preferito dall'utente avrà scritto "questo è il tuo cibo preferito", lo stesso per il pc
 Se sono uguali scrivi: abbiamo gli stessi gusti.
 Finchè l'utente non scrive un cibo preferito presente dentro l'array, allora gli comunicate che il cibo non è presente e gli richiedete di inserirlo nuovamente
*/

Console.WriteLine("\nPlease enter your favorite food between the list above: ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
string favoriteInput = Console.ReadLine().ToLower();

while (!favoriteFoods.Contains(favoriteInput))
{
    Console.WriteLine("This food is not present in the list, please enter a new one: ");
    favoriteInput = Console.ReadLine().ToLower();
    #pragma warning restore CS8602 // Dereference of a possibly null reference.
}

int userChoice = Array.IndexOf(favoriteFoods, favoriteInput);
int pcChoice = random.Next(0, favoriteFoods.Length);

for (int i = 0; i < favoriteFoods.Length; i++)
{
    string message = "";
    if (i == userChoice)
    {
        message += "---> ";
        message += userChoice == pcChoice ? "we have the same taste, this is our favorite food" : "this is your favorite food";
    }
    else if (i == pcChoice)
    {
        message += "---> computer favorite food";
    }
    
    Console.WriteLine($" {i + 1}. {favoriteFoods[i]} {message}");
}
