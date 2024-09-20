using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeTurnText : MonoBehaviour
{

    [SerializeField] private TMP_Text turnText;
    [SerializeField] private GameObject turnManager;



    public void NewTurnText()
    {
        ManageTurns turns = turnManager.GetComponent<ManageTurns>();
        turns.CheckWhoseTurn();
        PlayerClass player = turns.turnTaker;

        turnText.text = player.Name + "'s turn";
       

    }
}
