using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public GameObject TopDoor;
	public GameObject UnderDoor;

	public GameObject DoorGimmick;

	DoorGimmick doorgimmick1;
	//DoorGimimck topdoor;
	//DoorGimimck underdoor;
	// Use this for initialization

	float top_y = 0.0f;
	float under_y = 0.0f;
	float doorspeed = 0.05f;
	float doordistance = 16.0f;
	float maxtop_y = 0.0f; 

	void Start () {
		DoorGimmick = GameObject.Find("Gimmick");

		TopDoor = GameObject.Find("TopDoor");
		UnderDoor = GameObject.Find("UnderDoor");
		doorgimmick1 = DoorGimmick.GetComponent<DoorGimmick> ();
		//topdoor = TopDoor.GetComponent<DoorGimimck> ();
		//underdoor = UnderDoor.GetComponent<DoorGimimck> ();
	}
	
	// Update is called once per frame
	void Update () {
		top_y = TopDoor.transform.position.y;
		under_y = UnderDoor.transform.position.y;
		maxtop_y = TopDoor.transform.position.y;
		if (doorgimmick1.open == true) {
			top_y = doorspeed;
			under_y = -1* doorspeed;
			TopDoor.transform.Translate (0, top_y, 0);
			UnderDoor.transform.Translate (0, under_y, 0);
				}
		if (maxtop_y >= doordistance) {
			doorspeed = 0.0f;
				}


//		TopDoor.transform.position = new Vector3 (top_x,top_y,top_z);
//		UnderDoor.transform.position = new Vector3 (top_x,under_y,top_z);
	}
}
