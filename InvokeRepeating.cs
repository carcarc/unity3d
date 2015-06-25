public float spawnTime = 3f;

// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
InvokeRepeating ("Method", spawnTime, spawnTime);

void Method ()
{
  //any method
}

