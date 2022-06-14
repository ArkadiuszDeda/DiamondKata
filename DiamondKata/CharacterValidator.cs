namespace DiamondKata
{
    public class CharacterValidator
    {
        private readonly Dictionary<char, CharacterInformation> characterIndexes;

        public CharacterValidator(AlphabetCharacterIndexesCreator alphabetCharacterIndexesCreator)
        {
            characterIndexes = alphabetCharacterIndexesCreator.GetAll();
        }

        public bool Validate(char character)
        {
            return characterIndexes.ContainsKey(character);
        }
    }
}
