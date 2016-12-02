using System;
using System.Collections.Generic;


namespace WordCounter.Objects
{
  public static class RepeatCounter
  {
    public static int CountRepeats(string inputWord, string inputPhrase)
    {

      int wordInstanceCount = 0;

      List<string> phraseWords = new List<string>(inputPhrase.Split(' '));

      foreach (string word in phraseWords) {
        if (word.ToLower() == inputWord.ToLower())
        {
          wordInstanceCount += 1;
        }
      }
      return wordInstanceCount;
    }
  }
}
