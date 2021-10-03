using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool isGameOver = false;
    public GameObject sphere;
    public GameObject gameOverText;

    void Update()
    {
        if (isGameOver)
        {
            gameOverText.SetActive(true);
            sphere.SetActive(true);
            sphere.transform.localScale += Vector3.one * Time.deltaTime * 2;
        }
    }
}
