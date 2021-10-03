using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (!ShopArea.isShop)
        {
            float mouseXInput = 0;
            float mouseYInput = 0;
            mouseXInput += Input.GetAxis("Mouse X");
            mouseYInput -= Input.GetAxis("Mouse Y");

            Mathf.Clamp(mouseXInput, -90, 90);

            Vector3 mouseInput = new Vector3(mouseYInput, mouseXInput, 0);
            transform.eulerAngles += mouseInput;

            Vector3 offset = new Vector3(0, 0.5f, 0);

            transform.position = player.transform.position + offset;
        }
    }
}
