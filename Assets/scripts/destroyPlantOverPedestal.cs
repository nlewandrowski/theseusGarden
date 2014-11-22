using UnityEngine;
using System.Collections;

public class destroyPlantOverPedestal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay(Collision col){
		if (col.gameObject.tag == "statue" || col.gameObject.tag == "pedestal") {
			Destroy(gameObject);
				}
	}
}
