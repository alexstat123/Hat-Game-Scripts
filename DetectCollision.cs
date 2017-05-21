using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {

	public bool destory; 
	public string DetectCollisionWith = "floor";


	
	// Use this for initialization
	void Start () {
		
		//playagainbutton = GameObject.FindWithTag("canvas1");
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag(DetectCollisionWith))
		{
			
			//Debug.Log(DetectCollisionWith);
			Destroy(this.gameObject);
			
		}
	}
	

}


