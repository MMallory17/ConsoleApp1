Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");


Console.WriteLine("Enter Length");
int Length = (int)Decimal.Parse(Console.ReadLine());
Console.WriteLine("Enter Width");
int Width = (int)Decimal.Parse(Console.ReadLine());
int Area = Length * Width;
Console.WriteLine("calculated " + Area);
int Perimeter = 2 * (Length + Width);
Console.WriteLine("calculated " + Perimeter);

{
    if (Area <= 250)
        Console.WriteLine("calculated this is a small-sized room.");

    else if (250 < Area) _ =(Area < 650);
   Console.WriteLine("calculated this is a medium-sized room.");

if (650 <= Area)
    Console.WriteLine("calulated this is a large-sized room.");
}

Console.WriteLine("Thank you for using the Room Detail Generator!");

        
