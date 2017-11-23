enum GameStatus
{
  Menu,
  Loading,
  Playing,
  Pause,
  GameOver
}

GameStatus xxx = GameStatus.Menu;
 
// 轉換為 int, 其值為 0
int i = (int)xxx;
// 轉換為 string, 其值為 "Menu"
string s = xxx.ToString();
