using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoardTracker : MonoBehaviour
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
    private string[,] board;

    public string[,] TrackBoard()
    {
        string[,] board = new string[3, 3]
        {
            {TopLeft.text,      TopMid.text,       TopRight.text},
            {MidLeft.text,      MidMid.text,       MidRight.text},
            {BottomLeft.text,  BottomMid.text,  BottomRight.text}
        };

        return board;
    }
}