using UnityEngine;
using System.Collections;

public class DetectAllHats : MonoBehaviour {
	
	public int hitcunter=0;
	public string HatTag="Bowler";
	public string HatTag2="Bowler";
	public string HatTag3="Bowler";
	private GameObject script;
	public  MasterScoreCounter x;
	int getscore;
	public bool countHat=true;

	public GameObject plusOneObject;
	public GameObject gameObject4 = null;

	public AudioClip soundFile;
	AudioSource mySound;
	
	
	int j;

	void Awake(){
		
		mySound = GetComponent<AudioSource>();

	}
	// Use this for initialization
	void Start () {
		
		//getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
		
	}
	
	// Update is called once per frame
	void Update () {


		//modifyVariableInAnotherScript ();
		
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag(HatTag))
		{
			if(countHat=true){


				getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
				getscore=getscore-1;
				PlayerPrefs.SetInt ("CorrectHatInBasket",getscore);
				//Debug.Log(getscore);
				Vector3 position = new Vector3(0, 0, 0);
				gameObject4 = Instantiate(plusOneObject,position, Quaternion.identity) as GameObject;
				mySound.PlayOneShot (soundFile,0.8f);

			}

			
		}
		
		if(other.gameObject.CompareTag(HatTag2))
		{
			if(countHat=true){

				getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
				getscore=getscore-1;
				PlayerPrefs.SetInt ("CorrectHatInBasket",getscore);
				//Debug.Log("FedoraHit");
				Vector3 position = new Vector3(0, 0, 0);
				gameObject4 = Instantiate(plusOneObject,position, Quaternion.identity) as GameObject;
				mySound.PlayOneShot (soundFile,0.8f);
			}

			
		}
		
		if(other.gameObject.CompareTag(HatTag3))
		{
			if(countHat=true){


				getscore = PlayerPrefs.GetInt ("CorrectHatInBasket");
				getscore=getscore-1;
				PlayerPrefs.SetInt ("CorrectHatInBasket",getscore);
				//Debug.Log("Fez");
				Vector3 position = new Vector3(0, 0, 0);
				gameObject4 = Instantiate(plusOneObject,position, Quaternion.identity) as GameObject;
				mySound.PlayOneShot (soundFile,0.8f);
			}

			
		}
	}
	
	
}

