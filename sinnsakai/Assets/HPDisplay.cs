using UnityEngine;
using System.Collections;

public class HPDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public GameObject MainCamera;
	public GameObject HP;
	float reversal = 0.0f;
	float hp_y = 0.0f;
	// Update is called once per frame
	void Update () {
	
		MainCamera = GameObject.Find ("Main Camera");
		HP = GameObject.Find ("HP");
		reversal = MainCamera.transform.localRotation.z;
		hp_y = HP.transform.localPosition.y;
		if (reversal >= 1.0) {
			hp_y = -5.0f;
				}
	}
}
