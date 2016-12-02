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
    public void CountRepeatsTheory(string word, string phrase, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase));
    }

    [Theory]
    [InlineData("cat", "the Fat CaT", false, 1)] // Spec 3 - Ignore case in phrase when counting
    [InlineData("South", "south of South America", true, 1)] // Spec 4 - Do not ignore case in phrase if user chooses
    public void CountRepeats_CaseSensitiveTheory(string word, string phrase, bool matchCase, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase, matchCase));
    }
  }
}
