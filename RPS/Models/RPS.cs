using System.Collections.Generic;

namespace RPS.Models

{
 public class RPSGame
 {
    public string PlayRPS(string player1Choice, string player2Choice)
    {
      if (player1Choice == player2Choice)

      {
       return "Draw";
      }

      else if ((player1Choice == "Rock" && player2Choice == "Scissors") ||
               (player1Choice == "Scissors" && player2Choice == "Paper") || 
               (player1Choice == "Paper" && player2Choice == "Rock"))
      {
       return "Player 1";
      }

     else
      {
       return "Player 2";
      }         
    }
 }
}
 




// else if ((player1Choice == "Rock" && player2Choice == "Scissors") ||
//       (player1Choice == "Paper" && player2Choice == "Rock") || (player1Choice == "Scissors" && player2Choice == "Paper")) 
      
//       {
//         return "Player1 Wins!";
//       }

//       else if ((player1Choice == "Scissors" && player2Choice == "Rock") ||
//       (player1Choice == "Paper" && player2Choice == "Scissors") ||
//       (player1Choice == "Rock" && player2Choice == "Paper"))
      
//       {
//         return "Player2 Wins!";
//       }