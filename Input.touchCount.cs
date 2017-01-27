//http://docs.unity3d.com/460/Documentation/ScriptReference/Input-touchCount.html
//multi-touch
public class click : MonoBehaviour {
  public Texture2D img;
  
    void OnGUI () {
      //记录当前触控点数目
      int count = Input.touchCount;
      
      //单点触控,首个触控点的标志是0
      if (count == 1) {
        float x = Input.GetTouch(0).position.x;
        float y = Input.GetTouch(0).position.y;
      
        GUI.DrawTexture(new Rect(x,y,100,100),img);
      }
  
    //多点触控,遍历每个触摸点
    for (int i = 0 ; i < count ; i++){
      float x = Input.GetTouch(i).position.x;
      float y = Input.GetTouch(i).position.y;
      GUI.DrawTexture(new Rect(x,y,100,100),img);
    }
  }
}
