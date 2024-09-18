using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public TMP_Text buttonText;
    //private string newText;
    [SerializeField] private GameObject turnManager;
    //private PlayerClass player;
    //private ManageTurns turns;

    
  

    public void NewText()
    {
        ManageTurns turns = turnManager.GetComponent<ManageTurns>();
        turns.CheckWhoseTurn();
        PlayerClass player = turns.turnTaker;
        
        buttonText.text = player.Shape;
        turns.EndTurn();
    }
}
