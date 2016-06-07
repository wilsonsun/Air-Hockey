using UnityEngine;
using System.Collections;

public class MiddleWallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTrigger2D (Collider2D coll){
		if (coll.name == "Player02") {
			Debug.Log ("Plyaer2");
			coll.transform.position = new Vector2 (transform.position.x + coll.transform.lossyScale.x*0.5f, coll.transform.position.y);
		} 
	} 
}
