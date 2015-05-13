using UnityEngine;
using System.Collections;

public class wheel_Turn : MonoBehaviour {

	public bool is_Turning;

	private float wheel_X = -.35f;

	private static bool Turning;

	// Use this for initialization
	void Start () {
		print (wheel_X);

		this.gameObject.transform.position = new Vector3 (wheel_X, 4, -1);

		is_Turning = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Turning = player_Movement.pipe_Turning;

		if (Turning == true) {
		
			//print("Pipe should be activated");

			this.gameObject.transform.Rotate (0,50*Time.deltaTime,0); //rotates 50 degrees per second around x axis

			is_Turning = true;
		}
	
	}
}
