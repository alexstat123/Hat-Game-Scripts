using UnityEngine;
using System.Collections;

public class ShowAddvertisement : MonoBehaviour {

	public AdManager ad;
	// Use this for initialization
	void Start () {
	
		//AdManager.Instance.showBanner ();
		//ad.showBanner ();
	}
	
	// Update is called once per frame
	void Update () {
	
		ad.showBanner ();
		//ad.showVideo ();
	}
}
