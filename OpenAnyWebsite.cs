using UnityEngine;
using System.Collections;

public class OpenAnyWebsite : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void openUrl(){

		Application.OpenURL ("http://www.hatsandcaps.co.uk");
	}
}
