using UnityEngine;
using System.Collections;

public class Grip : MonoBehaviour {
	enum Direction{
		Front,
		Back,
		Right,
		left
	}
	Direction direction;
	public GameObject Player;
	public GameObject Block;

	float Player_x = 0.0f;
	float Player_z = 0.0f;
	float Player_y = 0.0f;
	float Block_x = 0.0f;
	float Block_z = 0.0f;
	float Block_y = 0.0f;
	bool hit_grip = false;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player");
		Block = GameObject.Find ("Block");
	}
	
	// Update is called once per frame
	void Update () {
		Player_x = Player.transform.position.x;
		Player_z = Player.transform.position.z;
		Player_y = Player.transform.position.y;
		Block_x = Block.transform.position.x;
		Block_z = Block.transform.position.z;
		Block_y = Block.transform.position.y;

		switch(direction)
		{
		case Direction.Front:
			if (Input.GetKey (KeyCode.G)&&hit_grip == true) {
				Block.transform.position = new Vector3(Player_x,Player_y,Player_z+1.3f);
			}
			break;
		case Direction.Back:
			if (Input.GetKey (KeyCode.G)&&hit_grip == true) {
				Block.transform.position = new Vector3(Player_x,Player_y,Player_z-1.3f);
			}
			break;
		case Direction.left:
			if (Input.GetKey (KeyCode.G)&&hit_grip == true) {
				Block.transform.position = new Vector3(Player_x-1.01f,Player_y,Player_z);
			}
			break;
		case Direction.Right:
			if (Input.GetKey (KeyCode.G)&&hit_grip == true) {
				Block.transform.position = new Vector3(Player_x+1.01f,Player_y,Player_z);
			}
			break;
		}

				if (Input.GetKeyUp (KeyCode.G)) {
			hit_grip = false;
				}
	}

	void OnCollisionStay(Collision collision) {
				if (collision.gameObject.name == "Player") {

			if(Player_x > Block_x+1.0f)
			{
				direction = Direction.left;
			}else
			if(Player_x < Block_x-1.0f)
			{
				direction = Direction.Right;
			}else

			if(Player_z > Block_z+1.0f)
			{
				direction = Direction.Back;
			}else

			if(Player_z < Block_z-1.0f)
			{
				direction = Direction.Front;
			}


				hit_grip = true;

					}
			}
	void OnCollisionExit(Collision collision){
		if (collision.gameObject.name == "Player") {
			
						hit_grip = false;
				}
	}
}
