using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {


	public GameObject Player;
	public GameObject Block;
	public GameObject MainCamera;

	public float respawn_y = 0.0f; 
	public bool respawn_height = false;
	public bool respawn_height_b = false;
	public float respawn_b = 0.0f;
	HPDisplay hpdisplay;
	Gravity gravity;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		Block = GameObject.Find("Block");
		hpdisplay = Player.GetComponent<HPDisplay> ();
		MainCamera = GameObject.Find("Main Camera");
		gravity = MainCamera.GetComponent<Gravity> ();
	}
	
	// Update is called once per frame
	void Update () {

		respawn_y = Player.transform.position.y;
		respawn_b = Block.transform.position.y;

		if (respawn_y <= -50.0f || respawn_y >= 50.0f) {
			respawn_height = true;
				}else
		if (respawn_b <= -50.0f || respawn_b >= 50.0f) {
			respawn_height_b = true;
				}

		if (respawn_height_b == true) {
			gravity.reveres = false;
			Block.transform.position = new Vector3(0.0f, 4.5f,0.0f);
			gravity.rotation_z = 0.0f;
			respawn_height_b = false;
		}
		if (respawn_height == true) {
			gravity.reveres = false;
			Player.transform.position = new Vector3(0.0f, 4.5f,0.0f);
			gravity.rotation_z = 0.0f;
			respawn_height = false;
				}
	}
}
