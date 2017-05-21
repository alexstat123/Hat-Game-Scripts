using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {
	
	public GameObject gameObject = null;
	public GameObject gameObject3 = null;
	public GameObject gameObject4 = null;
	public GameObject gameObject5 = null;
	public GameObject gameObject6 = null;
	int i=0;
	public int rezRate=0;
	public int fedoraRate=0;
	public int bowlerRate=0;

	// Use this for initialization
	void Start () {
		
		
		

		
		
	}
	
	// Update is called once per frame
	void Update () {
		i++;
		
		//if (Input.GetKeyDown (KeyCode.AltGr )){
			
			//Vector3 position3 =  new Vector3(0, -70, 0);
			//gameObject6 =Instantiate(Resources.Load("Prefabs/TriangleGameObject"),position3, Quaternion.identity) as GameObject;
			
			
		//}

		//for(int i =0; i<50;i++){
		if(i%rezRate==0){

			float y1 = (Random.Range(19.0F, 20.0F)+Random.Range(0.0F, 0.0F));
			
			Vector3 position = new Vector3(Random.Range(9.0F, 10.0F), y1, 0);
			gameObject4 = Instantiate(Resources.Load("Prefabs/fez"),position, Quaternion.identity) as GameObject;

			//float y2 = (Random.Range(10.0F, 15.0F)+Random.Range(0.0F, 0.0F));
			
			//Vector3 position2 = new Vector3(Random.Range(-5.0F, 14.0F), y1, 0);
			//gameObject4 = Instantiate(Resources.Load("Prefabs/RedHat"),position2, Quaternion.identity) as GameObject;


		}
			
		if(i%fedoraRate==0){
			
			float y2 = (Random.Range(15.0F, 20.0F)+Random.Range(0.0F, 0.0F));
			
			Vector3 position2 = new Vector3(Random.Range(19.0F, 20.0F), y2, 0);
			gameObject4 = Instantiate(Resources.Load("Prefabs/RedHat"),position2, Quaternion.identity) as GameObject;
			
			
		}	

		if(i%bowlerRate==0){
			
			float y2 = (Random.Range(20.0F, 20.0F)+Random.Range(0.0F, 0.0F));
			
			Vector3 position2 = new Vector3(Random.Range(-1.0F, 0.0F), y2, 0);
			gameObject4 = Instantiate(Resources.Load("Prefabs/Bowler"),position2, Quaternion.identity) as GameObject;
			
			
		}	
			
		
	}
}

