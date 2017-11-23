RayCastHit hit;  //儲存物件

Ray myRay = new Ray(transform.position,Vector3.down); //射線方向

//射線由myRay射出長度為DownHeight 碰到的物件為hit
if(Physics.Raycast (myRay, out hit ,DownHeight) ){ 
  //hit
}
