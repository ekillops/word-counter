using Xunit;
using System;
using WordCounter.Objects;

namespace WordCounterTests
{
  public class CountRepeatTests
  {
    [Theory]
    [InlineData("a", "a", 1)]
    public void CountRepeatTheory(string word, string phrase, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase));
    }
  }
}
