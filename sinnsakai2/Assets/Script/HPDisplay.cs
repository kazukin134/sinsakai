using UnityEngine;
using System.Collections;

public class HPDisplay : MonoBehaviour {

	public int remaining_machine = 3;
	public GameObject Player;

	Respawn respawn;
	void Start () {
		Player = GameObject.Find ("Player");
		respawn = Player.GetComponent<Respawn> ();
	}

	void Update () {


		}

	void OnGUI(){
		if (respawn.respawn_height == true) {
			remaining_machine -= 1;
		}

		if (remaining_machine == 3) {
						GUI.Label (new Rect (200, 300, 200, 200), "残り3");
				} else
			if (remaining_machine == 2) {
			GUI.Label (new Rect (200, 200, 200, 200), "残り2");
				} else
			if (remaining_machine == 1) {
			GUI.Label (new Rect (200, 100, 200, 200), "残り1");
				} else
			if (remaining_machine <= 0) {
			GUI.Label (new Rect (200, 0, 200, 200), "残り0");
				}
		}

}
