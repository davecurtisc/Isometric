using UnityEngine;
using System.Collections;

public class Lhouse_Red : MonoBehaviour {

	public Light lightouse_Point;

	public float Timer = 10;

	// Use this for initialization
	void Start () {

		lightouse_Point = gameObject.GetComponent<Light> ();
		
		lightouse_Point.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Timer -= Time.deltaTime;
		
		//print (Timer);
		
		if(Timer <0){
			
			lightouse_Point.enabled = true;
			
			//this.transform.Rotate(0, speed*Time.deltaTime, 0,Space.World); //rotates 50 degrees per second around y axis
			
		}
	}
}
