using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleScorerTests
  {
    [TestMethod]
    public void ProduceWordScore_RejectsNonLetters_Int()
    {
      int scoreForInvalidString = Scorer.ProduceWordScore("hjk4kjh");
      Assert.AreEqual(scoreForInvalidString, 0);
    }
    [TestMethod]
    public void ProduceWordScore_GetsCorrectScore_Int()
    {
      int scoreForValidString = Scorer.ProduceWordScore("quiz");
      Assert.AreEqual(scoreForValidString, 22);
    }
  }
}