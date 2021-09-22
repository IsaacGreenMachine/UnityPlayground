using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool playerCooldown = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && playerCooldown == false)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            playerCooldown = true;
            Invoke("coolDownSwitch", 1);
        }
    }

    void coolDownSwitch()
    {
        playerCooldown = false;
    }
}
