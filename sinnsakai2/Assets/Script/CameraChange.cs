using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

	public GameObject Maincamera;
	public GameObject Subjectivitycamera;

	CameraMove maincamera;
	Subjectivity subjectivitycamera;

	public enum CameraTurn{
		Main,
		Sub
	}

	public CameraTurn cameraturn;
	// Use this for initialization
	void Start () {
		Maincamera = GameObject.Find("Main Camera");
		maincamera = Maincamera.GetComponent<CameraMove> ();
		Subjectivitycamera = GameObject.Find("SubjectivityCamera");
		subjectivitycamera = Subjectivitycamera.GetComponent<Subjectivity> ();
	}

	// Update is called once per frame
	public void Update () {
	if (Input.GetKeyDown (KeyCode.C)) {
			if(cameraturn == CameraTurn.Main){
				cameraturn = CameraTurn.Sub;
			}else
				if(cameraturn == CameraTurn.Sub){
				cameraturn = CameraTurn.Main;
			}

				}

	 switch(cameraturn)
		{
		case CameraTurn.Main:
			
			Maincamera.camera.depth = 1;
			subjectivitycamera.camera.depth = 0;
			break;
		case CameraTurn.Sub:
			Maincamera.camera.depth = 0;
			subjectivitycamera.camera.depth = 1;
			break;
		}
	}
}
