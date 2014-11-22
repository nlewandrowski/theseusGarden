using UnityEngine;
using System.Collections;

public class playerInteract : MonoBehaviour {

	private Color mouseOverColor = Color.blue;
	private Color originalColor = Color.yellow;
	private bool dragging = false;
	private float distance;
	Transform objectToGrab;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnMouseEnter()
	{
		renderer.material.color = mouseOverColor;
	}
	
	void OnMouseExit()
	{
		renderer.material.color = originalColor;
	}
	
	void OnMouseDown()
	{
		distance = Vector3.Distance(transform.position, Camera.main.transform.position);
		dragging = true;
		print ("dragging");
	}
	
	void OnMouseUp()
	{
		dragging = false;
	}
	
	void Update()
	{
		if (dragging)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Vector3 rayPoint = ray.GetPoint(distance);
			transform.position = rayPoint;
			// visualize raycast in debug mode (scene view)
			//Debug.DrawRay (transform.position, transform.forward * 4f, Color.cyan );
		}
	}

/*

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay ( Input.mousePosition );
		RaycastHit rayHit = new RaycastHit();
		
		if ( Physics.Raycast ( ray, out rayHit, 1000f ) ) {

			if ( Input.GetMouseButtonDown (0) ) {
				if ( rayHit.collider == collider ) {
					transform.localScale *= 1.1f;
					renderer.material.color = mouseOverColor;
				}

		}
	}
}
*/
}
