using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CheckWinCondition : MonoBehaviour
{
    public bool thereIsWinner = false;
    [SerializeField] private GameObject gameMessageCanvas;
    [SerializeField] private GameObject turnManager;
    [SerializeField] private GameObject boardController;

    public void CheckWinner()
    {
        BoardTracker boardPositions = boardController.GetComponent<BoardTracker>();
        string[,] board = boardPositions.TrackBoard();

        //loop to check each row and colum in the board
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0] != "")
            {
                thereIsWinner = true;
                break;
            }
            else if (board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i] != "")
            {
                thereIsWinner = true;
                break;
            }
        }

        if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != "")
        {
            thereIsWinner = true;
        }
        else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != "")
        {
            thereIsWinner = true;
        }

        ManageTurns turns = turnManager.GetComponent<ManageTurns>();
        TMP_Text winMessage = gameMessageCanvas.GetComponentInChildren<TMP_Text>();

        if (!thereIsWinner && turns.turnNumber >= 9)
        {
            winMessage.text = "Youv'e reached a Tie!";
            gameMessageCanvas.SetActive(true);
        }

        else if (thereIsWinner)
        {
            Debug.Log("WINNER");
            turns.EndTurn();
            turns.CheckWhoseTurn();
            PlayerClass winner = turns.turnTaker;
            winMessage.text = winner.Name + " wins!";
            gameMessageCanvas.SetActive(true);
        }
    }
}
