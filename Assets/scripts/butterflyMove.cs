using UnityEngine;
using System.Collections;

public class butterflyMove : MonoBehaviour {
	public float butterflySpeed;
	public float butterflyTorque;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//move forward
		rigidbody.AddForce (transform.forward * Time.deltaTime * butterflySpeed); //applyforce
		rigidbody.AddTorque (Vector3.up * Time.deltaTime * butterflyTorque);
		
		//send the ray out from the object
		Ray ray = new Ray (transform.position, transform.forward);
		//create an array for ray responses
		RaycastHit rayHit = new RaycastHit ();
		
		if (Physics.Raycast (ray, out rayHit, 5f)) {
			//transform.Rotate (0f, Mathf.Sign ( Random.Range (-1f, 1f) ) * 90f, 0f );
			//transform.Rotate(Vector3.right * Time.deltaTime, Space.World);
			transform.Rotate (0f, Random.Range (-1f, 1f) * 90f, 0f );
			
		}
		//Debug.DrawRay ( transform.position, transform.forward * 4f, Color.cyan );
		
	}
}
