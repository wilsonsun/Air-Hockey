using UnityEngine;
using System.Collections;

public class GameSetUp : MonoBehaviour {
	public Camera mainCam;

	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;
	public BoxCollider2D leftWall01;
	public BoxCollider2D leftWall02;
	public BoxCollider2D rightWall01;
	public BoxCollider2D rightWall02;
	public BoxCollider2D MiddleWall;


	public Transform player01;
	public Transform player02;

	// Use this for initialization
	void Start () {
		PlayersPosSetUp ();
	
	}
	
	// Update is called once per frame
	void Update () {
		SetUpWalls ();

	
	}

	void SetUpWalls () {
		topWall.size = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y+0.5f);

		bottomWall.size = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.offset = new Vector2 (0f, mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y-0.5f);

		leftWall.size = new Vector2 (1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*0.2f);
		leftWall.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x-0.5f, 0f);

		rightWall.size = new Vector2 (1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*0.2f);
		rightWall.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x+0.5f, 0f);

		leftWall01.size = new Vector2 (1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*0.5f);
		leftWall01.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x-0.5f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y+0.5f);

		leftWall02.size = new Vector2 (1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*0.5f);
		leftWall02.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x-0.5f, mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y-0.5f);

		rightWall01.size = new Vector2 (1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*0.5f);
		rightWall01.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x+0.5f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y+0.5f);

		rightWall02.size = new Vector2 (1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*0.5f);
		rightWall02.offset = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x+0.5f, mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y-0.5f);

		MiddleWall.size = new Vector2 (1.5f, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height * 2f, 0f)).y*2f);
		MiddleWall.offset = new Vector2 (0f, 0f);
	}

	void PlayersPosSetUp () {
		player01.position = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, 0f);
		player02.position = new Vector2 (mainCam.ScreenToWorldPoint (new Vector3 (Screen.width - 75f, 0f, 0f)).x, 0f);
	}
}
