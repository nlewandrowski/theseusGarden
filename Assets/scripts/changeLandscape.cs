using UnityEngine;
using System.Collections;

public class changeLandscape : MonoBehaviour {
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
	public Component plant1;
	 

	//materials that will change once the statue is built
	public Material SkyNice;
	public Material SkyBad;
	public Material groundNice;
	public Material groundBad;
	public Material plant1Nice;
	public Material plant1Bad;

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

		if ((statueFeet.transform.position == statueFeetPos) &&
		    (statueLegs.transform.position == statueLegsPos) &&
		    (statueTorso.transform.position == statueTorsoPos) &&
		    (statueHead.transform.position == statueHeadPos)) 
		{
			//skybox change
			RenderSettings.skybox = SkyBad;

			//materials change
			ground.renderer.material = groundBad;
			plant1.renderer.material = plant1Bad;

			//audio change
			GoodSound.Stop();
			if(!BadSound.isPlaying){
			BadSound.Play();
			BadSound.loop = true;
			}
		}
	
	} //update
}
