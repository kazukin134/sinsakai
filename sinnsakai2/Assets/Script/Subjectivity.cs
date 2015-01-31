using UnityEngine;
using System.Collections;

public class Subjectivity : MonoBehaviour {

	public GameObject MainCamera;
	public GameObject Player;
	public GameObject SubjectivityCamera;
	float Player_x = 0.0f;
	float Player_y = 0.0f;
	float Player_z = 0.0f;
	float rotate_x = 0.0f;
	float rotate_y = 0.0f;
	float speed = 2.0f;

	CameraChange camerachange;

	Move move;

	public bool subjectivity_b = false;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		move = Player.GetComponent<Move> ();
		SubjectivityCamera = GameObject.Find ("SubjectivityCamera");
		camerachange = SubjectivityCamera.GetComponent<CameraChange> ();
	}
	
	// Update is called once per frame
	void Update () {
		Player_x = Player.transform.position.x;
		Player_z = Player.transform.position.z;
		Player_y = Player.transform.position.y;

	if (camerachange.cameraturn == CameraChange.CameraTurn.Sub) {
						SubjectivityCamera.transform.position = new Vector3 (Player_x, Player_y, Player_z);
						subjectivity_b = true;

				} else
			if (camerachange.cameraturn == CameraChange.CameraTurn.Main) {
			subjectivity_b = false;
			SubjectivityCamera.transform.rotation = new Quaternion(0,0,0,0);
				}
		if(subjectivity_b == true){




			if (Input.GetKey (KeyCode.RightArrow)) {
				rotate_x = 0.0f;
					rotate_y += speed;
			} else
				
			if (Input.GetKey (KeyCode.LeftArrow)) {
				rotate_x = 0.0f;
				rotate_y -= speed;
			} else {
				rotate_x = 0.0f;
				rotate_y = 0.0f;
			}
			
			transform.Rotate (0, rotate_y, 0, Space.Self);

			if (Input.GetKey (KeyCode.UpArrow)) {
				rotate_y = 0.0f;
				rotate_x -= speed;
				
			} else
			if (Input.GetKey (KeyCode.DownArrow)) {
				rotate_y = 0.0f;
				rotate_x += speed;
			} else {
				rotate_x = 0.0f;
				rotate_y = 0.0f;
			}
			transform.Rotate (rotate_x, 0, 0, Space.Self);
		}

		}
	}

