using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	int counter=0;
	public int speed=2;
	public float xMin, xMax, yMin, yMax;
	
	public GameObject cubePrefabVariable;
	public GameObject cubePrefabVariable2;
	public GameObject spherePrefabVariable;
	public Transform location;
	// Use this for initialization
	void Start () {
		
		Instantiate (cubePrefabVariable);
		//Instantiate (spherePrefabVariable);
		
	}
	
	// Update is called once per frame
	void Update () { 
		
		counter++;
		
		if(counter%speed==0){
		
		//Instantiate (cubePrefabVariable);
		//Instantiate (cubePrefabVariable2);
		
		
		//Instantiate (spherePrefabVariable);
		//}
		//if(counter <=2){
		
		//for (int i = 1; i <= 2; i++)
		//{
		Instantiate (cubePrefabVariable);
		Instantiate (cubePrefabVariable2);
		//Instantiate (cubePrefabVariable,location.position,location.rotation);
		//Instantiate (cubePrefabVariable2,location.position,location.rotation);
		//}
		
		}
		
		
	}
}

