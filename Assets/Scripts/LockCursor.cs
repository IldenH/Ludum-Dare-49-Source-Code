using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{
    void Update()
    {
        if (ShopArea.isShop)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        { 
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
