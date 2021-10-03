using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteManager : MonoBehaviour
{
    public static float meteorites = 0;
    public float meteoriteFallSpeed = 1;
    public static float metFallSpd;
    public GameObject[] meteoriteObjects;

    // Start is called before the first frame update
    void Start()
    {
        metFallSpd = meteoriteFallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        meteorites = Mathf.RoundToInt(Timer.timerNumber / 60);

        if (meteorites == 0)
        {
            meteoriteObjects[0].SetActive(false);
            meteoriteObjects[1].SetActive(false);
            meteoriteObjects[2].SetActive(false);
            meteoriteObjects[3].SetActive(false);
        }
        else if (meteorites == 1)
        {
            meteoriteObjects[0].SetActive(true);
        }
        else if (meteorites == 2)
        {
            meteoriteObjects[0].SetActive(true);
            meteoriteObjects[1].SetActive(true);
        }
        else if (meteorites == 3)
        {
            meteoriteObjects[0].SetActive(true);
            meteoriteObjects[1].SetActive(true);
            meteoriteObjects[2].SetActive(true);
        }
        else if (meteorites == 4)
        {
            meteoriteObjects[0].SetActive(true);
            meteoriteObjects[1].SetActive(true);
            meteoriteObjects[2].SetActive(true);
            meteoriteObjects[3].SetActive(true);
        }
    }
}
