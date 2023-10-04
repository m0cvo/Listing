// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Listing;


WorkWithStrings();

fibonacciNumbers();

WorkWithWeather();

void fibonacciNumbers()
{
    var fibonacciNumbers = new List<int> { 1, 1 };

    while (fibonacciNumbers.Count < 20)
    {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
    }
    foreach (var item in fibonacciNumbers)
    {
        Console.WriteLine(item);
    }
}

void WorkWithStrings()
{
    //First lest's create a list of names
    var names = new List<string> { "Nigel", "Ana", "Felipe" };
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    //Now let's amend the list by adding some more names and removing one.
    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    //Now let's index some list members..
    Console.WriteLine();
    Console.WriteLine($"My name is {names[0]}");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

    //Let's see how many members the list has...
    Console.WriteLine();
    Console.WriteLine($"The list has {names.Count} people in it.");

    //Let's use the IndexOf feature to find the index of a member
    Console.WriteLine();
    var index = names.IndexOf("Felipe");
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"the name {names[index]} is at index {index}");
    }

    index = names.IndexOf("Not Found");
    Console.WriteLine();
    if (index == -1)
    {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"the name {names[index]} is at index {index}");
    }

    Console.WriteLine();
    names.Sort();
    foreach(var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }
}

void WorkWithWeather()
{
    WeatherData weatherData = new WeatherData();
    List<WeatherData> list = new List<WeatherData>();
    while (Console.ReadLine() != null)
    {
        Console.Write("Enter the date (dd-mm-yy: ");
        weatherData.date = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter the Temperature in C: ");
        weatherData.temperatureC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        string data = weatherData.date + " " + weatherData.temperatureC;
        list.Add(weatherData);
        foreach (var item in list)
        {
            Console.WriteLine(weatherData);
        }
    }
}