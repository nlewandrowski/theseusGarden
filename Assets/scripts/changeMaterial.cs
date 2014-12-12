using UnityEngine;
using System.Collections;

public class changeMaterial : MonoBehaviour {

	public Material plantGood;
	public Material plantBad;

	void Start () {
		gameObject.renderer.material = plantGood;
	}
	void Update (){
		if(gameObject.tag == "plant"){
			gameObject.renderer.material = plantBad;
		}
	}
}
