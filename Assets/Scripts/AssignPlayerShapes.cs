using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AssignPlayerShapes : MonoBehaviour
{
    [SerializeField] private PlayerClass player1;
    [SerializeField] private PlayerClass player2;
    [SerializeField] private TMP_Text buttonText;
    [SerializeField] private GameObject selectScreen;
    [SerializeField] private GameObject turnScreen;
  


    public void AssignShapes()
    {
        player1.Shape = buttonText.text;
        switch (buttonText.text) 
        {
            case "X":
                player2.Shape = "O";
                break;
            case "O":
                player2.Shape = "X";
                break;
        }

        selectScreen.SetActive(false);
        turnScreen.SetActive(true);
    }
  
}
