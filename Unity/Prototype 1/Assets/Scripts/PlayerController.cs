using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets input from horizontal axis
        horizontalInput = Input.GetAxis("Horizontal");
        //gets input from vertical axis
        forwardInput = Input.GetAxis("Vertical");

        //Moves object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turns Object
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
