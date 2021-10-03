using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public static float waterAmount;

    public Text[] statObjects;
    public GameObject inventoryFull;

    void Update()
    {
        statObjects[0].text = "" + waterAmount + " / " + Uppgrades.waterStorage;
        statObjects[1].text = "" + Reactor.heat + " / 100";

        if (Reactor.heat >= 100)
        {
            GameOver.isGameOver = true;
        }

        if (Reactor.heat <= 0)
        {
            Win.isWin = true;
        }

        if (waterAmount >= Uppgrades.waterStorage)
        {
            waterAmount = Uppgrades.waterStorage;
            inventoryFull.SetActive(true);
        }
        else
        {
            inventoryFull.SetActive(false);
        }
    }
}
