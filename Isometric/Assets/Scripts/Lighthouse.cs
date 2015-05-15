using UnityEngine;
using System.Collections;

public class Lighthouse : MonoBehaviour {

	public int lockedX = 43;
	public int lockedZ = 297;

	public int speed = 30;

	public float Timer = 10;

	public Light lightouse_Spot;

	

	// Use this for initialization
	void Start () {

		//turn off lighthouse when game starts

		this.gameObject.SetActive (true);

		lightouse_Spot = gameObject.GetComponent<Light> ();

		lightouse_Spot.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		//timer countdown
		Timer -= Time.deltaTime;

		//print (Timer);

		if(Timer <0){

		lightouse_Spot.enabled = true;

		this.transform.Rotate(0, speed*Time.deltaTime, 0,Space.World); //rotates 50 degrees per second around y axis
	
		}
	}
}
