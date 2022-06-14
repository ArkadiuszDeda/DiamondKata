namespace DiamondKata
{
    public class CharacterInformation
    {
        public CharacterInformation(char character, int index, int spaceBetween)
        {
            Character = character;
            Index = index;
            SpaceBetween = spaceBetween;
        }

        public char Character { get; }
        public int Index { get; }
        public int SpaceBetween { get; }

    }
}
