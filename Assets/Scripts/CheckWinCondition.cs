using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CheckWinCondition : MonoBehaviour
{
    [SerializeField] TMP_Text TopLeft;
    [SerializeField] TMP_Text TopMid;
    [SerializeField] TMP_Text TopRight;
    [SerializeField] TMP_Text MidMid;
    [SerializeField] TMP_Text MidLeft;
    [SerializeField] TMP_Text MidRight;
    [SerializeField] TMP_Text BottomLeft;
    [SerializeField] TMP_Text BottomMid;
    [SerializeField] TMP_Text BottomRight;
    public bool thereIsWinner = false;
    [SerializeField] private GameObject gameMessageCanvas;
    [SerializeField] private GameObject turnManager;

    
    public void CheckWinner()
    {
        string[,] board = new string[3, 3]
        {
            {TopLeft.text,      TopMid.text,       TopRight.text},
            {MidLeft.text,      MidMid.text,       MidRight.text},
            {BottomLeft.text,  BottomMid.text,  BottomRight.text}
        };

        if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] && board[0, 0] != "")
        {
            thereIsWinner = true;
        }
        else if (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2] && board[1, 0] != "")
        {
            thereIsWinner = true;
        }
        else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] && board[2, 0] != "")
        {
            thereIsWinner = true;
        }
        else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0] && board[0, 0] != "")
        {
            thereIsWinner = true;
        }
        else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1] && board[0, 1] != "")
        {
            thereIsWinner = true;
        }
        else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2] && board[0, 2] != "")
        {
            thereIsWinner = true;
        }
        else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != "")
        {
            thereIsWinner = true;
        }
        else if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2] != "")
        {
            thereIsWinner = true;
        }
        else { thereIsWinner = false; }

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
