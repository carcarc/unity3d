bool playerInRange;
GameObject player = GameObject.FindGameObjectWithTag ("Player");

void OnTriggerEnter (Collider other)
{
    // If the entering collider is the player...
    if(other.gameObject == player)
    {
        // ... the player is in range.
        playerInRange = true;
    }
}
