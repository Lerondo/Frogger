using UnityEngine;
using System.Collections;

public class CarSpawnRU : MonoBehaviour {

	public GameObject cars;
	public Transform spawn;
	private int timer = 0;
	
	void Update ()
	{
		timer++;
		if(timer >= 220)
		{
			Instantiate(cars, spawn.position, spawn.rotation);
			timer = 0;
		}
	}
}