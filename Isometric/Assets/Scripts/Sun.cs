using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour 
{

	public Light directional;
	
	public float timer = 10;

	void Awake()
	{
		directional = gameObject.GetComponent<Light>();
	}
	void Start () 
	{
		StartCoroutine("SunFade");
	}

	private IEnumerator SunFade()
	{
		float rate = 0.1f * Time.deltaTime;

		yield return new WaitForSeconds (5.0f);

		while(directional.intensity > 0)
		{
			directional.intensity -= rate;

			yield return null;
		}

		StartCoroutine("SunRise");
	}

	private IEnumerator SunRise()
	{
		float rate = 0.1f * Time.deltaTime;

		yield return new WaitForSeconds (5.0f);

		while(directional.intensity < 0.7f)
		{
			directional.intensity += rate;
			
			yield return null;
		}

		StartCoroutine("SunFade");
	}
}
