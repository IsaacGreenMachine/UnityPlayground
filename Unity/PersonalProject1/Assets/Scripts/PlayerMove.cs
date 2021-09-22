using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject posObj;
    public int speed = 1;
    public Vector3 goalPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goalPos = new Vector3(posObj.transform.position.x, 5, posObj.transform.position.z);
     transform.position = Vector3.MoveTowards(transform.position, goalPos, speed * Time.deltaTime);

    }
}
