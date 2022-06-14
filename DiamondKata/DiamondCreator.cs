using System.Text;

namespace DiamondKata
{
    public class DiamondCreator
    {
        readonly Dictionary<char, CharacterInformation> characterIndexes;
        private readonly IDiamondLevelCreator diamondLevelCreator;

        public DiamondCreator(IAlphabetCharacterIndexesCreator diamondCharacterPositionsCreator, IDiamondLevelCreator diamondLevelCreator)
        {
            characterIndexes = diamondCharacterPositionsCreator.GetAll();
            this.diamondLevelCreator = diamondLevelCreator;
        }

        public string Create(char midpointCharacter)
        {
            var builder = new StringBuilder();
            var midpointCharInformation = characterIndexes[midpointCharacter];
            var midpointCharIndex = midpointCharInformation.Index;
            for (var i = 0; i <= midpointCharIndex; i++)
            {
                var currentCharInformation = characterIndexes.ElementAt(i).Value;
                diamondLevelCreator.AppendDiamondLevel(builder, currentCharInformation, midpointCharInformation);
            }
            for (var i = midpointCharIndex - 1; i >= 0; i--)
            {
                var currentCharInformation = characterIndexes.ElementAt(i).Value;
                diamondLevelCreator.AppendDiamondLevel(builder, currentCharInformation, midpointCharInformation);
            }

            return builder.ToString();
        }
    }
}
