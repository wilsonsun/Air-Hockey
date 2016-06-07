using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed = 10f;
	public KeyCode moveUp;
	public KeyCode moveDown;
	public KeyCode moveLeft;
	public KeyCode moveRight;
	public Camera mainCam;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveUp)) {
			rb.velocity = new Vector2 (0, speed);
		} 
		if (Input.GetKey (moveDown)) {
			rb.velocity = new Vector2 (0, -speed);
		}
		if (Input.GetKey (moveLeft)) {
			rb.velocity = new Vector2 (-speed, 0);
		} 
		if (Input.GetKey (moveRight)) {
			rb.velocity = new Vector2 (speed, 0);
		} 
			
		if (transform.name == "Player01" && transform.position.x < -mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x+transform.localScale.x*0.5f) {
			transform.position = new Vector2 (-mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x+transform.localScale.x*0.5f, transform.position.y);
		}

		if (transform.name == "Player02" && transform.position.x > mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x-transform.localScale.x*0.5f) {
			transform.position = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x-transform.localScale.x*0.5f, transform.position.y);
		}

		if (transform.name == "Player01") {
			if (transform.position.x > -transform.localScale.x * 0.7f) {
				rb.position = new Vector2 (-transform.localScale.x * 0.7f, transform.position.y);
				rb.velocity = new Vector2 (0f, 0f);
			}
		}

		if (transform.name == "Player02") {
			if (transform.position.x < transform.localScale.x) {
				rb.position = new Vector2 (transform.localScale.x, transform.position.y);
				rb.velocity = new Vector2 (0f, 0f);
			}
		}

		if (Input.touchCount > 0) {
			for(int i = 0; i < Input.touchCount; i++) {
				Touch t = Input.GetTouch(i);
				print (t.phase);
				Vector2 Tposition = Camera.main.ScreenToWorldPoint (t.position);


				if (t.phase == TouchPhase.Began) {
					float deltaX = transform.localScale.x * 0.9f;
					float deltaY = transform.localScale.y * 0.9f;

					if (Tposition.x > transform.position.x - deltaX &&
					    Tposition.x < transform.position.x + deltaX &&
					    Tposition.y > transform.position.y - deltaY &&
					    Tposition.y < transform.position.y + deltaY) {

						print (t.position);
						transform.position = Tposition;
						rb.velocity = new Vector2(0f, 0f);
					}
				} else if (t.phase == TouchPhase.Moved) {
					Vector2 dir;
					Vector2 TMposition = Camera.main.ScreenToWorldPoint (t.position);

					float deltaX = transform.localScale.x * 0.9f;
					float deltaY = transform.localScale.y * 0.9f;
					dir.x = Input.acceleration.x;
					dir.y = Input.acceleration.y;
					// we assume that the device is held parallel to the ground
					// and the Home button is in the right hand
				
					// remap the device acceleration axis to game coordinates:
					// 1) XY plane of the device is mapped onto XZ plane
					// 2) rotated 90 degrees around Y axis
				
					if (TMposition.x > transform.position.x - deltaX &&
					    TMposition.x < transform.position.x + deltaX &&
					    TMposition.y > transform.position.y - deltaY &&
					    TMposition.y < transform.position.y + deltaY) {
						// clamp acceleration vector to the unit sphere
						if (dir.sqrMagnitude > 1)
							dir.Normalize ();
							
						// Make it move 10 meters per second instead of 10 meters per frame...
						dir *= Time.deltaTime;
							
						// Move object
						if (transform.name == "Player01") {
							if (TMposition.x > -transform.localScale.x * 0.7f) {
								rb.position = new Vector2 (-transform.localScale.x * 0.7f, TMposition.y);
								rb.velocity = new Vector2 (0f, 0f);
							}
							else {
								transform.position = TMposition;
								rb.velocity = new Vector2 (t.deltaPosition.x*0.15f, t.deltaPosition.y*0.15f);
							}
						}

						if (transform.name == "Player02") {
							if (TMposition.x < transform.localScale.x) {
								rb.position = new Vector2 (transform.localScale.x, TMposition.y);
								rb.velocity = new Vector2 (0f, 0f);
							}
							else {
								transform.position = TMposition;
								rb.velocity = new Vector2 (t.deltaPosition.x*0.15f, t.deltaPosition.y*0.15f);
							}
						}


							
					}




				} else if (t.phase == TouchPhase.Ended) {
					rb.velocity = new Vector2 (0f, 0f);
				}


			}
		}

	}


	/*
	void OnMouseDown() {
		Vector3 clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector2 (clickedPosition.x, clickedPosition.y);
	}

	void OnMouseDrag() {
		Vector3 clickedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		rb.position = new Vector2 (clickedPosition.x, clickedPosition.y);
		if (transform.name == "Player01") {
			if (clickedPosition.x  > -transform.localScale.x*0.7f)
				rb.position = new Vector2 (-transform.localScale.x*0.7f, clickedPosition.y);
		}

		if (transform.name == "Player02") {
			if (clickedPosition.x  < transform.localScale.x)
				rb.position = new Vector2 (transform.localScale.x, clickedPosition.y);
		}
		rb.velocity = new Vector2(Input.GetAxis("Mouse X")*3f,Input.GetAxis("Mouse Y")*3f);
	} */
}
