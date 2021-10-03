using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public GameObject rocks;
    public GameObject cube;

    void Start()
    {
        rocks.SetActive(false);
        cube.SetActive(false);
        transform.position = new Vector3(transform.position.x, 1000, transform.position.z);
    }

    void Update()
    {
        if (!(transform.position.y <= 5))
        {
            transform.Translate(Vector3.down * Time.deltaTime * MeteoriteManager.metFallSpd);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
            rocks.SetActive(true);
            cube.SetActive(true);
        }
    }
}
