using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int upperBound = 24;
    public int lowerBound = -14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound)
            Destroy(gameObject);
        if (transform.position.z < lowerBound)
            Debug.Log("GAME OVER");
    }
}
