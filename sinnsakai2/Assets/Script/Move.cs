using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public float x = 0.0f;
	public float z = 0.0f;
	float speed = 0.05f;

	public GameObject Gravity1;
	public GameObject Subjectivity1;

	Gravity gravity;
	Subjectivity subjectivity;

	void Start () {
		Gravity1 = GameObject.Find ("Main Camera");
		gravity = Gravity1.GetComponent<Gravity>();
		Subjectivity1 = GameObject.Find("SubjectivityCamera");
		subjectivity = Subjectivity1.GetComponent<Subjectivity> ();
	}

	void Update () {

		if (Time.timeScale == 1 && subjectivity.subjectivity_b == false) {

						if (Input.GetKey (KeyCode.RightArrow)) {
								if (gravity.reveres == false) {
										x += speed;
										z = 0.0f;
								}
								if (gravity.reveres == true) {
										x -= speed;
										z = 0.0f;
								}
			
						} else
			
						if (Input.GetKey (KeyCode.LeftArrow)) {
							if (gravity.reveres == false) {
										x -= speed;
										z = 0.0f;
								}

								if (gravity.reveres == true) {
										x += speed;
										z = 0.0f;
								}
						} else {
								x = 0.0f;
								z = 0.0f;
						}
		
						transform.Translate (x, 0, 0, Space.Self);
		
		
						if (Input.GetKey (KeyCode.UpArrow)) {
								z += speed;
								x = 0.0f;
			
						} else
		if (Input.GetKey (KeyCode.DownArrow)) {
								z -= speed;
								x = 0.0f;
						} else {
								x = 0.0f;
								z = 0.0f;
						}
						transform.Translate (0, 0, z, Space.Self);
				}
	}
}