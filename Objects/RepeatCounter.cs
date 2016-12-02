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
        if (word == inputWord)
        {
          wordInstanceCount += 1;
        }
      }
      return wordInstanceCount;
    }

    public static int CountRepeats(string inputWord, string inputPhrase, bool caseSensitive)
    {
      int wordInstanceCount = 0;
      inputWord = (caseSensitive) ? inputWord : inputWord.ToLower();

      List<string> phraseWords = new List<string>(inputPhrase.Split(' '));

      foreach (string word in phraseWords) {

        string checkWord = (caseSensitive) ? word : word.ToLower();

        if (checkWord == inputWord)
        {
          wordInstanceCount += 1;
        }
      }
      return wordInstanceCount;
    }
  }
}
