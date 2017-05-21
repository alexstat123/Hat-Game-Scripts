using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

	public GameObject gameovermenu;
	bool x = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//if (gameovermenu.SetActive (true)) {

			//x = false;
		//}
	}

	public void startTimer(){

		Time.timeScale = 1;
	}
}
