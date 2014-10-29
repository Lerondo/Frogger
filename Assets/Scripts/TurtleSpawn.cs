using UnityEngine;
using System.Collections;

public class TurtleSpawn : MonoBehaviour {

	public GameObject turtles;
	public Transform spawn;
	private int timer = 0;
	
	void Update ()
	{
		timer++;
		if(timer >= 200)
		{
			Instantiate(turtles, spawn.position, spawn.rotation);
			timer = 0;
		}
	}
}
