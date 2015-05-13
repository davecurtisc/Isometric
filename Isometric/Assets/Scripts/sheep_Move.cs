using UnityEngine;
using System.Collections;

public class sheep_Move : MonoBehaviour {

	public bool touching_Wall;

	public Vector3 direction = new Vector3(1,0,0);

	// Use this for initialization
	void Start () {

		touching_Wall = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (direction * Time.deltaTime);

		if (touching_Wall == true) {
		
			direction *= -1;
		}


	
	}
			//trigger for box
	void OnTriggerEnter(Collider other){
		if (other.tag == "Wall") {
				
			print("sheep touched a wall");
				
			touching_Wall = true;
				
			}
		}
		
	void OnTriggerExit(Collider other){
			
		if (other.tag == "Wall") {
				
			touching_Wall = false;

			}
		}


}
