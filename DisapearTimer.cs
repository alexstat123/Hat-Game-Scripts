using UnityEngine;
using System.Collections;

public class DisapearTimer : MonoBehaviour {

	int i=0;
	public int dissapearanceTime=100;
	public GameObject plusoneobject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		dissapearFunction ();


	}

	public void dissapearFunction(){

		i++;
		
		if(i>dissapearanceTime){plusoneobject.SetActive (false);}
	}
}
