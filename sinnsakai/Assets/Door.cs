using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public GameObject TopDoor;
	public GameObject UnderDoor;

	public GameObject DoorGimmick1;

	DoorGimmick doorgimick;
	//DoorGimimck topdoor;
	//DoorGimimck underdoor;
	// Use this for initialization

	float top_y = 0.0f;
	float under_y = 0.0f;
	void Start () {
		TopDoor = GameObject.Find("TopDoor");
		UnderDoor = GameObject.Find("UnderDoor");
		DoorGimmick = DoorGimmick1.GetComponent<DoorGimmick> ();
		//topdoor = TopDoor.GetComponent<DoorGimimck> ();
		//underdoor = UnderDoor.GetComponent<DoorGimimck> ();
	}
	
	// Update is called once per frame
	void Update () {

	if (doorgimick.open = true) {

				}
	}
}
