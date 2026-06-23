using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float FireDelay = 10f; // Delay between dog spawns

    // Update is called once per frame
    void Update()
    {
        // Decrease the fire delay over time
        FireDelay -= 0.1f;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && FireDelay <= 0.0f) // Check if the fire delay has elapsed
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            FireDelay = 10f; // Reset the fire delay after spawning a dog
        }
    }
}
