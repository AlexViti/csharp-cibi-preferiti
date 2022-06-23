string[] favoriteFoods = { "pizza", "burgers", "sushi", "steak", "apples" };

Console.WriteLine("Array length: " + favoriteFoods.Length);

Console.WriteLine("My favorite foods are: ");

for (int i = 0; i < favoriteFoods.Length; i++)
{
    Console.WriteLine(" " + i + 1 + ". " + favoriteFoods[i]);
}

Console.WriteLine("My favorite food of all: " + favoriteFoods[0]);

Console.WriteLine("My least favorite food: " + favoriteFoods[favoriteFoods.Length - 1]);

// Bonus

if (favoriteFoods.Length % 2 == 0)
{
    Console.WriteLine("The middle elements are: " + favoriteFoods[favoriteFoods.Length / 2 - 1] + " and " + favoriteFoods[favoriteFoods.Length / 2]);
}
else
{
    Console.WriteLine("The middle element is: " + favoriteFoods[favoriteFoods.Length / 2]);
}