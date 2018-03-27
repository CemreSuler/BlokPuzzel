using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegenO : MonoBehaviour {
	public Renderer rend;
	public bool magOnder;
	// Use this for initialization
	void Start () {
		magOnder = true;
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame


	void OnCollisionStay(Collision col) {
		if (this.gameObject.name == "Onder" && col.gameObject.tag == "Wall") {
			magOnder = false;
		} else if (this.gameObject.name == "Onder" && col.gameObject.tag == "Blok") {
			magOnder = false;
		} else if(this.gameObject.name == "Onder") {
			magOnder = true;
		}
	}
	void Update () {
		magOnder = true;
		rend.enabled = false;
	}

}
