using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegenR : MonoBehaviour {
	
	public bool magRechts;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		magRechts = true;
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame

	void OnCollisionStay(Collision col) {
		if (this.gameObject.name == "Rechts" && col.gameObject.tag == "Wall") {
			magRechts = false;
		} else if (this.gameObject.name == "Rechts" && col.gameObject.tag == "Blok") {
			magRechts = false;
		} else if(this.gameObject.name == "Rechts") {
			magRechts = true;
		}
	}
	void Update () {
		magRechts = true;
		rend.enabled = false;
	}

}
