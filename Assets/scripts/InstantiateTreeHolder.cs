using UnityEngine;
using System.Collections;

public class InstantiateTreeHolder : MonoBehaviour {

	public Transform treeHolder;
	public float plantingRange = 45; //change in inspector based on size of garden

	// Use this for initialization
	void Start () {
		StartCoroutine (treePlanter ());
	}//start
	
 

IEnumerator treePlanter (){
	int totalObjects = 0;
	int counter = 0;
	float randIncX = Random.Range (plantingRange * -1f, plantingRange);
	float randIncZ = Random.Range (plantingRange * -1f, plantingRange);
	
	while (totalObjects < 5) {
			Instantiate (treeHolder, new Vector3 (randIncX, 0F, randIncZ), Quaternion.Euler(0, Random.Range(0,360),0));
		
			counter++;
			totalObjects++;
			randIncX = Random.Range (plantingRange * -1f, plantingRange);
			randIncZ = Random.Range (plantingRange * -1f, plantingRange);
			yield return new WaitForSeconds(0.2f);
		}
		

	}//planter
}//mono

