using UnityEngine;
using System.Collections;

public class TurnLabelOn : MonoBehaviour {

	int getscore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
		Debug.Log (getscore);
	}
}
