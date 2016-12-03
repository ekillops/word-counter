using System;
using System.Collections.Generic;


namespace WordCounter.Objects
{
  public static class RepeatCounter
  {
    // Base version. Checks every word in inputPhrase for direct equivalency to inputWord
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

    // Overloaded version to handle case sensitivity and apostrophes
    public static int CountRepeats(string inputWord, string inputPhrase, bool caseSensitive = false, bool ignoreApostrophes = false)
    {
      int wordInstanceCount = 0;
      inputWord = (caseSensitive) ? inputWord : inputWord.ToLower(); // if not case sensitive call ToLower()

      List<string> phraseWords = new List<string>(inputPhrase.Split(' '));

      foreach (string word in phraseWords) {

        string checkWord = RemoveTrailingPunctuation(word);

        checkWord = (caseSensitive) ? checkWord : checkWord.ToLower(); // if not case sensitive call ToLower()
        checkWord = (ignoreApostrophes) ? RemoveApostrophes(checkWord) : checkWord; // if ignoring apostrophes RemoveApostrophes() from word being checked against

        if (checkWord == inputWord)
        {
          wordInstanceCount += 1;
        }
      }
      return wordInstanceCount;
    }

    // Helper method. Return a copy of a string with apostrophes removed
    private static string RemoveApostrophes(string inputWord)
    {
      string outputWord = "";
      foreach (char letter in inputWord) {
        if (letter != '\'')
        {
          outputWord += letter;
        }
      }
      return outputWord;
    }

    private static string RemoveTrailingPunctuation(string inputWord)
    {

      string badChars = ".,!?':;/\\";
      int lastCharIndex = inputWord.Length - 1;
      string lastChar = inputWord[lastCharIndex].ToString();


      if (badChars.Contains(lastChar))
      {
        return inputWord.Remove(lastCharIndex);
      }
      else
      {
        return inputWord;
      }
    }

  }
}
