using UnityEngine;
using System.Collections;

public class objectsTouching : MonoBehaviour {

	//these variables change based on the object being placed
	public Component ObjecttoCheck;
	public string NameofObjecttoCheck; //set in inspector
	public Component PreviousObject;
	public Vector3 PreviousObjectLockPos;
	public Vector3 PositionToPlace; //set in inspector
	float ObjecttoCheckPosY;

	//camera shake
	public float distance = .05f; //amount of shake
	public float shakeSpeed = 45f; //shake speed
	public float secsUntilStill = .05f; //time until camera is still


	// Update is called once per frame
	void Update () {
		//keep track on object position
		//keep it above the floor
		ObjecttoCheckPosY = ObjecttoCheck.transform.position.y;
		if (ObjecttoCheckPosY < 0) {
			ObjecttoCheckPosY = 3;
				}



	}
	
	void OnCollisionEnter(Collision col){
				if (col.gameObject.name == NameofObjecttoCheck) {

						//make it so object cannot be moved again.
						//ObjecttoCheck.gameObject.layer = 0;
						//make it so object is frozen in position
			Camera.main.transform.position += new Vector3 (0f, Mathf.Sin (Time.time * shakeSpeed) * distance * secsUntilStill, 0f);
			//clamping function
			secsUntilStill = Mathf.Clamp (secsUntilStill - Time.deltaTime, 0f, 1f); //after 1 second shakestrength is 0

			if (PreviousObject.transform.position == PreviousObjectLockPos) {

							
							ObjecttoCheck.transform.position = PositionToPlace;
							ObjecttoCheck.transform.rotation = Quaternion.identity;
								
							if (ObjecttoCheck.transform.position == PositionToPlace) {
										ObjecttoCheck.gameObject.layer = 0;
										ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
										
				}
				
				else if (ObjecttoCheck.transform.position != PositionToPlace){
								ObjecttoCheck.gameObject.layer = 8;
								ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.None;
								ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
								secsUntilStill = 1;
				}
						}			
								
						//ObjecttoCheck.gameObject.rigidbody.useGravity = false;
						//ObjecttoCheckPosY = PositionToPlace;
						//else {
						//ObjecttoCheck.transform.position = defaultPosition;
						//}
				}

		}//enter

	/*
	void OnCollisionStay(Collision col){
		if (col.gameObject.name == NameofObjecttoCheck) {
			ObjecttoCheck.transform.position = PositionToPlace;
			//make it so object cannot be moved again.
			ObjecttoCheck.gameObject.layer = 0;
			//make it so object is frozen in position
			ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			ObjecttoCheck.gameObject.rigidbody.useGravity = false;
			ObjecttoCheckPosY = PositionToPlace.y;
		}
		
	}//stay 
*/

	void OnCollisionExit(Collision col){
		if(ObjecttoCheck.transform.position != PositionToPlace)
		{
		ObjecttoCheck.gameObject.layer = 8;
		ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.None;
		ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		}
		//make it so 
		ObjecttoCheck.gameObject.rigidbody.useGravity = true;
		ObjecttoCheckPosY = PositionToPlace.y;
		}//exit

}//mono
