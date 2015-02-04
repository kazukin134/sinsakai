using UnityEngine;
using System.Collections;

public class Gool_T : MonoBehaviour {

	public GameObject Gool_F;

	Gool gool; 
	// Use this for initialization
	void Start () {
		Gool_F = GameObject.Find("Goolfloor");
		gool = Gool_F.GetComponent<Gool> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gool.clear == false) {
			GetComponent<Canvas>().enabled = false;
				} else
			if (gool.clear == true) {
			GetComponent<Canvas>().enabled = true;
				}

	}
}
