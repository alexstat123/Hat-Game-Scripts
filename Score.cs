using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//int score =0;
	int getscore;
	public Text scoreText;
	public Text gameoverscore;
	int gameoverint;
	public GameObject gameoverlabel;
	public Text button;
	// Use this for initialization
	void Start () {
	
		int score = 0;
		//PlayerPrefs.GetInt ("CorrectHatInBasket");
		PlayerPrefs.SetInt ("CorrectHatInBasket",score);
	}
	
	// Update is called once per frame
	void Update () {


		getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
		//Debug.Log (getscore);

		scoreText.text = "SCORE:  £" + getscore;
		gameoverscore.text = "Your Score is:  £" + getscore;



		gameoverint = PlayerPrefs.GetInt ("GameOver");
		//Debug.Log (gameoverint);

		//if(gameoverint ==1){gameoverlabel.SetActive(true);}


		button.text ="Your Score is £"+ getscore;
	}
}
