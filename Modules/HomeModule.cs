using Nancy;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];

      Get["/count"] =_=> {
        string word = Request.Query["word"];
        string phrase = Request.Query["phrase"];
        bool caseSensitive = Request.Query["case-sensitive"];
        bool ignoreApostrophes = Request.Query["ignore-apostrophes"];

        string occurrences = RepeatCounter.CountRepeats(word, phrase, caseSensitive, ignoreApostrophes).ToString();

        Dictionary<string, string> returnModel = new Dictionary<string, string>()
        {
          {"word", word},
          {"occurrences", occurrences},
          {"phrase", phrase},
          {"case-sensitive", (caseSensitive) ? "Yes" : "No"},
          {"ignore-apostrophes", (ignoreApostrophes) ? "Yes" : "No"}
        };

        return View["count.cshtml", returnModel];
      };
    }
  }
}
