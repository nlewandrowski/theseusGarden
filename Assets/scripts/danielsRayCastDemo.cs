using UnityEngine;
using System.Collections;

public class danielsRayCastDemo : MonoBehaviour {

	//make an empty variable to hold the object we hit
	public Transform objecttograb;

	private Color mouseOverColor = Color.blue;
	private Color originalColor = Color.yellow;
	//public Transform blueprint;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			//Construct Ray and RaycastHit before shooting the Raycast
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit rayHit = new RaycastHit (); //blank container for information
			
			// actually shoot the Raycast now
			if (Physics.Raycast (ray, out rayHit, 1000f)) {
				objecttograb = rayHit.transform;
				objecttograb.renderer.material.color = mouseOverColor;
				//transform.LookAt (rayHit.point);
				//Instantiate(blueprint, rayHit.point,Quaternion.identity);
				//gameObject.transform.position.x = Input.mousePosition.x;

				if (Input.GetMouseButton(0)){
					//objecttograb.transform.position = new Vector3 (0, 0, 0);
					//objecttograb.transform.position =
				}
				}



		}

	}




}