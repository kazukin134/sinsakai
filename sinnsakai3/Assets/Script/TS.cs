using UnityEngine;
using System.Collections;

public class TS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public bool table_sides = true;
	public bool back_sides = false;
	public bool hit = false;
	public bool moment = false;
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision) {
				if (collision.gameObject.name == "Player") {
			if(moment == false){
						hit = true;
			}
				}
						if (hit == true && back_sides == true) {
								table_sides = true;
								back_sides = false;
								moment = true;
								hit = false;
						}
			else
				if(hit == true && table_sides == true)
			{
				back_sides = true;
				table_sides = false;
				moment = true;
				hit = false;
			}

				
		}
}
