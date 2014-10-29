using UnityEngine;
using System.Collections;

public class CarSpawnLU : MonoBehaviour {

	public GameObject cars;
	public Transform spawn;
	private int timer = 0;
	
	void Update ()
	{
		timer++;
		if(timer >= 210)
		{
			Instantiate(cars, spawn.position, spawn.rotation);
			timer = 0;
		}
	}
}