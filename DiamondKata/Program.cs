// See https://aka.ms/new-console-template for more information
using DiamondKata;

var characterIndexesCreator = new AlphabetCharacterIndexesCreator();
var diamondCreator = new DiamondCreator(characterIndexesCreator, new DiamondLevelCreator());
var validator = new CharacterValidator(characterIndexesCreator);



Console.WriteLine("Please provide exactly one uppercase english character to create diamond for: ");
var characterAsInt = Console.Read();
var character = (char)characterAsInt;

Console.WriteLine("Thank you. Your character: " + character);
if (!validator.Validate(character))
{
    Console.WriteLine("Your character is not valid.");
    return;
}

Console.WriteLine("Rendering complete. Your diamond:");
Console.WriteLine();
Console.WriteLine(diamondCreator.Create(character));
