using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public GameObject tile;
    public int arrayWidth = 5;
    public int arrayHeight = 6;
    public GameObject[,] tileArray;
    int i, j, k;

    TileScript tileScriptTest = null;

    void Start()
    {
        tileScriptTest = GameObject.Find("TilePrefab").GetComponent<TileScript>();
        Vector3 TilePos = new Vector3(transform.position.x, 5, transform.position.z);
        //tileArray[5] = Instantiate(tile, TilePos, transform.rotation);
        tileArray = new GameObject[arrayWidth,arrayHeight];
        for(i = 0, k = 0; i < arrayHeight; i++)
        {
            for (j = 0; i < arrayWidth; j++, k++)
            {
                //tileScriptTest.GetComponent<TileScript>(TileSpawn);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
