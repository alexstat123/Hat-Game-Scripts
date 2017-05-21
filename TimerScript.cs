using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	public int counter=60;
	public Text label;
	int getscore;
	int labeldisplay;
	public GameObject gameoverlabel;
	public GameObject gameoversocre;
	public GameObject gameOverButton;
	//public Text button;

	int i=0;
	// Use this for initialization
	void Start () {

		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {


		i = i + 1;

		if(i%15==0){

			if ((counter+getscore) >0){

				counter = counter - 1;

			}



		}
		getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
		Debug.Log (getscore);
		labeldisplay = counter + getscore;
		label.text = "Time Left: " + labeldisplay;

		if(labeldisplay<1){
			gameoverlabel.SetActive(true);
			gameoversocre.SetActive(true);
			gameOverButton.SetActive (true);
			Time.timeScale = 0;
		}
	}

	public void startClock(){
		Time.timeScale = 1;
	}
}
