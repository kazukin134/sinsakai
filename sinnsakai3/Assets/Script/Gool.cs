using UnityEngine;
using System.Collections;

public class Gool : MonoBehaviour {

	public GameObject Player;
	public bool clear = false;
	public GameObject Gool_O;
	// Use this for initialization
	void Start () {
		GetComponent<Canvas>().enabled = false;
		Gool_O = GameObject.Find("Goolfloor");
	}

	void Update () {
	
	}

	void  OnCollisionEnter(Collision collision){
		Player = GameObject.Find("PLayer");
				//if (collision.gameObject.name == "Player") {
			clear = true;
				//}
		}
	void OnGUI(){
		if (clear == false) {

				}else

		if (clear == true) {

			//GUI.Label(new Rect (50,50,100,30), "CLEAR");
			if (Input.GetKey (KeyCode.Return)) {
				if(Application.loadedLevelName=="Tutorial1")
				{
					Application.LoadLevel ("Tutorial2");
				}else
					if(Application.loadedLevelName=="Tutorial2")
				{
					Application.LoadLevel ("Tutorial3");
				}else
					if(Application.loadedLevelName=="Tutorial3")
				{
					Application.LoadLevel ("Tutorial4");
				}else
					if(Application.loadedLevelName=="Tutorial4")
				{
					Application.LoadLevel ("Stage5");
				}else
					if(Application.loadedLevelName=="Stage5")
				{
					Application.LoadLevel ("Stage6");
				}else
				if(Application.loadedLevelName=="Stage6")
				{
					Application.LoadLevel ("Stage7");
				}else
					if(Application.loadedLevelName=="Stage7")
				{
					Application.LoadLevel ("Stage8");
				}else
					if(Application.loadedLevelName=="Stage8")
				{
					Application.LoadLevel ("Stage9");
				}else
					if(Application.loadedLevelName=="Stage9")
				{
					Application.LoadLevel ("Stage10");
				}
		}


				}
		}


}
