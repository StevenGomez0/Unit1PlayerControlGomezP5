using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera first;
    public Camera second;
    public KeyCode switchKey;
    public string player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //changes input keys based on which player
        horizontalInput = Input.GetAxis("Horizontal" + player);
        forwardInput = Input.GetAxis("Vertical" + player);

        // Moves the vehicle based on the vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //changes active camera
        if (Input.GetKeyDown(switchKey))
        {
            first.enabled = !first.enabled;
            second.enabled = !second.enabled;
        }
    }
}
