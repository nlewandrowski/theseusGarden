﻿using UnityEngine;
using System.Collections;

public class generatePlants : MonoBehaviour {

	public Transform myPlant1; //assign in inspector
	public Transform myPlant2;
	public Transform myPlant3; 
	public Transform myPlant4;
	public float plantingRange = 45; //change in inspector based on size of garden

	void Start () {
		StartCoroutine (plantGarden () );
	}
	
	// Update is called once per frame
	void Update () {
		//refreshes the level
		if(Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(0); //or whatever number scene is
		}
		
	}
	
	IEnumerator plantGarden (){
		int totalObjects = 0;
		int counter = 0;
		float randIncX = Random.Range (plantingRange * -1f, plantingRange);
		float randIncZ = Random.Range (plantingRange * -1f, plantingRange);
		
		while (totalObjects < 175) {
			float pickOne = Random.Range (0f, 20f);
			if (pickOne < 4f){
				Instantiate (myPlant1, new Vector3 (randIncX, 1F, randIncZ), Quaternion.identity);

			}
			else if (pickOne < 8f) {
				Instantiate (myPlant2, new Vector3 (randIncX, 1F, randIncZ), Quaternion.identity);
			}
			else if (pickOne < 10f){
				Instantiate (myPlant3, new Vector3 (randIncX, 1F, randIncZ), Quaternion.identity);
			}
			else{
				Instantiate (myPlant4, new Vector3 (randIncX, 1F, randIncZ), Quaternion.identity);
			}
		
			counter++;
			totalObjects++;
			randIncX = Random.Range (plantingRange * -1f, plantingRange);
			randIncZ = Random.Range (plantingRange * -1f, plantingRange);
			yield return new WaitForSeconds(0.1f);
		}
	}
}
