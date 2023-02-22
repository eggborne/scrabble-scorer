using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models;

public class Game
{
  List<Player> players = new List<Player> { };


  public void InitiateGame()
  {
    EstablishPlayers();

    BeginGame();
  }

  public void EstablishPlayers()
  {
    Console.WriteLine("Enter name for player 1:");
    string player1Name = Console.ReadLine();
    Player player1 = new Player(player1Name);
    this.players.Add(player1);
    Console.WriteLine("Enter name for player 2:");
    string player2Name = Console.ReadLine();
    Player player2 = new Player(player2Name);
    this.players.Add(player2);
    bool userAddingPlayers = true;
    List<string> chosenNames = new List<string> {
      player1.name,
      player2.name
    };
    while (userAddingPlayers)
    {
      Console.WriteLine("Add another player? y/N");
      string addMorePlayers = Console.ReadLine();
      if (addMorePlayers.ToLower() == "y")
      {
        PromptForMorePlayers(chosenNames);
      }
      else
      {
        userAddingPlayers = false;
      }
    }
  }

  public void PromptForMorePlayers(List<string> chosenNames) {
    Console.WriteLine($"Enter name for player {this.players.Count + 1}:");
    string playerName = Console.ReadLine();
    if (!chosenNames.Contains(playerName)) {
      Player player = new Player(playerName);
      this.players.Add(player);
    } else {
      Console.Write("Name taken! ");
      PromptForMorePlayers(chosenNames);
    }
  }

public void BeginGame() {
    Dictionary<string, int> playerScores = new Dictionary<string, int>{};
    string finalScoreString = $"Final scores: ";
    int winningScore = 0;
    string winner = "";
    for (var i = 0; i < this.players.Count; i++)
    {
      string playerName = this.players[i].name;
      Console.WriteLine($"{playerName}, Enter your word:");
      string userInputString = Console.ReadLine();
      int wordScore = Scorer.ProduceSentenceScore(userInputString);
      playerScores[playerName] = wordScore;
      finalScoreString += $"{playerName}: {wordScore}";
      if (i < (this.players.Count - 1)) {
        finalScoreString += ", ";
      }
      if (wordScore > winningScore) {
        winningScore = wordScore;
        winner = playerName;
      }
    }
    Console.WriteLine(finalScoreString);
    Console.WriteLine($"Winner: {winner} with {winningScore} points");
    Console.WriteLine("Play again? Y/n");
    string playAgain = Console.ReadLine();
    if (playAgain.ToLower() == "n") {
      Environment.Exit(0);
    } else {
      BeginGame();
    }
  }
}

