using UnityEngine;
using System.Collections;

public class test5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
				if (GUI.Button (new Rect (10, 20, 100, 200), "Click")) {
						Application.LoadLevel ("Main");
				}
		}


}
