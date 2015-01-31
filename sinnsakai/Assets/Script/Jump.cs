using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	
	
	enum State
	{
		NORMAL,
		JUMP
	}
	float y = 0.0f; //y軸
	float jumppower =  0.5f;//ジャンプ力
	float velocity_y = 0.0f;//y軸の速度
	bool jumpflag = false;

	public GameObject Gravity2;

	Gravity gravity2;
	// Use this for initialization
	void Start () {
		Gravity2 = GameObject.Find ("Main Camera");
		gravity2 = Gravity2.GetComponent<Gravity>();
		velocity_y = jumppower;
	}
	 
	public GameObject Player;
	// Update is called once per frame
	void Update () {
		Player = GameObject.Find ("Player");
		//velocity_y = jumppower;

		if (Time.timeScale == 1) {


						if (Input.GetKey (KeyCode.Space) && jumpflag == false) {
				
								//rigidbody.AddForce(transform.up * jumppower, ForceMode.Impulse);
								jumpflag = true;
						}
			
						if (jumpflag == true) {
								if (gravity2.reveres == false) {
										y = velocity_y;
										velocity_y -= 0.05f;
								} 
								if (gravity2.reveres == true) {
										y = velocity_y;
										velocity_y += 0.05f;
								}
						}

						if (gravity2.reveres == false && velocity_y <= 0.0f) {
								velocity_y = 0.0f;
						}
						if (gravity2.reveres == true && velocity_y >= 0.0f) {
								velocity_y = 0.0f;
						}
						//Player.transform.position = (0, 0, 0, Space.World);
						transform.Translate (0, y, 0, Space.World);
				}
	}
	
	void OnCollisionEnter(Collision collision) {
				if (collision.gameObject.name == "floor") {
			velocity_y = jumppower;
			jumpflag = false;
			
			//velocity_y = 0.0f;
			//rigidbody.useGravity = false;
			rigidbody.useGravity = true;
		}
		if (collision.gameObject.name == "backfloor")
		{
			velocity_y = -jumppower;
			jumpflag = false;
			
			//velocity_y = 0.0f;
			//rigidbody.useGravity = false;
			rigidbody.useGravity = true;
		}         

		}
}