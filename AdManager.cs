using UnityEngine;
using System.Collections;
//using admob;

public class AdManager : MonoBehaviour {

	public static AdManager Instance { set; get;}

	public string bannerIs;
	public string VideoId;
	// Use this for initialization
	void Start () {

		Instance = this;
		DontDestroyOnLoad (gameObject);

#if UNITY_EDITOR
#elif UNITY_ANDROID
		//Admob.Instance ().initAdmob (bannerIs,VideoId);
		//Admob.Instance().setTesting(true);
		//Admob.Instance ().loadInterstitial ();
#endif
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showBanner()
	{
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		//Admob.Instance ().showBannerRelative (AdSize.Banner,AdPosition.BOTTOM_CENTER,5);
		#endif
	}

	public void showVideo()
	{
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		//if(Admob.Instance().isInterstitialReady()){

			//Admob.Instance().showInterstitial();

		//}

		#endif

	}


}
