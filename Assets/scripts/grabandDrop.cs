using UnityEngine;
using System.Collections;

public class grabandDrop : MonoBehaviour {

	GameObject grabbedObject;
	float grabbedObjectSize;
	public float myRange;
	public float carryDist;

	//check if the object is grabable
	bool CanGrab(GameObject candidate){
		return candidate.GetComponent<Rigidbody> () != null;
		}

	GameObject GetMouseHoverObject(float range)
	{
		Vector3 position = gameObject.transform.position;
		RaycastHit raycastHit;
		Vector3 target = position + Camera.main.transform.forward * range;
		int layerMask = 1 << 8;

		//cast the ray
		if (Physics.Linecast (position, target, out raycastHit, layerMask)) {
					return raycastHit.collider.gameObject;	
				} else {
			return null;
				}
		} //end gameObject

	void TryGrabObject(GameObject grabObject){

		if (grabObject == null || !CanGrab (grabObject)) {
						return;
				} else {
			grabbedObject = grabObject;
			grabbedObjectSize = grabObject.renderer.bounds.size.magnitude;
				}

		/*
		if (grabObject.tag == "statue") {
						grabbedObject = grabObject;
						grabbedObjectSize = grabObject.renderer.bounds.size.magnitude;
				} else {
			return;
				}
		*/
	
	} //try


	void DropObject(){
		if (grabbedObject == null) {
						return;
				} else {
			if(grabbedObject.GetComponent<Rigidbody>()!=null){
				grabbedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
			}
			grabbedObject = null;
				}
		} //drop



	// Update is called once per frame
	void Update () {
		Debug.Log (GetMouseHoverObject (myRange));
		if (Input.GetKeyDown(KeyCode.E)) {
						if (grabbedObject == null) {
								TryGrabObject (GetMouseHoverObject (myRange));
						} else {
								DropObject ();
						}
				}
		if (grabbedObject != null) { 
			Vector3 newPosition = gameObject.transform.position + (Camera.main.transform.forward * grabbedObjectSize * carryDist);

			//make sure the object does not fall below the ground
			if(newPosition.y < 0){
				newPosition.y = 2;
			}

			grabbedObject.transform.position = newPosition;


				 
		}
	} //update
}
