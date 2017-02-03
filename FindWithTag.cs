//use other class's function
private AnyClass anyGameClass;

void Start(){
  //FindWithTag
  GameObject gameControllerObject = GameObject.FindWithTag("GameController");
  if (gameControllerObject != null)
  {
      anyGameClass = gameControllerObject.GetComponent<AnyClass>();
  }
  if (anyGameClass == null)
  {
      Debug.Log("Cannot find 'GameController' script");
  }
}
