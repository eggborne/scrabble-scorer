using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models;

public class Player 
{
  public string name;
  public int score = 0;
  public Player(string enteredName)
  {
    name = enteredName;
  }



}