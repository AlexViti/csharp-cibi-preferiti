string[] favoriteFoods = { "pizza", "burgers", "sushi", "steak", "apples", "carrots" };

Console.WriteLine("Array length: " + favoriteFoods.Length);

foreach (string food in favoriteFoods)
{
    Console.WriteLine(food);
}

Console.WriteLine("My favorite food: " + favoriteFoods[0]);

Console.WriteLine("My favorite food: " + favoriteFoods[favoriteFoods.Length - 1]);

// Bonus

if (favoriteFoods.Length % 2 == 0)
{
    Console.WriteLine("The middle elements are: " + favoriteFoods[favoriteFoods.Length / 2] + " and " + favoriteFoods[favoriteFoods.Length / 2 + 1]);
}
else
{
    Console.WriteLine("The middle element is: " + favoriteFoods[favoriteFoods.Length / 2]);
}