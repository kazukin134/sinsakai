using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {


	public GameObject Player;

	public float respawn_y = 0.0f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Player = GameObject.Find ("Player");
		respawn_y = Player.transform.position.y;

		if (respawn_y <= -50.0f) {
			Player.transform.position = new Vector3(0.0f, 4.5f,0.0f);
						//respawn_y = 2.0f;
				} else
			if (respawn_y >= 50.0f) {
			Player.transform.position = new Vector3(0.0f, 4.5f,0.0f);
				}
	}
}
