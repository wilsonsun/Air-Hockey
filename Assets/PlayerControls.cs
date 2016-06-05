﻿using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	private Rigidbody2D rb;
	public float speed = 10f;
	public KeyCode moveUp;
	public KeyCode moveDown;
	public KeyCode moveLeft;
	public KeyCode moveRight;

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
		rb.velocity = new Vector2 ((float)rb.velocity.x*0.9f, (float)rb.velocity.y*0.9f);
	}
}
