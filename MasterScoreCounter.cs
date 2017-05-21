using UnityEngine;
using System.Collections;

public class MasterScoreCounter : MonoBehaviour {

	public int bowlercount=0;
	public int z=0;
	DetectHat BowlerIn;
	// Use this for initialization
	void Start () {
	
		z = 0;
	}
	
	// Update is called once per frame
	void Update () {


		Debug.Log (z);
	}

	public void SetBowlerCount(int bc)
	{

		bowlercount = bc;
	}

	public void SetZ(int stz)
	{
		
		z = stz;
	}
}
