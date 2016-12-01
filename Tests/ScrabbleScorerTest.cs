using Xunit;
using System.Collections.Generic;
using Scrabble.Objects;

namespace Scrabble
{
  public class ScrabbleScorerTest
  {
    [Fact]
    public void ScrabbleScorerTest1_SingleLetter_True()
    {
      ScrabbleScorer testScrabbleScorer = new ScrabbleScorer("p");
      Assert.Equal(3, testScrabbleScorer.GetScore());
    }
  }
}
