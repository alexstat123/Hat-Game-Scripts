using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform myTransform;
	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;

		myTransform = transform;
	}
	

	void FixedUpdate () {

		//if (attractor){
			//attractor.Attract (myTransform);
		//}
		
	}
}
