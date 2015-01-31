using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {


	public GameObject Player;

	public float respawn_y = 0.0f; 
	public bool respawn_height = false;

	HPDisplay hpdisplay;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		hpdisplay = Player.GetComponent<HPDisplay> ();
	}
	
	// Update is called once per frame
	void Update () {

		respawn_y = Player.transform.position.y;

		if (respawn_y <= -50.0f || respawn_y >= 50.0f) {
			respawn_height = true;
				}
		if (respawn_height == true) {
			Player.transform.position = new Vector3(0.0f, 4.5f,0.0f);

				}
	}
}
