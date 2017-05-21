using UnityEngine;
using System.Collections;

public class MusicScript : MonoBehaviour {

	public AudioClip soundFile;
	AudioSource mySound;

	void Awake(){

		mySound = GetComponent<AudioSource>();
	}
	// Use this for initialization
	void Start () {
	
		mySound.PlayOneShot (soundFile,0.8f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
