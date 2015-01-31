using UnityEngine;
using System.Collections;
//using Move;

public class CameraMove : MonoBehaviour {

	public GameObject Player;
	public GameObject MainCamera;
	public GameObject SubjectivityCamera;
	public Transform Player_look;

	int count = 0;
	float camera_z = 0.0f;
	
	void Start () {
		SubjectivityCamera = GameObject.Find("SubjectivityCamera");

		Player = GameObject.Find ("Player");
		
		MainCamera = GameObject.Find ("Main Camera");
	}
	

	void Update () {
		count++;

		//if (count >= 120) {
			//SubjectivityCamera.renderer.enabled = true;
			//MainCamera.renderer.enabled = false; 
		//		}
	


		transform.LookAt (Player_look);

		camera_z = Player.transform.position.z-8;

		MainCamera.transform.position = new Vector3(1.0f, 4.5f,camera_z);

	}


}
