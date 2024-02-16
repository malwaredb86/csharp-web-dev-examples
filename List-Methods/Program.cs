List<string> planets = new List<string>();

planets.Add("Mercury");
planets.Add("Venus");
planets.Add("Earth");
planets.Add("Mars");
planets.Add("Jupiter");
planets.Add("Saturn");
planets.Add("Uranus");
planets.Add("Neptune");

Console.WriteLine("The " + (planets.IndexOf("Earth") + 1) + " rock from the sun is " + planets[2] + ".");

Console.WriteLine("What planet are you looking for, Explorer? ");
string planetSearch = Console.ReadLine();
if (!Equals(planets.IndexOf(planetSearch), -1))
{
    Console.WriteLine("You found the planet " + planetSearch + ", Explorer!");
} else
{
    Console.WriteLine(planetSearch + " is not a planet, Explorer!");
}

Console.WriteLine("Look for another planet, Explorer?");
string planetSearch2 = Console.ReadLine();
if (planets.Contains(planetSearch2))
{
    Console.WriteLine("It is true that " + planetSearch2 + " is a planet.");
}
else
{
    Console.WriteLine("It is NOT true that " + planetSearch2 + " is a planet.");
}

Console.WriteLine("There are " + planets.Count + " planets in our solary system.");