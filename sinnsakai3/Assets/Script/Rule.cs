using UnityEngine;
using System.Collections;

public class Rule : MonoBehaviour {

	public bool rule = false;

	void Start () {
	
	}

	void Update () {
	if (Input.GetKeyDown (KeyCode.Return)) {
			rule = true;
				}
		if (rule == false) {
			Time.timeScale = 0;
				}else
		if (rule == true) {
			Time.timeScale = 1;
			GetComponent<Canvas>().enabled = false;
				}


	}
}
