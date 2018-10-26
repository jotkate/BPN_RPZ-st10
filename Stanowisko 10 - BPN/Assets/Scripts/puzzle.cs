using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzle : MonoBehaviour {
	public bool correctPos = false;
	public bool mouseIsOverPuzzle = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (!correctPos && Input.GetMouseButton(0) && mouseIsOverPuzzle) {
			transform.position = Input.mousePosition;
		}

		
	}

	void OnMouseOver()
	{
		mouseIsOverPuzzle = true;
		Debug.Log ("mouse is over puzzle");
	}

	void OnMouseExit()
	{
		mouseIsOverPuzzle = false;
		Debug.Log ("mouse is gone");
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		Debug.Log ("Collision detected");
		if (gameObject.name == coll.gameObject.name) {
			correctPos = true;
			transform.position = coll.transform.position;
		}
	}
}
