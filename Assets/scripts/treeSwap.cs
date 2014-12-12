using UnityEngine;
using System.Collections;

public class treeSwap : MonoBehaviour {
	public Transform tree1;
	public Transform tree2;
	// Use this for initialization
	void Start () {
		tree1.renderer.enabled = true;
		tree2.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown ("g")) {
			tree1.renderer.enabled = false;
			tree2.renderer.enabled = true;
			}

		if(Input.GetKeyDown("h")) {
			tree1.renderer.enabled = true;
			tree2.renderer.enabled = false;
				}
	} //update
} //mono
