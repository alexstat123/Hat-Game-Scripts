using UnityEngine;
using System.Collections;

public class GateController : MonoBehaviour {

	public GameObject leftgate;
	public GameObject rightgate;

	// Use this for initialization 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseDown(){

		leftgate.transform.Rotate (0,0,-80);
		rightgate.transform.Rotate (0,0,80);
		//transform.Rotate(0,0,buttonDownRotate);
		
	}

	public void OnMouseUp(){

		leftgate.transform.Rotate (0,0,80);
		rightgate.transform.Rotate (0,0,-80);
		//transform.Rotate(0,0,buttonUpRotate);
		
	}
}
