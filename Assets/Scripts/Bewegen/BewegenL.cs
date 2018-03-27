using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegenL : MonoBehaviour {
	public bool magLinks;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		magLinks = true;
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame


	void OnCollisionStay(Collision col) {
		if (this.gameObject.name == "Links" && col.gameObject.tag == "Wall") {
			magLinks = false;
		} else if(this.gameObject.name == "Links" && col.gameObject.tag == "Blok") {
			magLinks = false;
		} else if(this.gameObject.name == "Links") {
			magLinks = true;
		}	
	}
	void Update () {
		magLinks = true;
		rend.enabled = false;
	}

}
