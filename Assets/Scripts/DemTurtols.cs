using UnityEngine;
using System.Collections;

public class DemTurtols : MonoBehaviour {
	
	public float turtleSpeed = 0.005f;
	private int timer = 0;

	void Update () 
	{
		transform.Translate (Vector3.left * turtleSpeed);
		timer ++;
		if (timer >= 520) 
		{
			Destroy(this.gameObject);
		}
	}
}
