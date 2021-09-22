using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 25;
    public int forwardInput;
    public int horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //gets input from horizontal axis
        if (Input.GetKey(KeyCode.LeftArrow))
            horizontalInput = -1;
        if (Input.GetKey(KeyCode.RightArrow))
            horizontalInput = 1;
        if (!(Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKeyDown(KeyCode.LeftArrow)))
            horizontalInput = 0;
        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
            horizontalInput = 0;
        if (Input.GetKey(KeyCode.DownArrow))
            forwardInput = -1;
        if (Input.GetKey(KeyCode.UpArrow))
            forwardInput = 1;
        if (!(Input.GetKeyDown(KeyCode.DownArrow)) && !(Input.GetKeyDown(KeyCode.UpArrow)))
            forwardInput = 0;
        //Moves object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turns Object
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
