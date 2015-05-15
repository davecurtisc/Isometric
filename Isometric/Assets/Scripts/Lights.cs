using UnityEngine;
using System.Collections;

public class Lights : MonoBehaviour 
{
	public static Lights instance = null;
	public bool rotatable = false;
	private Light light;

	void Awake()
	{
		if(instance == null)
			instance = this;

		//light = GetComponent<Light>();
	}

	void Start()
	{
		//if(rotatable)
		// Start rotating co routine
	}

	public void TurnOnLight(bool active)
	{
		light.enabled = active;
	}

	// Rotate
}
