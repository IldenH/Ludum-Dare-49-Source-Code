using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 500;
    public float jumpForce = 10;

    private Rigidbody rb;
    private Camera mCam;
    private bool isOnGround = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mCam = Camera.main;
    }

    void Update()
    {
        Jumping();

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddRelativeForce(movement * Time.deltaTime * speed * Uppgrades.speedMultiplier);

        transform.eulerAngles = new Vector3(0, mCam.transform.eulerAngles.y, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOnGround)
            {
                rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }
}
