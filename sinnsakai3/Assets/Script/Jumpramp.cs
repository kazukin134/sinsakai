using UnityEngine;
using System.Collections;

public class Jumpramp : MonoBehaviour {
	public GameObject Player;

	Jump jump;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		jump = Player.GetComponent<Jump> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionStay(Collision collision){
		if (collision.gameObject.name == "Player") {
			jump.jumpflag = true;
				}

	}
}
