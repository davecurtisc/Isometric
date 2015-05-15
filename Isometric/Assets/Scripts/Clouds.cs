using UnityEngine;
using System.Collections;

public class Clouds : MonoBehaviour {

	public int speed = 10;

	public float CloudY = 3.76f;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		this.gameObject.transform.position = new Vector3 (this.transform.position.x * Time.deltaTime, CloudY, 0);
	
	}
}
