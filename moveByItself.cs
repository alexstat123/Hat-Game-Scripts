using UnityEngine;
using System.Collections;

public class moveByItself : MonoBehaviour {
	
	public float Velocity=10;
	public float direction = 1;
	int i = 0;
	int j = 0;
	public int acceleration1 =10;
	public int stopacceleration1 = 500;
	public int startacceleration2=510;
	public int stopacceleration2 = 850;
	public int startacceleration3 = 860;
	float randomNumberInRange=0;
	public int speed =60;

	void start(){


	}
	
	// Update is called once per frame
	void Update () {
		
		i++;     // increment "i" integer by 1, this is like timer
		j++;



		speed = PlayerPrefs.GetInt ("speedOfObjects");
	
		accelerationFunction ();  // accelerate object





	}

	void accelerationFunction(){

		//this.GetComponent<Rigidbody>().AddForce(0,0, 5, ForceMode.Impulse);

		if(i<acceleration1){   // accelerate object until i reaches some value, apply for to object in this time 
			
			this.GetComponent<Rigidbody>().AddForce(new Vector3(speed*direction,0,0));
			
			
		}

	}


}