using System.Text;

namespace DiamondKata
{
    public class DiamondCreator
    {
        private const string EndLine = "\r\n";
        private const char Space = ' ';
        readonly Dictionary<char, CharacterInformation> characterIndexes;

        public DiamondCreator(IAlphabetCharacterIndexesCreator diamondCharacterPositionsCreator)
        {
            characterIndexes = diamondCharacterPositionsCreator.GetAll();
        }

        public string Create(char midpointCharacter)
        {
            var builder = new StringBuilder();
            var midpointCharInformation = characterIndexes[midpointCharacter];
            var midpointCharIndex = midpointCharInformation.Index;
            for (var i = 0; i <= midpointCharIndex; i++)
            {
                var currentCharInformation = characterIndexes.ElementAt(i).Value;
                AppendDiamondLevel(builder, currentCharInformation, midpointCharInformation);
            }
            for (var i = midpointCharIndex - 1; i >= 0; i--)
            {
                var currentCharInformation = characterIndexes.ElementAt(i).Value;
                AppendDiamondLevel(builder, currentCharInformation, midpointCharInformation);
            }

            return builder.ToString();
        }

        private void AppendDiamondLevel(StringBuilder builder, CharacterInformation currentChar, CharacterInformation midpointChar)
        {
            AppendPrespaces(builder, currentChar.Index, midpointChar.Index);
            AppendCharacter(builder, currentChar.Character);

            bool isTopOrBottom = currentChar.Index == 0;
            if (isTopOrBottom)
            {
                builder.Append(EndLine);
                return;
            }

            AppendMiddleSpaces(builder, currentChar.SpaceBetween);
            AppendCharacter(builder, currentChar.Character);
            builder.Append(EndLine);
        }

        private static void AppendMiddleSpaces(StringBuilder builder, int spaceBetween)
        {
            for (var i = 0; i < spaceBetween; i++)
            {
                builder.Append(Space);
            }
        }

        private void AppendCharacter(StringBuilder builder, char character)
        {
            builder.Append(character);
        }

        private static void AppendPrespaces(StringBuilder builder, int currentIndex, int midpointCharIndex)
        {
            var preSpacesCount = midpointCharIndex - currentIndex;
            for (var i = 0; i < preSpacesCount; i++)
            {
                builder.Append(Space);
            }
        }
    }
}
