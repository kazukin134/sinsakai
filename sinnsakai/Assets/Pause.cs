using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {


	bool pause = false;
	// Use this for initialization
	void Start () {
	
	}


	bool f  = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			pause = true;

			//Application.LoadLevelAdditive ("scene3");
						Time.timeScale = 0;

		}
		if (Input.GetKey (KeyCode.Q)) {

			pause = false;
				//f = true;
			//Application.LoadLevel ("Main");
				Time.timeScale = 1;


		}

	}

	void OnGUI(){

		if (pause == true) {
						GUI.Label (new Rect (200, 300, 200, 100), "Pause");
				}
		}
}
