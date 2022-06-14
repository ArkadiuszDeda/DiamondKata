using DiamondKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKataTests
{
    public class CharacterValidatorTests
    {
        readonly CharacterValidator sut;

        public CharacterValidatorTests()
        {
            sut = new CharacterValidator(new AlphabetCharacterIndexesCreator());
        }


        [Theory]
        [InlineData('A')]
        [InlineData('B')]
        [InlineData('Z')]
        public void Validate_ValidCharacter_ReturnsTrue(char character)
        {
            Assert.True(sut.Validate(character));
        }

        [Theory]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('0')]
        [InlineData('ą')]
        [InlineData('ż')]
        [InlineData('-')]
        public void Validate_InvalidCharacter_ReturnsFalse(char character)
        {
            Assert.False(sut.Validate(character));
        }
    }
}
