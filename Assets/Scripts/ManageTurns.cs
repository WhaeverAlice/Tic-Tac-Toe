using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ManageTurns : MonoBehaviour
{
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    public PlayerClass turnTaker;
    public int turnNumber = 1;
   

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
