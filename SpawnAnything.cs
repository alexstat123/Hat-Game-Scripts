using UnityEngine;
using System.Collections;

public class SpawnAnything : MonoBehaviour {
	



	int i=0;
	int randomInt;
	public int spawnRate=0;

	public float yCoordinates = 20.0F;
	public float xCoordinates1 = 16.0F;
	public float xCoordinates2 = 15.0F;

	public GameObject gameObject4 = null;
	public GameObject SpawnObject;
	public GameObject SpawnObject1;
	public GameObject SpawnObject2;
	public GameObject SpawnObject3;
	public GameObject SpawnObject4;
	public GameObject SpawnObject5;
	public GameObject fedora;
	public GameObject fez;
	public GameObject bowler;


	// Use this for initialization
	void Start () {
		
		
		spawnfunction ();
		

	}

	
	// Update is called once per frame
	void Update () {
		
		i++;

		if(i%spawnRate==0){

			RandomNumberGenerator ();

		}

	}

	void spawnfunction(){


		float y1 = (Random.Range(yCoordinates, yCoordinates)+Random.Range(0.0F, 0.0F));
		
		Vector3 position = new Vector3(Random.Range(xCoordinates2, xCoordinates1), y1, 0);
		gameObject4 = Instantiate(SpawnObject,position, Quaternion.identity) as GameObject;

	}

	void RandomNumberGenerator(){

		randomInt = (Random.Range(0, 3));  // Generate Random Number from 0 to 3 (not including 3)
	

		switch (randomInt){
			
		case 0:   // if random number is 0, spawn "SpawnObject" which is fedora

			float y1 = (Random.Range(yCoordinates, yCoordinates)+Random.Range(0.0F, 0.0F));
			
			Vector3 position = new Vector3(Random.Range(xCoordinates2, xCoordinates1), y1, 0);
			gameObject4 = Instantiate(SpawnObject,position, Quaternion.identity) as GameObject;
			fedora.SetActive(true);
			fez.SetActive(false);
			bowler.SetActive(false);
			break;
			
		case 1:  // if random number is 1, spawn "SpawnObject1" which is fez

			float y2 = (Random.Range(yCoordinates, yCoordinates)+Random.Range(0.0F, 0.0F));
			
			Vector3 position2 = new Vector3(Random.Range(xCoordinates2, xCoordinates1), y2, 0);
			gameObject4 = Instantiate(SpawnObject1,position2, Quaternion.identity) as GameObject;
			fedora.SetActive(false);
			fez.SetActive(true);
			bowler.SetActive(false);
			break;
			
		case 2:  // if random number is 2, spawn "SpawnObject2" which is bowler hat

			float y3 = (Random.Range(yCoordinates, yCoordinates)+Random.Range(0.0F, 0.0F));
			
			Vector3 position3 = new Vector3(Random.Range(xCoordinates2, xCoordinates1), y3, 0);
			gameObject4 = Instantiate(SpawnObject2,position3, Quaternion.identity) as GameObject;
			fedora.SetActive(false);
			fez.SetActive(false);
			bowler.SetActive(true);
			break;

		case 3:
			
			float y5 = (Random.Range(yCoordinates, yCoordinates)+Random.Range(0.0F, 0.0F));
			
			Vector3 position5 = new Vector3(Random.Range(xCoordinates2+12, xCoordinates1+12), y5-9.5f, 0);
			gameObject4 = Instantiate(SpawnObject4,position5, Quaternion.identity) as GameObject;
			
			break;

		case 4:
			
			float y6 = (Random.Range(yCoordinates, yCoordinates)+Random.Range(0.0F, 0.0F));
			
			Vector3 position6 = new Vector3(Random.Range(xCoordinates2+12, xCoordinates1+12), y6-9.65f, 0);
			gameObject4 = Instantiate(SpawnObject5,position6, Quaternion.identity) as GameObject;
			
			break;
		}


	}

}


