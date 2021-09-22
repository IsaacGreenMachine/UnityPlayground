using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public bool currentlySelected = false;
    //public GameObject posObj;
    public Vector3 moveToPos;
    public GameObject tilePreFab;

    public class Tile
    {
        public GameObject tilePreFab;
        public GameObject tileUp;
        public GameObject tileRight;
        public GameObject tileDown;
        public GameObject tileLeft;
        public float posx;
        public float posz;

        public Tile(float px, float pz)
        {
            posx = px;
            posz = pz;
            tileUp = null;
            tileRight = null;
            tileDown = null;
            tileLeft = null;
        }

        public Tile(GameObject tu, GameObject tr, GameObject td, GameObject tl)
        {
            tileUp = tu;
            tileRight = tr;
            tileDown = td;
            tileLeft = tl;
        }

        public void spawnTile(float posx, float posz, Quaternion rot)
        {
            Vector3 spawnPos = new Vector3(posx, 5, posz);
            Instantiate(tilePreFab, spawnPos, rot);
        }


    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

        moveToPos = new Vector3(transform.position.x , 5, transform.position.z);
      //  posObj.transform.position = moveToPos;
    }
}
