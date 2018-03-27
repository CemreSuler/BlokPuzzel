using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public Vector3 Testvec;
	public GameObject dezeBlok;
	public int aantalgehaald = 1;
	public float per = 3f;
	public float speed;
	public GameObject Cube;
	BewegenL beweegscriptL;
	BewegenR beweegscriptR;
	BewegenB beweegscriptB;
	BewegenO beweegscriptO;

	// Use this for initialization
	void Start () {
		beweegscriptL = gameObject.GetComponentInChildren<BewegenL>();
		beweegscriptR = gameObject.GetComponentInChildren<BewegenR>();
		beweegscriptB = gameObject.GetComponentInChildren<BewegenB>();
		beweegscriptO = gameObject.GetComponentInChildren<BewegenO>();
		Testvec = Cube.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Testvec = Cube.transform.position;


}

	public void Up() {
		if (beweegscriptB.magBoven == true) {
			Testvec.z += 1f;
			Cube.transform.position = Testvec;
		}
	} 

	public void Down() {
		if (beweegscriptO.magOnder == true) {
			Testvec.z += -1f;
			Cube.transform.position = Testvec;
		}
	} 

	public void Left() {
		if (transform.position.x > -2) {
			if (beweegscriptL.magLinks == true) {
				Testvec.x += -1f;
				Cube.transform.position = Testvec;
			}
		}
	} 

	public void Right() {
		if (beweegscriptR.magRechts == true) {
			Testvec.x += 1f;
			Cube.transform.position = Testvec;
		}
	} 
}
