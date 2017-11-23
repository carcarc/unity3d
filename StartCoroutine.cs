void Start () {
	Debug.Log("start1");
	StartCoroutine(Test());
	Debug.Log("start2");
}

IEnumerator Test(){
	Debug.Log("test1");
	yield return null;
	Debug.Log("test2");
}

//Result
start1
test1
start2
test2
