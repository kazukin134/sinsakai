using UnityEngine;
using System.Collections;

public class Doordelete : MonoBehaviour {


	public GameObject Door_G;
	public GameObject Gool;
	DoorGimmick doorgimmick;

	void Start () {
		Door_G = GameObject.Find("Gimmick");
		doorgimmick = Door_G.GetComponent<DoorGimmick> ();
		Gool = GameObject.Find("Gool 1");
	}
	
	void Update () {
		if (doorgimmick.open == true) {
			//GetComponent<Gool>().enabled = false;
			//renderer.enabled = false;
			Destroy(Gool);
				}
	
	}
}
