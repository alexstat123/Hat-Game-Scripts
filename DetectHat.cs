using UnityEngine;
using System.Collections;

public class DetectHat : MonoBehaviour {

	public int hitcunter=0;
	public string HatTag="Bowler";
	public string HatTag2="Bowler";
	public string HatTag3="Bowler";
	private GameObject script;
	public  MasterScoreCounter x;
	int getscore;

	public GameObject plusOneObject;
	public GameObject minusOne;
	public GameObject gameObject4 = null;
	public GameObject gameObject5 = null;
	float bucketpossition=0;

	public AudioClip soundFile;
	AudioSource mySound;

	public AudioClip soundFile2;
	AudioSource mySound2;

	public GameObject crate;
	bool hatInsite=false;
	int logic=0;
	public GameObject gameovertext;


	int j;

	void Awake(){
		
		mySound = GetComponent<AudioSource>();
		mySound2 = GetComponent<AudioSource>();
	}
	// Use this for initialization
	void Start () {

		//getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
		logic = 0;
		PlayerPrefs.SetInt ("GameOver", 0);

	}

	// Update is called once per frame
	void Update () {

		//modifyVariableInAnotherScript ();
		bucketpossition = transform.position.x;
		//Debug.Log (bucketpossition);

		if(bucketpossition < -10 && hatInsite==false){

			//Debug.Log("Game Over");
			PlayerPrefs.SetInt ("GameOver", 1);
		
		}

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag(HatTag))
		{

			getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
			getscore=getscore+1;
			PlayerPrefs.SetInt ("CorrectHatInBasket",getscore);
			//Debug.Log(getscore);
			Vector3 position = new Vector3(bucketpossition, 0, 0);
			gameObject4 = Instantiate(plusOneObject,position, Quaternion.identity) as GameObject;
			mySound.PlayOneShot (soundFile,0.8f);
			crate.GetComponent<SpriteRenderer>().color = Color.green;
			hatInsite=true;
			logic=1;


			

		}

		if(other.gameObject.CompareTag(HatTag2))
		{
			
			getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
			getscore=getscore-1;
			PlayerPrefs.SetInt ("CorrectHatInBasket",getscore);
			//Debug.Log("FedoraHit");
			Vector3 position2 = new Vector3(bucketpossition, 0, 0);
			gameObject5 = Instantiate(minusOne,position2, Quaternion.identity) as GameObject;
			//mySound.PlayOneShot (soundFile,0.8f);
			mySound2.PlayOneShot (soundFile2,0.8f);
			crate.GetComponent<SpriteRenderer>().color = Color.red;
			hatInsite=true;
			logic=1;


		}

		if(other.gameObject.CompareTag(HatTag3))
		{
			
			getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
			getscore=getscore-1;
			PlayerPrefs.SetInt ("CorrectHatInBasket",getscore);
			//Debug.Log("Fez");
			Vector3 position3 = new Vector3(bucketpossition, 0, 0);
			gameObject5 = Instantiate(minusOne,position3, Quaternion.identity) as GameObject;
			//mySound.PlayOneShot (soundFile,0.8f);
			mySound2.PlayOneShot (soundFile2,0.8f);
			crate.GetComponent<SpriteRenderer>().color = Color.red;
			hatInsite=true;
			logic=1;


		}
	}


}
