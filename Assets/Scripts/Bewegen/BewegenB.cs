using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BewegenB : MonoBehaviour {
	public bool magBoven;
	public Renderer rend;
	// Use this for initialization
	void Start () {
		magBoven = true;
		rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame


	void OnCollisionStay(Collision col) {
		if (this.gameObject.name == "Boven" && col.gameObject.tag == "Wall") {
			magBoven = false;
		} else if (this.gameObject.name == "Boven" && col.gameObject.tag == "Blok") {
			magBoven = false;
		} else if(this.gameObject.name == "Boven") {
			magBoven = true;
		}
	}
	void Update () {
		magBoven = true;
		rend.enabled = false;
	}

}
