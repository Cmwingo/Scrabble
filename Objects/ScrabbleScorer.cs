using System;
using System.Collections.Generic;

namespace Scrabble.Objects
{
  public class ScrabbleScorer
  {
    private Dictionary<string, int> _scoreTable = new Dictionary<string, int>() {{"aeioulnrst", 1}, {"dg", 2}, {"bcmp", 3}, {"fhvwy", 4}, {"k", 5}, {"jx", 8}, {"qz", 10}};
    private string _userInput;
    private int _score = 0;

    public ScrabbleScorer(string userInput)
    {
      _userInput = userInput;
    }

    public int GetScore()
    {
      foreach (var pair in _scoreTable)
      {
        if(pair.Key.Contains(_userInput))
        {
          _score += pair.Value;
        }
      }
      return _score;
    }
  }
}
