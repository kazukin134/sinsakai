using UnityEngine;
using System.Collections;

public class Gool : MonoBehaviour {

	public GameObject Player;
	bool clear = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void  OnCollisionEnter(Collision collision){
		Player = GameObject.Find("PLayer");
				if (collision.gameObject.name == "Player") {
			clear = true;
				}
		}
	void OnGUI(){
		if (clear == true) {
			GUI.Label(new Rect (50,50,100,30), "CLEAR");	
		}
		}


}
