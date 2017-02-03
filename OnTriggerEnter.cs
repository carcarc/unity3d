//Collider 2D "Is Trigger" clicked
bool playerInRange;
GameObject player = GameObject.FindGameObjectWithTag ("Player");

void OnTriggerEnter (Collider other){
    // If the entering collider is the player...
    if(other.gameObject == player)
    {
        // ... the player is in range.
        playerInRange = true;
    }
}

void OnTriggerExit (Collider other){
    // If the exiting collider is the player...
    if(other.gameObject == player)
    {
        // ... the player is no longer in range.
        playerInRange = false;
    }
}
