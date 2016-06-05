using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchScript : MonoBehaviour {
	private Image bgImg;

	// Use this for initialization
	void Start () {
		bgImg = GetComponent<Image> ();

	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnMouseDown() {
		Debug.Log ("here");
	}

	public virtual void OnPointerDown (PointerEventData ped) {
		

	}

	public virtual void OnPointerUp (PointerEventData ped) {


	}

	public virtual void OnDrag (PointerEventData ped) {


	}
}
