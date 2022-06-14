// See https://aka.ms/new-console-template for more information
using DiamondKata;

Console.WriteLine("Please provide character to create diamond for: ");
var character = Console.Read();

Console.WriteLine("Thank you.");
Console.WriteLine("Computing please wait it will take up to couple of minutes to render image...");
Console.WriteLine("Rendering complete. Your shiny new diamond:");
Console.WriteLine();
var diamondCreator = new DiamondCreator(new AlphabetCharacterIndexesCreator());
Console.WriteLine(diamondCreator.Create((char)character));

Console.WriteLine("Dont forget to like and subscribe!");