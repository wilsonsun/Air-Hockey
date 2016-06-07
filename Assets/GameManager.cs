using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int playerScore01 = 0;
	public static int playerSocer02 = 0;

	public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void Score (string wallName) {
		if (wallName == "RightWall") {
			playerScore01 += 1;
		} else {
			playerSocer02 += 1;
		}
	}

	void OnGUI () {
		GUI.skin = skin;
		GUI.color = Color.red;
		GUI.Label (new Rect (Screen.width / 2 - 150, 80, 400, 400), "" + playerScore01);
		GUI.Label (new Rect (Screen.width / 2 + 150, 80, 400, 400), "" + playerSocer02);
	}
}
