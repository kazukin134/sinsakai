using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


	bool f  = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {

						Application.LoadLevelAdditive ("scene3");
						Time.timeScale = 0;
				}
		if (Input.GetKey (KeyCode.Q)) {

		
				//f = true;
			Application.LoadLevel ("Main");
				Time.timeScale = 1;


		}

	}
}
