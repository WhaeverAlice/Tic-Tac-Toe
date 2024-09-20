using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private GameObject turnManager;
    
  

    public void NewText()
    {
        ManageTurns turns = turnManager.GetComponent<ManageTurns>();
        turns.CheckWhoseTurn();
        PlayerClass player = turns.turnTaker;
        
        buttonText.text = player.Shape;
        turns.EndTurn();

    }
}
