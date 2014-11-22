using UnityEngine;
using System.Collections;

public class objectsTouching : MonoBehaviour {

	//these variables change based on the object being placed
	public Component ObjecttoCheck;
	public string NameofObjecttoCheck; //set in inspector
	public Component PreviousObject;
	public Vector3 PreviousObjectLockPos;
	public Vector3 PositionToPlace; //set in inspector
	public Vector3 defaultPosition;
	//public bool touching = false;
	//float ObjecttoCheckPosY;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//keep track on object position
		//keep it above the floor
		//ObjecttoCheckPosY = ObjecttoCheck.transform.position.y;
		//if (ObjecttoCheckPosY < 0) {
		//	ObjecttoCheck.transform.position.y = 3;
		//		}

	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == NameofObjecttoCheck) {

						//make it so object cannot be moved again.
						//ObjecttoCheck.gameObject.layer = 0;
						//make it so object is frozen in position

						if (PreviousObject.transform.position == PreviousObjectLockPos) {

								ObjecttoCheck.transform.position = PositionToPlace;
								ObjecttoCheck.transform.rotation = Quaternion.identity;
								if (ObjecttoCheck.transform.position == PositionToPlace) {
										ObjecttoCheck.gameObject.layer = 0;
										ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
										//touching = true;
								}
								//ObjecttoCheck.gameObject.rigidbody.useGravity = false;
								//ObjecttoCheckPosY = PositionToPlace;
			} //else {
				//ObjecttoCheck.transform.position = defaultPosition;
			//}
				}

	} //enter

	//void OnCollisionStay(Collision col){
		//if (col.gameObject.name == NameofObjecttoCheck) {
			//ObjecttoCheck.transform.position = PositionToPlace;
			//make it so object cannot be moved again.
	//		ObjecttoCheck.gameObject.layer = 0;
			//make it so object is frozen in position
			//ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeAll;
			//ObjecttoCheck.gameObject.rigidbody.useGravity = false;
			//ObjecttoCheckPosY = PositionToPlace;
	//	}
		
	//} 


	void OnCollisionExit(Collision col){
		if(ObjecttoCheck.transform.position != PositionToPlace){
		ObjecttoCheck.gameObject.layer = 8;
		ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.None;
		ObjecttoCheck.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		}
		//make it so 
		//ObjecttoCheck.gameObject.rigidbody.useGravity = true;
		//ObjecttoCheckPosY = PositionToPlace;
	}

}
