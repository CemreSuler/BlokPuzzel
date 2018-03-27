using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagIkBewegen : MonoBehaviour {
	public bool magLinks;
	public bool magRechts;
	public bool magBoven;
	public bool magOnder;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay(Collision col) {
		if (this.gameObject.name == "Links" && col.gameObject.tag == "Wall") {
			magLinks = false;
		} else if(this.gameObject.name == "Links") {
			magLinks = true;
		}

		if (this.gameObject.name == "Rechts" && col.gameObject.tag == "Wall") {
			magRechts = false;
		} else if(this.gameObject.name == "Rechts") {
			magRechts = true;
		}

		if (this.gameObject.name == "Boven" && col.gameObject.tag == "Wall") {
			magBoven = false;
		} else if(this.gameObject.name == "Boven") {
			magBoven = true;
		}

		if (this.gameObject.name == "Onder" && col.gameObject.tag == "Wall") {
			magOnder = false;
		} else if(this.gameObject.name == "Onder") {
			magOnder = true;
		}
	}


}
