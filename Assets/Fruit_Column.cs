using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit_Column : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array of gameobjects to spawn
    public float spawnTime = 3f; // Time between each spawn
    public float objectLifetime = 5f; // Time before object disappears
    public float delayTime = 2f; // Delay time between spawns

    private GameObject currentObject; // The current spawned object
    private float spawnTimer = 0f; // Timer for spawning
    private float objectTimer = 0f; // Timer for current object
    private bool waitingForDelay = false; // Flag to indicate if waiting for delay

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomObject(); // Spawn the first object
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime; // Increment spawn timer
        objectTimer += Time.deltaTime; // Increment object timer

        if (objectTimer >= objectLifetime) // If current object has been active for too long
        {
            Destroy(currentObject); // Destroy the current object
            waitingForDelay = true; // Set flag to indicate waiting for delay
            objectTimer = 0f; // Reset object timer
        }

        if (waitingForDelay) // If waiting for delay
        {
            if (objectTimer >= delayTime) // If delay time has passed
            {
                waitingForDelay = false; // Reset flag
                SpawnRandomObject(); // Spawn a new random object
            }
        }
        else if (spawnTimer >= spawnTime) // If it's time to spawn a new object
        {
            SpawnRandomObject(); // Spawn a new random object
        }
    }

    void SpawnRandomObject()
    {
        int randomIndex = Random.Range(0, objectsToSpawn.Length); // Get a random index for the array
        GameObject newObject = Instantiate(objectsToSpawn[randomIndex], transform.position, Quaternion.identity); // Spawn the object at the generator's position

        if (currentObject != null) // If there's a current object
        {
            Destroy(currentObject); // Destroy it
        }

        currentObject = newObject; // Set the new object as the current object
        objectTimer = 0f; // Reset the object timer
        spawnTimer = 0f; // Reset the spawn timer
    }
   
}


