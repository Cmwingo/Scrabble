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
      _userInput = userInput.ToLower();
    }

    public int GetScore()
    {
      foreach (var pair in _scoreTable)
      {
        // char[] letters = _userInput.Split(" ");
        foreach (char letter in _userInput)
        {
          if(pair.Key.Contains(letter.ToString()))
          {
            _score += pair.Value;
          }
        }
      }
      return _score;
    }
  }
}
