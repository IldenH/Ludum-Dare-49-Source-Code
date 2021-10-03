using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppoffWaterArea : MonoBehaviour
{
    public static bool canDroppoffWater = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canDroppoffWater = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canDroppoffWater = false;
        }
    }
}
