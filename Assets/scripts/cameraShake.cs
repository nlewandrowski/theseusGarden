using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour {

	public float distance = .05f; //amount of shake
	public float shakeSpeed = 45f; //shake speed
	public Transform thingToDrop; //item to be dropped
	public float secsUntilStill = .05f; //time until camera is still
	public float shakeThreshold = 0.6f; //y position at which shakes begins
	public AudioClip thud; 
	void Start(){

		}

	void Update () {

	
		if (thingToDrop.transform.position.y < shakeThreshold) {
			
			Camera.main.transform.position += new Vector3 (Mathf.Sin (Time.time * shakeSpeed) * distance * secsUntilStill, 0f, 0f);
			//if (audio.isPlaying == false){
				//audio.Play();
			//}
			//clamping function
			secsUntilStill = Mathf.Clamp (secsUntilStill - Time.deltaTime, 0f, 1f); //after 1 second shakestrength is 0
			//print (thingToDrop.transform.position.y);

		}
		if (thingToDrop.transform.position.y >= shakeThreshold) {
						secsUntilStill = 1;
				}

	}
	
	void OnCollisionEnter(){
		audio.PlayOneShot (thud, .7f);
		print ("play clip");
	}

}//mono
