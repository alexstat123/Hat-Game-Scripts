using UnityEngine;
using UnityEngine;
using System.Collections;

public class RotateItem : MonoBehaviour {
	
	int counter = 0;
	int rotationSpeed = -3;
	float roatation;
	public float condition1 = 100f;
	public float roatationSpeed=2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//counter++;
		//Debug.Log (counter);
		
		//if(counter<condition1)
		//{
			
			transform.Rotate (0,0,-roatationSpeed);
		//}
		
		
		//if(counter>condition1)
		//{
			//transform.Rotate (0,0,roatationSpeed);
			
			
		//}
		
		//if(counter>((condition1*2)-2))
		//{
			//counter=0;
			
			
		//}
	}
}

