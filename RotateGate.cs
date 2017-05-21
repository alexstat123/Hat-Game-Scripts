using UnityEngine;
using System.Collections;

public class RotateGate : MonoBehaviour {

	public int buttonUpRotate = 80;
	public int buttonDownRotate = -80;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//roatetTetriminoWithAClick ();
	
	}

	public void roatetTetriminoWithAClick(){
		
		if (Input.GetMouseButtonUp (0)) {

			transform.Rotate(0,0,buttonUpRotate);
				
				
		}

		if (Input.GetMouseButtonDown (0)) {
			
			transform.Rotate(0,0,buttonDownRotate);
			
			
		}
		
		
	}

	void OnMouseDown(){

		transform.Rotate(0,0,buttonDownRotate);

	}

	void OnMouseUp(){
		
		transform.Rotate(0,0,buttonUpRotate);
		
	}
}
