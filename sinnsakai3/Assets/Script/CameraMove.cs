using UnityEngine;
using System.Collections;
//using Move;

public class CameraMove : MonoBehaviour {

	public GameObject Player;
	public GameObject MainCamera;
	public GameObject SubjectivityCamera;
	public Transform Player_look;



	float camera_z = 0.0f;
	float camera_y = 7.0f;

	//Vector3 offset = Vector3.zero;

	Jump jump;
	Gravity gravity;

	void Start () {
		SubjectivityCamera = GameObject.Find("SubjectivityCamera");

		Player = GameObject.Find ("Player");
		
		MainCamera = GameObject.Find ("Main Camera");

		jump = Player.GetComponent<Jump> ();
		gravity = MainCamera.GetComponent<Gravity> ();

		//offset = transform.position - Player.transform.position;

	}
	

	void Update () {

		transform.LookAt (Player_look);

		camera_z = Player.transform.position.z - 8;

		if (jump.jumpflag == false) {
			if(gravity.reveres == false){
						camera_y = Player.transform.position.y + 2.2f;

			}else
				if(gravity.reveres == true){
				camera_y = Player.transform.position.y - 2.2f;
			}
				}
		//transform.position = Player.transform.position + offset;
		MainCamera.transform.position = new Vector3(1.0f, camera_y,camera_z);



	}

}
	