using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageTurns : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    public PlayerClass turnTaker;
    private int turnNumber = 1;

 

    public void CheckWhoseTurn()
    {
        
        if (turnNumber % 2 == 0)
        {
            turnTaker = player2.GetComponent<PlayerClass>();
        }
        else { turnTaker = player1.GetComponent<PlayerClass>(); }
    }

    public void EndTurn()
    {
        turnNumber++;
    }

}
