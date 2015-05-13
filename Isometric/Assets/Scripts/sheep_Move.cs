using UnityEngine;
using System.Collections;

public class sheep_Move : MonoBehaviour {

	public bool touching_Wall;

	public Vector3 direction;

	private float startYValue;

	// Use this for initialization
	void Awake()
	{
		//startYValue = this.transform.position.y;

		//direction = new Vector3 (Random.Range (-8.0f, -4.7f), startYValue, Random.Range (0f, 3.5f));
	}

	void Start () {

		touching_Wall = false;

		startYValue = this.transform.position.y;

	
	}
	
	// Update is called once per frame
	void Update () 
	{

		//direction = new Vector3 (Random.Range (-8.0f, -4.7f), startYValue, Random.Range (0f, 3.5f));

		transform.Translate (direction * Time.deltaTime / 2);

		//print (startYValue);
		
	}
			//trigger for box
	void OnTriggerEnter(Collision other)
	{
		if (other.gameObject.tag == "Wall") 
		{
			print("sheep touched a wall");
			//touching_Wall = true;

			direction = new Vector3(Random.Range(-8.0f, -4.7f),startYValue,Random.Range(0f, 3.5f));
		}
	}
		
	void OnTriggerExit(Collision other){
			
		if (other.gameObject.tag == "Wall") {
				
			//touching_Wall = false;
			print("collide");

		}
	}


}
