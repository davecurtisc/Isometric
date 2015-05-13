using UnityEngine;
using System.Collections;

public class player_Movement : MonoBehaviour {

	//player movement vars
	public float speed = 1.0F;
	public float jumpSpeed = 4.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	//locking player rotation pos
	public float lock_Pos = 0;

	//jBox and pipe
	public bool touching_jBox;
	public GameObject jBox = GameObject.Find("jBox");

	public GameObject pipe;
	public static bool pipe_Turning;


	void Start(){

		touching_jBox = false;

		pipe_Turning = false;
	}

	void Update() {

		//find controller
		CharacterController controller = GetComponent<CharacterController> ();

		//lock character rotation
		controller.transform.rotation = Quaternion.Euler (lock_Pos, lock_Pos, lock_Pos);

		if (controller.isGrounded) {

			//print("Horiz move: " + Input.GetAxis("Horizontal"));
			//print("Vert move: " + Input.GetAxis("Vertical"));

			moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

			//jumping
			if (Input.GetButton ("Jump"))
				moveDirection.y = jumpSpeed;
			
		}

		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	


		//start jbox if its jumped on
		if (touching_jBox == true && Input.GetButton ("Jump")) {
		
			pipe_Turning = true;

			//pipe.transform.Rotate (0,50*Time.deltaTime,0);
		}
	}



	//trigger for box
	void OnTriggerEnter(Collider other){
		if (other.tag == "jBox") {
		
			print("touching the box");

			touching_jBox = true;

		}
	}

	void OnTriggerExit(Collider other){

		if (other.tag == "jBox") {
		
			touching_jBox = false;
		}
	}
}