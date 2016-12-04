using System;
using System.Collections.Generic;


namespace WordCounter.Objects
{
  public static class RepeatCounter
  {
    // // Base version. Checks every word in inputPhrase for direct equivalency to inputWord
    // public static int CountRepeats(string inputWord, string inputPhrase)
    // {
    //
    //   int wordInstanceCount = 0;
    //
    //   List<string> phraseWords = new List<string>(inputPhrase.Split(' '));
    //
    //   foreach (string word in phraseWords) {
    //     if (word == inputWord)
    //     {
    //       wordInstanceCount += 1;
    //     }
    //   }
    //   return wordInstanceCount;
    // }
    //
    // // Overloaded version to handle case sensitivity and apostrophes
    // public static int CountRepeats(string inputWord, string inputPhrase, bool caseSensitive = false, bool ignoreApostrophes = false)
    // {
    //   int wordInstanceCount = 0;
    //   inputWord = (caseSensitive) ? inputWord : inputWord.ToLower(); // if not case sensitive call ToLower()
    //
    //   List<string> phraseWords = new List<string>(inputPhrase.Split(' '));
    //
    //   foreach (string word in phraseWords) {
    //
    //     string checkWord = RemoveTrailingPunctuation(word);
    //
    //     checkWord = (caseSensitive) ? checkWord : checkWord.ToLower(); // if not case sensitive call ToLower()
    //     checkWord = (ignoreApostrophes) ? RemoveApostrophes(checkWord) : checkWord; // if ignoring apostrophes RemoveApostrophes() from word being checked against
    //
    //     if (checkWord == inputWord)
    //     {
    //       wordInstanceCount += 1;
    //     }
    //   }
    //   return wordInstanceCount;
    // }

    // Further overloaded to handle plurals;
    public static int CountRepeats(string inputWord, string inputPhrase, bool caseSensitive = false, bool ignoreApostrophes = false, bool includePlural = false)
    {
      int wordInstanceCount = 0;

      // if not case sensitive call ToLower()
      inputWord = (caseSensitive) ? inputWord : inputWord.ToLower();

      // split phrase into list of words
      List<string> phraseWords = new List<string>(inputPhrase.Split(' '));

      foreach (string word in phraseWords) {

        // Clean up word for easier checking against
        string checkWord = StripPunctuation(word);
        checkWord = (caseSensitive) ? checkWord : checkWord.ToLower();
        checkWord = (ignoreApostrophes) ? RemoveApostrophes(checkWord) : checkWord;
        
        // create pluralized version of inputWord to check against
        string inputWordPlural = Pluralize(inputWord);

        // check for normal equivalency then, if specified, check for plural equivilency
        if (checkWord == inputWord)
        {
          wordInstanceCount += 1;
        }
        else if (includePlural && checkWord == inputWordPlural)
        {
          wordInstanceCount += 1;
        }
      }
      return wordInstanceCount;
    }

    // Helper method. Return a copy of a string with apostrophes removed. "don't" -> "dont"
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

    // Helper method to remove punctuation at the start and end of a word. "cat." -> "cat"
    private static string StripPunctuation(string inputWord)
    {

      char[] badChars = { '.', ',', '!', '?', '"', ':', ';', ')', '(' };

      inputWord = inputWord.TrimStart(badChars);
      inputWord = inputWord.TrimEnd(badChars);

      return inputWord;
    }

    // Helper method to generically pluralize a word. "cat" -> "cats"
    private static string Pluralize(string inputWord)
    {
      char lastChar = inputWord[inputWord.Length - 1];

      if (lastChar == 's' || lastChar == 'z')
      {
        inputWord += "es";
      }
      else
      {
        inputWord += "s";
      }
      return inputWord;
    }
  }
}
