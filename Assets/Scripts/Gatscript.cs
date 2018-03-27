using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gatscript : MonoBehaviour {
	public int BlokNummer;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("WelkBlok", 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.name.Contains("1")) {
			BlokNummer = 1;
		}
		if(col.gameObject.name.Contains("2")) {
			BlokNummer = 2;
		}
		if(col.gameObject.name.Contains("3")) {
			BlokNummer = 3;
		}
		if(col.gameObject.name.Contains("4")) {
			BlokNummer = 4;
		}
		if(col.gameObject.name.Contains("5")) {
			BlokNummer = 5;
		}
		if(col.gameObject.name.Contains("6")) {
			BlokNummer = 6;
		}
		if (PlayerPrefs.GetInt ("WelkBlok") == BlokNummer) {
			Destroy (col.gameObject);
			PlayerPrefs.SetInt ("WelkBlok", PlayerPrefs.GetInt ("WelkBlok") + 1);
		} else {
			Debug.Log ("Je hebt gefaald");

		}
	}
}
