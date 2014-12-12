using UnityEngine;
using System.Collections;

public class changeLandscape : MonoBehaviour {

	//statue
	public Component statue;

	//statue parts and positions to check if the statue is built
	public Component statueHead;
	public Vector3 statueHeadPos;
	public Component statueTorso;
	public Vector3 statueTorsoPos;
	public Component statueLegs;
	public Vector3 statueLegsPos;
	public Component statueFeet;
	public Vector3 statueFeetPos;

	//components that will be changed
	public Component ground;
	public Component wall1;
	public Component wall2;
	public Component wall3;
	public Component wall4;


	//set arrays for the plant clones
	//starting trees
	public GameObject[] plant1s;
	public GameObject[] plant2s;
	public GameObject[] plant3s;
	public GameObject[] plant4s;
	//swap with
	public GameObject[] plant5s;
	public GameObject[] plant6s;
	public GameObject[] plant7s;
	public GameObject[] plant8s;

	//materials that will change once the statue is built
	//sky
	public Material SkyNice;
	public Material SkyBad;
	//ground
	public Material groundBad;
	//walls
	public Material wallBad;
	//plants
	public Material plant1Bad;
	public Material plant2Bad;
	public Material plant3Bad;
	public Material plant4Bad;

	//An array for all the sounds that are attached to the camera
	public AudioSource[] sounds;
	AudioSource GoodSound;
	AudioSource BadSound;

	// Use this for initialization
	void Start () {
		RenderSettings.skybox = SkyNice;

		//set sound variables equal to positions in the array
		sounds = GetComponents<AudioSource> ();
		GoodSound = sounds [0];
		BadSound = sounds [1];
	
	} //start
	
	// Update is called once per frame
	void Update () {

		//check if the statue is built
		//if so, change the materials and sounds of the objects in the environment
		//plant1s = GameObject.FindGameObjectsWithTag ("plant1");

		if ((statueFeet.transform.position == statueFeetPos) &&
		    (statueLegs.transform.position == statueLegsPos) &&
		    (statueTorso.transform.position == statueTorsoPos) &&
		    (statueHead.transform.position == statueHeadPos)) 
		{
			//skybox change
			RenderSettings.skybox = SkyBad;

			//materials change
			ground.renderer.material = groundBad;
			wall1.renderer.material = wallBad;
			wall2.renderer.material = wallBad;
			wall3.renderer.material = wallBad;
			wall4.renderer.material = wallBad;

			//hide blocks
			statueHead.renderer.enabled = false;
			statueTorso.renderer.enabled = false;
			statueLegs.renderer.enabled = false;
			statueFeet.renderer.enabled = false;

			//instantiate statue
			statue.renderer.enabled = true;

			//plant1.renderer.material = plant1Bad;

			plant1s = GameObject.FindGameObjectsWithTag("plant1");

			foreach (GameObject plant in plant1s) {
				//plant.renderer.material = plant1Bad;
				plant.renderer.enabled = false;
			}

			plant2s = GameObject.FindGameObjectsWithTag("plant2");
			
			foreach (GameObject plant in plant2s) {
				//plant.renderer.material = plant2Bad;
				plant.renderer.enabled = false;
			}

			plant3s = GameObject.FindGameObjectsWithTag("plant3");
			
			foreach (GameObject plant in plant3s) {
				//plant.renderer.material = plant3Bad;
				plant.renderer.enabled = false;
			}

			plant4s = GameObject.FindGameObjectsWithTag("plant4");
			
			foreach (GameObject plant in plant4s) {
				//plant.renderer.material = plant4Bad;
				plant.renderer.enabled = false;
			}
			plant5s = GameObject.FindGameObjectsWithTag("plant5");
			
			foreach (GameObject plant in plant5s) {
				//plant.renderer.material = plant1Bad;
				plant.renderer.enabled = true;
			}
			
			plant6s = GameObject.FindGameObjectsWithTag("plant6");
			
			foreach (GameObject plant in plant6s) {
				//plant.renderer.material = plant2Bad;
				plant.renderer.enabled = true;
			}
			
			plant7s = GameObject.FindGameObjectsWithTag("plant7");
			
			foreach (GameObject plant in plant7s) {
				//plant.renderer.material = plant3Bad;
				plant.renderer.enabled = true;
			}
			
			plant8s = GameObject.FindGameObjectsWithTag("plant8");
			
			foreach (GameObject plant in plant8s) {
				//plant.renderer.material = plant4Bad;
				plant.renderer.enabled = true;
			}

			//audio change
			GoodSound.Stop();
			if(!BadSound.isPlaying){
			BadSound.Play();
			BadSound.loop = true;
			}
		}
	
	} //update
}
