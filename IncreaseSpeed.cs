using UnityEngine;
using System.Collections;

public class IncreaseSpeed : MonoBehaviour {

	public int WhenToSpeedUp=500;
	public int WhenToSpeedUp2 =800;
	public int speedOfBuckets = 60;
	int timeCounter=0;
	// Use this for initialization
	void Start () {
	
		PlayerPrefs.SetInt ("speedOfObjects", speedOfBuckets);
	}
	
	// Update is called once per frame
	void Update () {
	
		timeCounter++;

		if(timeCounter>WhenToSpeedUp){

			speedOfBuckets=70;
		}

		if(timeCounter>WhenToSpeedUp2){
			
			speedOfBuckets=75;
		}

		PlayerPrefs.SetInt ("speedOfObjects", speedOfBuckets);
	}
}
