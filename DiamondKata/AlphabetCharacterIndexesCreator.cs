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
                spaceBetween = CalculateNewSpaceBetween(index, spaceBetween);

                characterIndexes.Add(letter, new CharacterInformation(letter, index, spaceBetween));
                index++;
            }

            return characterIndexes;
        }

        private static int CalculateNewSpaceBetween(int index, int spaceBetween)
        {
            if (index < 2)
            {
                spaceBetween = index;
            }
            else
            {
                spaceBetween += 2;
            }

            return spaceBetween;
        }
    }
}
