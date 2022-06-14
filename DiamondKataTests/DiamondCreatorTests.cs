using DiamondKata;

namespace DiamondKataTests
{
    public class DiamondCreatorTests
    {
        readonly DiamondCreator sut;

        public DiamondCreatorTests()
        {
            sut = new DiamondCreator(new AlphabetCharacterIndexesCreator(), new DiamondLevelCreator());
        }

        [Fact]
        public void Create_A_ReturnsExpectedDiamond()
        {
            var expected =
@"A
";
            var diamond = sut.Create('A');

            Assert.Equal(expected, diamond);
        }

        [Fact]
        public void Create_B_ReturnsExpectedDiamond()
        {
            var expected =
@" A
B B
 A
";
            var diamond = sut.Create('B');

            Assert.Equal(expected, diamond);
        }

        [Fact]
        public void Create_C_ReturnsExpectedDiamond()
        {
            var expected =
@"  A
 B B
C   C
 B B
  A
";
            var diamond = sut.Create('C');

            Assert.Equal(expected, diamond);
        }

        [Fact]
        public void Create_D_ReturnsExpectedDiamond()
        {
            var expected =
@"   A
  B B
 C   C
D     D
 C   C
  B B
   A
";
            var diamond = sut.Create('D');

            Assert.Equal(expected, diamond);
        }


        [Fact]
        public void Create_E_ReturnsExpectedDiamond()
        {
            var expected =
@"    A
   B B
  C   C
 D     D
E       E
 D     D
  C   C
   B B
    A
";
            var diamond = sut.Create('E');

            Assert.Equal(expected, diamond);
        }

    }
}