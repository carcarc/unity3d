//Save
PlayerPrefs.SetInt ("儲存名稱I", 整數變數);
PlayerPrefs.SetFloat ("儲存名稱F", 浮點數變數);
PlayerPrefs.SetString ("儲存名稱S", 字串變數);

//Get
整數變數 = PlayerPrefs.GetInt ("儲存名稱I");
浮點數變數 = PlayerPrefs.GetFloat ("儲存名稱F");
字串變數 = PlayerPrefs.GetString ("儲存名稱S");

//Delete
PlayerPrefs.DeleteAll();
PlayerPrefs.DeleteKey("儲存名稱I");
