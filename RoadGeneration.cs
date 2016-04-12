public class RoadGeneration : MonoBehaviour {
 public GameObject Water; //link to the 3d object
 public GameObject Road;
 public GameObject Grass;

 int firstRand;
 int secondRand;
 int distPlayer = 12; //the starting position to add the ground
 
 Vector3 intPos = new Vector3(0,0,0);
 
 void Update () {
  if (Input.GetButtonDown ("up")){
   
   //Random Grass, Road or Water
   firstRand = Random.Range(1,4);

   if(firstRand == 1){
    //Duplicate this type ground Randomly
    secondRand = Random.Range (1,8);
    for(int i = 0;i < secondRand;i++){
     intPos = new Vector3(0,0,distPlayer);
     distPlayer +=1;
     GameObject GrassIns = Instantiate (Grass) as GameObject;
     GrassIns.transform.position = intPos;
    }
   }
   if(firstRand == 2){
    secondRand = Random.Range (1,8);
    for(int i= 0;i < secondRand;i++){
     intPos = new Vector3(0,0,distPlayer);
     distPlayer +=1;
     GameObject RoadIns = Instantiate (Road) as GameObject;
     RoadIns.transform.position = intPos;
    }
   }
   if(firstRand == 3){
     secondRand = Random.Range (1,8);
     for(int i= 0;i < secondRand;i++){
      intPos = new Vector3(0,0,distPlayer);
      distPlayer +=1;
      GameObject WaterIns = Instantiate (Water) as GameObject;
      WaterIns.transform.position = intPos;
     }
   }
  }
 }
}
