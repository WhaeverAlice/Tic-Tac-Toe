using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToPVPScene()
    {
        SceneManager.LoadScene("PvPGameBoard");
    }

    public void GoToPvEScenceE()
    {
        SceneManager.LoadScene("PvEGameBoard-Easy");
    }
}
