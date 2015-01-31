using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	public GameObject reveresb;
	public GameObject reveresb2;
	// Use this for initialization
	TS reveresbox;
	TS reveresbox2;

	void Start () {


	}
	public GameObject MainCamera;

	float rotation_z = 0.0f;
    public bool reveres = false;


	// Update is called once per frame
	void Update () {

		if (Time.timeScale == 1) {

						reveresbox = reveresb.GetComponent<TS> ();
						reveresbox2 = reveresb2.GetComponent<TS> ();
						reveresb = GameObject.Find ("Reveres2");
						reveresb2 = GameObject.Find ("Reveres");
						//reveresbox2 = GameObject.Find("Reveres2");

						if (reveresbox.back_sides == true && reveres == false && reveresbox.moment == true  
								|| reveresbox2.back_sides == true && reveres == false && reveresbox2.moment == true) {
								rotation_z += 2.0f;
								reveresbox2.back_sides = true;
								reveresbox2.table_sides = false;
						}
	
						if (reveresbox.table_sides == true && reveres == true && reveresbox.moment == true
								|| reveresbox2.table_sides == true && reveres == true && reveresbox2.moment == true) {
								rotation_z -= 2.0f;
								reveresbox.back_sides = false;
								reveresbox.table_sides = true;
						}

						if (rotation_z == 180.0f) {
								//transform.Rotate(new Vector3(0, 0,180), Space.World);
								reveres = true;
								reveresbox.moment = false;

						} else
			if (rotation_z == 0.0f) {
								reveres = false;
								reveresbox2.moment = false;
						}

						if (reveres == true) {
								Physics.gravity = new Vector3 (0, 9.81f, 0);

						} else
			if (reveres == false) {
								Physics.gravity = new Vector3 (0, -9.81f, 0);
						}

						MainCamera = GameObject.Find ("Main Camera");
						//Quaternion.AngleAxis(-30,-Vector3.forward);
						//		}

						MainCamera.transform.Rotate (0.0f, 0.0f, rotation_z);

				}
	}


}
