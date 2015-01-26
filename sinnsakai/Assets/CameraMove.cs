using UnityEngine;
using System.Collections;
//using Move;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public GameObject Player;
	public GameObject MainCamera;
	public Transform Player_look;

	float camera_z = 0.0f;
	void Update () {



		Player = GameObject.Find ("Player");

		MainCamera = GameObject.Find ("Main Camera");

		transform.LookAt (Player_look);

		camera_z = Player.transform.position.z-8;

		MainCamera.transform.position = new Vector3(0.0f, 4.5f,camera_z);

	}


}
