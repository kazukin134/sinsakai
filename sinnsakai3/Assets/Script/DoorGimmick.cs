using UnityEngine;
using System.Collections;

public class DoorGimmick : MonoBehaviour {


	public GameObject Block;
	public bool open = false;
	// Use this for initialization
	void Start () {
		Block = GameObject.Find("Block");
	}
	
	// Update is called once per frame
	public void Update () {
	
	}

	 void OnCollisionEnter(Collision collision) {
				if (collision.gameObject.name == "Block") {
						open = true;
				}
		}
}
