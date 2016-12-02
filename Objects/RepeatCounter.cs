using System;
using System.Collections.Generic;


namespace WordCounter.Objects
{
  public static class RepeatCounter
  {
    public static int CountRepeats(string word, string phrase)
    {
      int wordInstanceCount = 0;

      if (word ==  phrase)
      {
        wordInstanceCount += 1;
      }
      return wordInstanceCount;
    }
  }
}
