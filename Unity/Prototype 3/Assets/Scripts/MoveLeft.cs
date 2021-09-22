using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public int speed = 20;
    public PlayerController playerControllerScript;
    public int leftBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.GameOver == false)
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (gameObject.CompareTag("Obstacle") && transform.position.x < leftBound)
            Destroy(gameObject);
    }
}
