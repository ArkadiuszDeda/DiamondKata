using System.Text;

namespace DiamondKata
{
    public interface IDiamondLevelCreator
    {
        void AppendDiamondLevel(StringBuilder builder, CharacterInformation currentChar, CharacterInformation midpointChar);
    }
}