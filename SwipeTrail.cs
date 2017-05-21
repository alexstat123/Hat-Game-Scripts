using UnityEngine;
using System.Collections;

public class SwipeTrail : MonoBehaviour {

	public GameObject applePrefab;
	public GameObject halfApplePrefab;
	public GameObject quartApplePrefab;
	GameObject gObj=null;
	// Use this for initialization
	void Start () {
	
	}

	Ray GenerateMouseRay(Vector3 touchPos){

		Vector3 mousePosFar = new Vector3 (touchPos.x, touchPos.y, Camera.main.farClipPlane);
		Vector3 mousePosNear = new Vector3 (touchPos.x, touchPos.y, Camera.main.nearClipPlane);
		Vector3 mousePosF = Camera.main.ScreenToWorldPoint (mousePosFar);
		Vector3 mousePosN = Camera.main.ScreenToWorldPoint (mousePosNear);

		Ray mr = new Ray (mousePosN, mousePosF - mousePosN);
		return mr;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) 
		    || Input.GetMouseButton(0)))
		{
		Plane objPlane = new Plane (Camera.main.transform.forward * -1, this.transform.position);
		Ray mRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		float rayDistance;
		if (objPlane.Raycast (mRay, out rayDistance))
			this.transform.position = mRay.GetPoint (rayDistance);

			Ray mouseRay = GenerateMouseRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(mouseRay.origin,mouseRay.direction,out hit)){

				gObj = hit.transform.gameObject;

				if(gObj.tag =="whole"){

					Debug.Log("Hit!");
					GameObject h1 = (GameObject)Instantiate(halfApplePrefab,gObj.transform.position, gObj.transform.rotation);
					GameObject h2 = (GameObject)Instantiate(halfApplePrefab,gObj.transform.position, gObj.transform.rotation);
					Destroy(gObj);
				}
			}

		}
	}
}
