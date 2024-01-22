using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed
    public float turnSpeed = 150f; // Turning speed

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Check if player is moving forward or backward
        if (Mathf.Abs(verticalInput) > 0.1f)
        {
            // Calculate movement direction
            Vector3 moveDirection = new Vector3(0f, 0f, verticalInput).normalized;

            // Move player in the direction it's facing
            transform.Translate(moveDirection * speed * Time.deltaTime, Space.Self);
        }

        // Rotate player based on horizontal input
        float rotationAmount = horizontalInput * turnSpeed * Time.deltaTime;
        Vector3 rotationVector = new Vector3(0f, rotationAmount, 0f);

        // Rotate player
        transform.Rotate(rotationVector);
    }
}
