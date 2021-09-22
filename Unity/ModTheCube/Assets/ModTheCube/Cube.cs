using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public int i;
    public float rotAng = 0;
    void Start()
    {
        i = Random.Range(0, 3);
        Material material = Renderer.material;
        if (i == 0)
        transform.position = new Vector3(3, 4, 1);
        if (i == 1)
        transform.localScale = Vector3.one * Random.Range(0.1f, 20f);
        if (i == 2)
        material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        if (i == 3)
        rotAng = Random.Range(10f, 100f);
    }
    
    void Update()
    {
        transform.Rotate(rotAng * Time.deltaTime, 0.0f, 0.0f);
    }
}
