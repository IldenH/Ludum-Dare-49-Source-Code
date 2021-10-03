using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopArea : MonoBehaviour
{
    public static bool isShop = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isShop = true;
            return;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isShop = false;
            return;
        }
    }
}
