using UnityEngine;
using System.Collections;




public class Move : MonoBehaviour {
	
	
	
	public float x = 0.0f;
	public float z = 0.0f;
	float speed = 0.05f;

	public GameObject Gravity1;
	//public GameObject Pause1;


	Gravity gravity;
	//Pause pause;

	// Use this for initialization
	void Start () {
		Gravity1 = GameObject.Find ("Main Camera");
		//Pause1 = GameObject.Find("Main Camera");
		gravity = Gravity1.GetComponent<Gravity>();
		//pause = Pause1.GetComponent<Pause> (); 
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.timeScale == 1) {

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
								z = speed;
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