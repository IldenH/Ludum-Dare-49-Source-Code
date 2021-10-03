using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reactor : MonoBehaviour
{
    public GameObject player;
    public static float heat = 10;
    public GameObject pressEText;

    void Update()
    {
        if (DroppoffWaterArea.canDroppoffWater)
        {
            pressEText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (Stats.waterAmount > 0)
                {
                    Stats.waterAmount--;
                    heat--;
                }
            }
        }
        else
        {
            pressEText.SetActive(false);
        }


    }
}
