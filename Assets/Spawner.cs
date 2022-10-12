using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Create a public array of objects to spawn, we will fill this up using the unity editor
    public GameObject[] objectsToSpawn;

    float timeToNextSpawn; //Tracks how long we should wait beofre spawning a new object
    float timeSinceLastSpawn = 0.0f; //Tracks the time since we last spawned something 

    public float minSpawnTime = 0.5f; //Minimum amount of time between spawninig objects
    public float maxSpawnTime = 3.0f; //Maximum 

    // Start is called before the first frame update
    void Start()
    {
        //Random.range returns a random float bewteen two values
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Add time.deltatime returns the amount of time passed since the last frame.
        //This will create a float that counts up in seconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //if weve counted past the amount of time we need to wait
        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            //use random.range to pick a number between 0 and the amount of items we have on our object list
            int selection = Random.Range(0, objectsToSpawn.Length);

            //Instantiate spawns a gameobject - in this case we tell it to spawn a gameobject from our objectstospawn list
            //the second parameter in the brackets tells it where to spawn, so weve entered the posisiton of the spwaner
            //the third parameter is for rotation, and Quater.identity means no rotation
            Instantiate(objectsToSpawn[selection], transform.position, Quaternion.identity);

            //after spawning , we select a new random time for the next spawn and set our timer back to zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;

        }

    }
}
