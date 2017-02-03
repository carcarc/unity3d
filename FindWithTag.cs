private AnyClass anyGameClass;

void Start(){
  //FindWithTag
  GameObject gameControllerObject = GameObject.FindWithTag("GameController");
  if (gameControllerObject != null)
  {
      gameGenerate = gameControllerObject.GetComponent<AnyClass>();
  }
  if (gameGenerate == null)
  {
      Debug.Log("Cannot find 'GameController' script");
  }
}
