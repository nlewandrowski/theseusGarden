using UnityEngine;
using System.Collections;

public class placeStatues : MonoBehaviour {
	public Transform myStatueHead; //assign in inspector
	public Transform myStatueTorso;
	public Transform myStatueLegs; 
	public Transform myStatueFeet;
	public float placementRange = 45; //change in inspector based on size of garden
	// Use this for initialization
	void Start () {
		float randIncHeadX = Random.Range (placementRange * -1f, placementRange);
		float randIncHeadZ = Random.Range (placementRange * -1f, placementRange);
		float randIncTorsoX = Random.Range (placementRange * -1f, placementRange);
		float randIncTorsoZ = Random.Range (placementRange * -1f, placementRange);
		float randIncLegsX = Random.Range (placementRange * -1f, placementRange);
		float randIncLegsZ = Random.Range (placementRange * -1f, placementRange);
		float randIncFeetX = Random.Range (placementRange * -1f, placementRange);
		float randIncFeetZ = Random.Range (placementRange * -1f, placementRange);

		myStatueHead.transform.position = new Vector3 (randIncHeadX, 1F, randIncHeadZ);
		myStatueTorso.transform.position = new Vector3 (randIncTorsoX, 1F, randIncTorsoZ);
		myStatueLegs.transform.position = new Vector3 (randIncLegsX, 1F, randIncLegsZ);
		myStatueFeet.transform.position = new Vector3 (randIncFeetX, 1F, randIncFeetZ);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
