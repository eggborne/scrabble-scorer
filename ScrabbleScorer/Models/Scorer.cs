using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models
{
  public class Scorer 
  {
    private static Dictionary<char, int> _wordScores = new Dictionary<char, int>
    {
      {'a', 1},
      {'e', 1},
      {'i', 1},
      {'o', 1},
      {'u', 1},
      {'l', 1},
      {'n', 1},
      {'r', 1},
      {'s', 1},
      {'t', 1},
      {'d', 2},
      {'g', 2},
      {'b', 3},
      {'c', 3},
      {'m', 3},
      {'p', 3},
      {'f', 4},
      {'h', 4},
      {'v', 4},
      {'w', 4},
      {'y', 4},
      {'k', 5},
      {'j', 8},
      {'x', 8},
      {'q', 10},
      {'z', 10},
    };

    private static int ProduceWordScore(string word)
    {
      int score = 0;
      char[] letters = word.ToLower().ToCharArray();
      foreach (var letter in letters) {
        int letterValue = 0;
        try {
          letterValue = _wordScores[letter];
        }
        catch {
          return 0;
        }
        score += letterValue;
      }
      return score;
    }

    public static int ProduceSentenceScore(string sentence)
    {
      int sentenceScore = 0;
      string[] wordArray = sentence.Split(" ");
      foreach (var word in wordArray) {
        sentenceScore += Scorer.ProduceWordScore(word);
      }
      return sentenceScore;
    }
  }
}