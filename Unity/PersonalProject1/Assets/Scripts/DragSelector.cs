using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragSelector : MonoBehaviour
{
    Vector2 mousePos;
    Vector3 worldPoint;
    public float mouseyX;
    public float mouseyY;
    public int screenWidth = Screen.width;
    public int screenHeight = Screen.height;
    public Resolution screenRez = Screen.currentResolution;
    public int screenRezWidth;
    public int screenRezHeight;  

    public Camera cam;// = Camera.main;
    // Start is called before the first frame update
    void Start()
    {

       screenRezWidth = screenRez.width;
       screenRezHeight = screenRez.height;
}

    // Update is called once per frame
    void Update()
    {
        mouseyX = Input.mousePosition.x;
        mouseyY = Input.mousePosition.y;
    if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("MOUSEDOWN");
            mousePos.x = Input.mousePosition.x;
            mousePos.y = cam.pixelHeight - Input.mousePosition.y;
            worldPoint = cam.ScreenToWorldPoint(new Vector3(mousePos.x, -mousePos.y, cam.nearClipPlane));
            worldPoint.y = worldPoint.y - 20;
            worldPoint.z = worldPoint.z + 10;
            transform.position = worldPoint;
        }
    }
}
