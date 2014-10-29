using UnityEngine;
using System.Collections;

public class carDespawns : MonoBehaviour {
	private int timer = 0;

	void Update()
	{
		timer ++;
		if (timer >= 500) 
		{
			Destroy (this.gameObject);
		}
	}
}
