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
	public bool jumpflag = false;
	public bool jumpstart_up = false;
	public GameObject Gravity2;
	public GameObject Player;
	public GameObject Stairs;

	Gravity gravity2;
	// Use this for initialization
	void Start () {
		Gravity2 = GameObject.Find ("Main Camera");
		gravity2 = Gravity2.GetComponent<Gravity>();
		velocity_y = jumppower;
		Player = GameObject.Find ("Player");
		Stairs = GameObject.Find ("Stairs");
	}
	 
	public void Update () {


		if (Time.timeScale == 1) {


						if (Input.GetKey (KeyCode.Space) && jumpflag == false) {
				
								jumpflag = true;
							jumpstart_up = true; 
						}else
			
						if (jumpstart_up == true && jumpflag == true) {
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
			jumpstart_up = false;
			rigidbody.useGravity = true;
		}else
		if (collision.gameObject.name == "backfloor")
		{
			velocity_y = -jumppower;
			jumpflag = false;
			jumpstart_up = false;
			rigidbody.useGravity = true;
		}else         

		if (collision.gameObject.name == "Stairs")
		{
			if(Player.transform.position.y+0.5f >= Stairs.transform.position.y+1f){
			velocity_y = jumppower;
			jumpflag = false;
			jumpstart_up = false;
			rigidbody.useGravity = true;
			}
		}else
			if (collision.gameObject.name == "Goolfloor")
		{
			velocity_y = jumppower;
			jumpflag = false;
			jumpstart_up = false;
			rigidbody.useGravity = true;
		}
		}
}