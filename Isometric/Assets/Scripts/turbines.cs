using UnityEngine;
using System.Collections;

public class turbines : MonoBehaviour {

	public int speed = 5;


	// Use this for initialization
	void Start () {
	
		//this.gameObject.transform.position = new Vector3 (-4, 2, -1);
	}
	
	// Update is called once per frame
	void Update () {

		//play animation
		this.gameObject.transform.Rotate (0,50*Time.deltaTime,0); //rotates 50 degrees per second around y axis
	
	}
}
