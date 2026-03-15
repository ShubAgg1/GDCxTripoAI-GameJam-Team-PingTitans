using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class PlayerMovement: MonoBehaviour
{
    public float speed;
    private void Start()
    {
        speed = 10;
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        
    }
}

