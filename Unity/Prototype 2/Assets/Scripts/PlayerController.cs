using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public int speed = 15;
    public int Range = 10;
    public int verticalRange = 5;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -10, 0);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Horizontal Movement
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x > Range)
        {
            transform.position = new Vector3(Range, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -Range)
        {
            transform.position = new Vector3(-Range, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= -Range && transform.position.x <= Range)
            transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        //Vertical Movement
        verticalInput = Input.GetAxis("Vertical");
        if (transform.position.z > verticalRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, verticalRange);
        }
        if (transform.position.z < -verticalRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -verticalRange);
        }

        if (transform.position.z >= -verticalRange && transform.position.z <= verticalRange)
            transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

        //Spawn Bones
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }

    public void increaseScore()
    {
    }
}
