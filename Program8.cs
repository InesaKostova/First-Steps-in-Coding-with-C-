int foodDogs = int.Parse(Console.ReadLine());
int foodCats = int.Parse(Console.ReadLine());

double priceFoodDogs = foodDogs * 2.50;
double priceFoodCats = foodCats * 4;
double totalPrice = priceFoodDogs + priceFoodCats;

Console.WriteLine($"{totalPrice} lv.");
