using System.Text;

namespace DiamondKata
{
    public class DiamondLevelCreator : IDiamondLevelCreator
    {
        private const string EndLine = "\r\n";
        private const char Space = ' ';

        public void AppendDiamondLevel(StringBuilder builder, CharacterInformation currentChar, CharacterInformation midpointChar)
        {
            AppendPrespaces(builder, currentChar.Index, midpointChar.Index);
            builder.Append(currentChar.Character);

            bool isTopOrBottom = currentChar.Index == 0;
            if (isTopOrBottom)
            {
                builder.Append(EndLine);
                return;
            }

            AppendMiddleSpaces(builder, currentChar.SpaceBetween);
            builder.Append(currentChar.Character);
            builder.Append(EndLine);
        }

        private static void AppendMiddleSpaces(StringBuilder builder, int spaceBetween)
        {
            for (var i = 0; i < spaceBetween; i++)
            {
                builder.Append(Space);
            }
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
