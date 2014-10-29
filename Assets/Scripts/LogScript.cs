using UnityEngine;
using System.Collections;

public class LogScript : MonoBehaviour 
{
	private float logspeedUp = 0.0065f;
	private float logspeed = 0.003f;
	private int timerr = 0;

	void Update () 
	{
		timerr++;
		if (gameObject.tag == "logup")
		{
			transform.Translate (Vector3.right * logspeedUp);
		}
		if (gameObject.tag == "log")
		{
			transform.Translate (Vector3.right * logspeed);
		}
		if (timerr >= 1000)
		{
			Destroy(this.gameObject);
		}
	}
}
