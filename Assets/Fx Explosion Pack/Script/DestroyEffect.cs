using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour
{

	public float timeLeft = 1.5f;
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C))
		   Destroy(transform.gameObject);
	
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0.0f)
		{
			Destroy(this.gameObject);
		}
	}
}
