using Nancy;
using System.Collections.Generic;
using Scrabble.Objects;
using System;

namespace Scrabble
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/score"] = _ =>
      {
        ScrabbleScorer newScrabbleScorer = new ScrabbleScorer(Request.Form["user-word"]);
        int score = newScrabbleScorer.GetScore();
        return View["index.cshtml", score];
      };
    }
  }
}
