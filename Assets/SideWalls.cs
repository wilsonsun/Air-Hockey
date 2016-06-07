using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {
	private BallControl bc;
	AudioSource audio;

	void Awake () {
		bc = (BallControl)GameObject.FindGameObjectWithTag("Ball").GetComponent("BallControl");
	}
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D coll){
		if (coll.tag == "Ball") {
			GameManager.Score (transform.name);
			audio.Play ();
			bc.ReSetBall ();
		} 
	} 
}
