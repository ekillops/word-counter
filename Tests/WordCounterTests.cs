using Xunit;
using System;
using WordCounter.Objects;

namespace WordCounterTests
{
  public class CountRepeatTests
  {
    [Theory]
    [InlineData("a", "a", 1)] // Spec 1 - Count instances of a single character in a single character phrase
    [InlineData("cat", "the fat cat", 1)] // Spec 2 - Count instances of a multi-character word in a phrase
    [InlineData("cat", "the Fat CaT", 1)] // Spec 3 - Ignore case in phrase when counting
    public void CountRepeatTheory(string word, string phrase, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase));
    }
  }
}
