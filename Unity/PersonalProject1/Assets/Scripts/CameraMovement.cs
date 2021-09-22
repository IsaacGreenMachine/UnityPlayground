using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera mainCamera;
    public int camSpeed = 10;
    public int camZoomSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * camSpeed);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.up * Time.deltaTime * camSpeed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * Time.deltaTime * camSpeed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * camSpeed);
        if (Input.GetKey(KeyCode.E))
            mainCamera.orthographicSize += camZoomSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Q))
            mainCamera.orthographicSize -= camZoomSpeed * Time.deltaTime;

    }
}
