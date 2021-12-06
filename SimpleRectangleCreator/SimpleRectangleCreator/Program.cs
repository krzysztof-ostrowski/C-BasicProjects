//Display rectangle in console with height and width shown in "*"


Console.WriteLine("Enter rectangle height:");
var height = int.Parse(Console.ReadLine());
Console.WriteLine("Enter rectangle width:");
var width = int.Parse(Console.ReadLine());


for (int j = 0; j < height; j++)
{
    for (int i = 0; i < width; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}

Console.ReadKey();