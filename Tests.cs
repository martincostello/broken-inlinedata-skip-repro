using Xunit;

namespace BrokenInlineDataSkip
{
    public static class Tests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4, Skip = "Skipped")]
        public static void Can_Add_Integers(int x, int y, int expected) => Assert.Equal(expected, x + y);
    }
}
