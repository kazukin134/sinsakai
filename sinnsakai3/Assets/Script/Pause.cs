using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {


	bool pause = false;
	public GameObject Pause1;


	// Use this for initialization
	void Start () {
		Pause1 = GameObject.Find("Pause");
	}


	bool f  = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {

			if(pause == false){
			pause = true;
			}else
				if(pause == true){
				pause = false;

			}
	
		}

		if (pause == false) {
						Time.timeScale = 1;
			GetComponent<Canvas>().enabled = false;
				} else

			if (pause == true) {
			Time.timeScale = 0;
			GetComponent<Canvas>().enabled = true;

			if(Input.GetKeyDown(KeyCode.S)){
				if(Application.loadedLevelName=="Tutorial1")
				{
					Application.LoadLevel ("Tutorial1");
				}else
					if(Application.loadedLevelName=="Tutorial2")
				{
					Application.LoadLevel ("Tutorial2");
				}else
					if(Application.loadedLevelName=="Tutorial3")
				{
					Application.LoadLevel ("Tutorial3");
				}else
					if(Application.loadedLevelName=="Tutorial4")
				{
					Application.LoadLevel ("Stage4");
				}else
					if(Application.loadedLevelName=="Sutage5")
				{
					Application.LoadLevel ("Stage5");
				}else
				if(Application.loadedLevelName=="Sutage6")
				{
					Application.LoadLevel ("Stage6");
				}else
					if(Application.loadedLevelName=="Sutage8")
				{
					Application.LoadLevel ("Stage8");
				}
			}
				}


	}

//	void OnGUI(){
	//
	//	if (pause == true) {
	//					GUI.Label (new Rect (200, 300, 200, 100), "Pause");
	//			}
	//	}
}
