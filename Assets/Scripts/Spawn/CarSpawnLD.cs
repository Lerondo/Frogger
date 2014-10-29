using UnityEngine;
using System.Collections;

public class CarSpawnLD : MonoBehaviour {

	public GameObject cars;
	public Transform spawn;
	private int timer = 0;
	
	void Update ()
	{
		timer++;
		if(cars.gameObject.name == "log")
		{
			if (timer >= 350) 
			{
				Instantiate(cars, spawn.position, spawn.rotation);
				timer = 0;
			}
		}else if (timer >= 220) 
		{
			Instantiate(cars, spawn.position, spawn.rotation);
			timer = 0;
		}
	}
}