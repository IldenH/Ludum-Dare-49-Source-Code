using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text text;
    public static float timerNumber = 0;

    void Start()
    {
        text = GetComponent<Text>();
        InvokeRepeating("IncreaseTimer", 1, 1);
        InvokeRepeating("IncreaseOrDecreaseHeat", 5, 5);
    }

    void IncreaseTimer()
    { 
        timerNumber++;
        text.text = "" + timerNumber + " Seconds";
    }

    void IncreaseOrDecreaseHeat()
    {
        if (RainManager.isRaining)
        {
            Reactor.heat -= 3;
        }
        else
        {
            Reactor.heat += (MeteoriteManager.meteorites + 1 ) * 2;
        }
    }
}
