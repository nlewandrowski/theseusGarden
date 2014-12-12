using UnityEngine;
using System.Collections;

public class lightUpOnMouseOver : MonoBehaviour {

	public Light whichLight;
	
	// Use this for initialization
	void Start () {
		whichLight.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnMouseEnter () {
		
		whichLight.enabled = true;
		
	}

	void OnMouseExit () {
		whichLight.enabled = false;
		}
}
