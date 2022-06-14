namespace DiamondKata
{
    public class AlphabetCharacterIndexesCreator : IAlphabetCharacterIndexesCreator
    {
        public Dictionary<char, CharacterInformation> GetAll()
        {
            var characterIndexes = new Dictionary<char, CharacterInformation>();
            int index = 0;
            int spaceBetween = 0;

            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                if (index < 2)
                {
                    spaceBetween = index;
                } 
                else
                {
                    spaceBetween += 2;
                }

                characterIndexes.Add(letter, new CharacterInformation(letter, index, spaceBetween));
                index++;
            }

            return characterIndexes;
        }
    }

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
