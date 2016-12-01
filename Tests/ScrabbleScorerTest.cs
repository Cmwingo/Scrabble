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

    [Fact]
    public void ScrabbleScorerTest2_WholeWord_True()
    {
      ScrabbleScorer testScrabbleScorer = new ScrabbleScorer("cat");
      Assert.Equal(5, testScrabbleScorer.GetScore());
    }
  }
}
