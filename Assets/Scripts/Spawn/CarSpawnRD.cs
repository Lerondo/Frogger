using UnityEngine;
using System.Collections;

public class CarSpawnRD : MonoBehaviour {

	public GameObject cars;
	public Transform spawn;
	private int timer = 0;
	
	void Update ()
	{
		timer++;
		if(timer >= 200)
		{
			Instantiate(cars, spawn.position, spawn.rotation);
			timer = 0;
		}
	}
}