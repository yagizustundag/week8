
string[] tvShows = { "Firefly", "Office", "The Last of Us", "Friends", "Twin Peaks", "House", "Stranger Things" };

string[] food = { "sushi", "pizza", "Chinese takeaway", "burger and chips", "chicken wings", "chips", "popcorn" };

string[] drinks = { "mineral water", "Coca-Cola", "apple juice", "milk", "beer" };

//int RandomIndex = random.Next(0,tvShows.Length);
//string RandomMovie = tvShows[RandomIndex];
//Console.WriteLine(RandomMovie);

//RandomIndex = random.Next(0, food.Length);
//string RandomFood =food[RandomIndex];
//Console.WriteLine(RandomFood);

//RandomIndex = random.Next(0, drinks.Length);
//string RandomDrink = drinks[RandomIndex];
//Console.WriteLine(RandomDrink);

string randommovie = PickRandomFromArray(tvShows);
string randomfood = PickRandomFromArray(food);
string randomdrink = PickRandomFromArray(drinks);


Console.WriteLine($"I recomend you to watch {randommovie} tonight.");
Console.WriteLine($"Order some {randomdrink} and {randomfood}");

static string PickRandomFromArray(string[] somearray)
{
    Random random = new Random();
    int randomindex = random.Next(0, somearray.Length);
    string RandomElement = somearray[randomindex];
    return RandomElement;
}

