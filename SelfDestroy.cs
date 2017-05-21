using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour {

	//int counter =0;
	public float destroyXloaction = 5.0F;
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
		//counter++;
		//Debug.Log (transform.position.y);

		if(transform.position.x<destroyXloaction){

			Destroy(this.gameObject);
		}

	}
}
