using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		Debug.Log ("Muren Zijn Aanwezig, maar je ziet ze niet, want de renderer is weg!!!");
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		rend.enabled = false;
	}
}
