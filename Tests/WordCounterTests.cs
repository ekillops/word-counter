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

    [Theory]
    [InlineData("its", "it's not its", false, true, 2)] // Spec 5 - Ignore apostrophes in phrase when counting if user chooses
    public void CountRepeats_ApostropheSensitiveTheory(string word, string phrase, bool matchCase, bool ignoreApostrophes, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase, matchCase, ignoreApostrophes));
    }

    [Theory]
    [InlineData("red", "the color red.", false, false, 1)] // Spec 6 - Ignore punctuation at the end of a word in phrase
    public void CountRepeats_IgnoreTrailingPunctuationTheory(string word, string phrase, bool matchCase, bool ignoreApostrophes, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase, matchCase, ignoreApostrophes));
    }

    [Theory]
    [InlineData("color", "two colors", false, false, true, 1)] // Spec 7 - Count generically pluralized versions of words if specified
    public void CountRepeats_ApostropheSensitiveTheory(string word, string phrase, bool matchCase, bool ignoreApostrophes, bool matchPlural, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase, matchCase, ignoreApostrophes, matchPlural));
    }

    [Theory]
    [InlineData("hi", "\"Hi\", he said.", false, false, false, 1)] // Spec 8 - Ignore punctuation at the start of a word in phrase
    public void CountRepeats_IgnoreLeadingPunctuationTheory(string word, string phrase, bool matchCase, bool ignoreApostrophes, bool matchPlural, int expectedResult)
    {
      Assert.Equal(expectedResult, RepeatCounter.CountRepeats(word, phrase, matchCase, ignoreApostrophes, matchPlural));
    }
  }
}
