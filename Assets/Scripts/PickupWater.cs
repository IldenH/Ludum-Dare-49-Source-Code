using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupWater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.CompareTag("Water"))
                {
                    Stats.waterAmount++;
                }
            }
        }
    }
}
