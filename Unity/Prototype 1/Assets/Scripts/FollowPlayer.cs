using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 5, -7);
    private Vector3 offset2 = new Vector3(0, 3, 1);
    public int cameraView = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            cameraView++;
        }
        if (cameraView % 2 == 0)
        {
        transform.position = (player.transform.position + offset1);
        }
        else
        {
        transform.position = (player.transform.position + offset2);
        }
    }
}
