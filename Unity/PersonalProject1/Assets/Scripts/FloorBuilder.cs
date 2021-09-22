using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBuilder : MonoBehaviour
{
    public GameObject ghostTile;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
    if (!Physics.CheckSphere(new Vector3(transform.position.x + 3.5f, transform.position.y, transform.position.z), 1))
        Instantiate(ghostTile, new Vector3(transform.position.x + 3.5f, transform.position.y, transform.position.z), transform.rotation);
    if (!Physics.CheckSphere(new Vector3(transform.position.x - 3.5f, transform.position.y, transform.position.z), 1))
        Instantiate(ghostTile, new Vector3(transform.position.x - 3.5f, transform.position.y, transform.position.z), transform.rotation);
    if (!Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y, transform.position.z + 3.5f), 1))
        Instantiate(ghostTile, new Vector3(transform.position.x, transform.position.y, transform.position.z + 3.5f), transform.rotation);
    if (!Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y, transform.position.z - 3.5f), 1))
            Instantiate(ghostTile, new Vector3(transform.position.x, transform.position.y, transform.position.z - 3.5f), transform.rotation);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
    }
}
