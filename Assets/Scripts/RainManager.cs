using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainManager : MonoBehaviour
{
    public static bool isRaining = false;
    public GameObject rain;

    void Start()
    {
        InvokeRepeating("StartRain", 50, 50);
    }

    void Update()
    {
        if (isRaining)
        {
            rain.SetActive(true);
        }
        else
        {
            rain.SetActive(false);
        }
    }

    void StartRain()
    {
        isRaining = true;
        Invoke("EndRain", 10);
    }

    void EndRain()
    {
        isRaining = false;
    }
}
