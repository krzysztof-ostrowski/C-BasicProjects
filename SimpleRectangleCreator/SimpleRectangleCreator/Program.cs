//Display rectangle in console with height and width shown in "*"

Start:
Console.ForegroundColor = ConsoleColor.Green;
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

Console.WriteLine("Would you like to create rectangle again?");
Console.WriteLine("Press 'y' if yes and 'n' if no: ");
Decision:
var decision = Console.ReadKey(true);

if (decision.KeyChar == 'y')
{
    goto Start;
}
else if (decision.KeyChar=='n')
{
    goto End;
}
else
{
    Console.WriteLine("wrong key :(");
    goto Decision;
}
End: ;
