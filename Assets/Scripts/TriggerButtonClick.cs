using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
//using UnityEngine.UI;

public class TriggerButtonClick : MonoBehaviour
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
    [SerializeField] TMP_Text turnText;
    [SerializeField] Button TopLeftB;
    [SerializeField] Button TopMidB;
    [SerializeField] Button TopRightB;
    [SerializeField] Button MidMidB;
    [SerializeField] Button MidLeftB;
    [SerializeField] Button MidRightB;
    [SerializeField] Button BottomLeftB;
    [SerializeField] Button BottomMidB;
    [SerializeField] Button BottomRightB;
    [SerializeField] Button turnTextB;
    private List<TMP_Text> buttons;
    private List<Button> buttonList;
    [SerializeField] private GameObject turnManager;
    [SerializeField] private GameObject boardController;

    //void Update()
    //{
    //    bool isThereWinner = boardController.GetComponent<CheckWinCondition>();
    //}
    public void ExcuteComputerTurn()
    {
        CheckWinCondition winCondition = boardController.GetComponent<CheckWinCondition>();
        bool thereIsAWinner = winCondition.thereIsWinner;
        if (!thereIsAWinner)
        { StartCoroutine(ComputerTurn()); }
        
    }


    //public IEnumerator SimulateButtonPress()
    //{
    //    yield return new WaitForSeconds(0.5f);
        
    //    bool isThereWinner = boardController.GetComponent<CheckWinCondition>();
    //    if (!isThereWinner)
    //    {
    //        List<Button> unpressedButtons = new List<Button>();
    //        buttonList = new List<Button>()
    //      {
    //      TopLeftB,
    //      TopMidB,
    //      TopRightB,
    //      MidMidB,
    //      MidLeftB,
    //      MidRightB,
    //      BottomLeftB,
    //      BottomMidB,
    //      BottomRightB,
    //      };

            

    //        foreach (Button button in buttonList)
    //        {
    //            TMP_Text buttonText = GetComponent<TMP_Text>();
    //            if (buttonText.text == "") unpressedButtons.Add(button);
    //        }

    //        Button pressThis = unpressedButtons[Random.Range(0, unpressedButtons.Count)];
    //        pressThis.Invoke();
    //    }
    //}


    public IEnumerator ComputerTurn()
    {
        yield return new WaitForSeconds(0.5f);
        
        buttons = new List<TMP_Text>()
       {
        TopLeft,
        TopMid,
        TopRight,
        MidMid,
        MidLeft,
        MidRight,
        BottomLeft,
        BottomMid,
        BottomRight,
       };

        List<TMP_Text> availableButtons = new List<TMP_Text>();

        foreach (TMP_Text button in buttons) 
        {
           if (button.text == "") availableButtons.Add(button);
        }

        ManageTurns turns = turnManager.GetComponent<ManageTurns>();
        turns.CheckWhoseTurn();
        PlayerClass player = turns.turnTaker;
        availableButtons[Random.Range(0, availableButtons.Count)].text = player.Shape;
        turns.EndTurn();
        turns.CheckWhoseTurn();
        player = turns.turnTaker;
        turnText.text = player.Name + "'s turn";

        CheckWinCondition winCondition = boardController.GetComponent<CheckWinCondition>();
        winCondition.CheckWinner();

    }
}
