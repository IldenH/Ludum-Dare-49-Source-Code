using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    public static bool isWin;
    public Text text;

    void Update()
    {
        if (isWin)
        {
            text.gameObject.SetActive(true);
            text.text = "You Won with a score of: " + Timer.timerNumber + " seconds.";
            Time.timeScale = 0;
        }
    }
}
