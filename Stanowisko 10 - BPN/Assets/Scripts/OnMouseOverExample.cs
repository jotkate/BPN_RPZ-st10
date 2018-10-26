using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnMouseOverExample : MonoBehaviour {

	/* Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
*/
	void OnMouseOver()
	{
		Debug.Log ("mouse over");
	}

	void OnMouseExit()
	{
		Debug.Log ("mouse exit");
	}
}
