// See https://aka.ms/new-console-template for more information
using DiamondKata;

Console.WriteLine("Please provide character to create diamond for: ");
var character = Console.Read();

Console.WriteLine("Thank you.");
Console.WriteLine("Rendering complete. Your diamond:");
Console.WriteLine();
var diamondCreator = new DiamondCreator(new AlphabetCharacterIndexesCreator(), new DiamondLevelCreator());
Console.WriteLine(diamondCreator.Create((char)character));
