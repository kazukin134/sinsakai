using UnityEngine;
using System.Collections;

public class gr : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	float h = 0.0f;
	// Update is called once per frame
	void Update () {
		if (h < 90) {

						h += 2.0f;

				}
		transform.Rotate(new Vector3(0, 0,h), Space.World);
	}
}
