using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public static Rigidbody2D rb;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		audio = GetComponent<AudioSource>();
		GoBall();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.transform.tag == "Player") {
			//rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y / 2 + coll.rigidbody.velocity.y / 3);
			audio.pitch = Random.Range(0.8f, 1.2f);
			audio.Play ();
		}
	}

	 void GoBall () {
		float ram;
		ram = Random.Range (0, 2);
		if (ram <= 1) {
			//rb.position = new Vector2 (Screen.width / 4, Screen.height);
			rb.AddForce (new Vector2 (10, 10));
		} else {
			//rb.position = new Vector2 (Screen.width*(3/4), Screen.height);
			rb.AddForce (new Vector2 (-10, -10));
		}

	}

	public void ReSetBall () {
		rb.position = new Vector2(0, 0);
		rb.velocity = new Vector2(0, 0);
		GoBall ();
	}

}
