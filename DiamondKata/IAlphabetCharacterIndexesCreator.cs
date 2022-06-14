namespace DiamondKata
{
    public interface IAlphabetCharacterIndexesCreator
    {
        Dictionary<char, CharacterInformation> GetAll();
    }
}