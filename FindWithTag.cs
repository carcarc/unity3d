private Generate gameGenerate;

void Start(){
  //FindWithTag
  GameObject gameControllerObject = GameObject.FindWithTag("GameController");
  if (gameControllerObject != null)
  {
      gameGenerate = gameControllerObject.GetComponent<Generate>();
  }
  if (gameGenerate == null)
  {
      Debug.Log("Cannot find 'GameController' script");
  }
}
