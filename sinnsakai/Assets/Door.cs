using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public GameObject TopDoor;
	public GameObject UnderDoor;

	public GameObject DoorGimmick1;

	DoorGimmick doorgimmick;
	//DoorGimimck topdoor;
	//DoorGimimck underdoor;
	// Use this for initialization

	float top_y = 0.0f;
	float under_y = 0.0f;
	float doorspeed = 0.05f;
	float doordistance = 16.0f;
	void Start () {
		TopDoor = GameObject.Find("TopDoor");
		UnderDoor = GameObject.Find("UnderDoor");
		doorgimmick = DoorGimmick1.GetComponent<DoorGimmick> ();
		//topdoor = TopDoor.GetComponent<DoorGimimck> ();
		//underdoor = UnderDoor.GetComponent<DoorGimimck> ();
	}
	
	// Update is called once per frame
	void Update () {
		top_y = TopDoor.transform.position.y;
		under_y = UnderDoor.transform.position.y;
	if (doorgimmick.open == true) {
			top_y += doorspeed;
			under_y -= doorspeed;
				}
		if (top_y >= doordistance) {
			doorspeed = 0.0f;
				}

		TopDoor.transform.position = new Vector3 (1.0f,top_y,24.0f);
		UnderDoor.transform.position = new Vector3 (1.0f,under_y,24.0f);
	}
}
