using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTile : MonoBehaviour
{
    //public Collider myCollider;
    public GameObject tile;
    // Start is called before the first frame update
    void Start()
    {
        //myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown()
    {
        Instantiate(tile, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
