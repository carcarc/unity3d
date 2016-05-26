/*Duplicate an object*/
public GameObject object;                // The enemy prefab to be spawned.
public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.

Instantiate (object, spawnPoints[0].position, spawnPoints[0].rotation);
