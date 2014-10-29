using UnityEngine;
using System.Collections;

public class CarMoving : MonoBehaviour {
	
	public float carSpeedRU = 0.007f;
	public float carSpeedRD = 0.005f;
	public float carSpeedLD = 0.005f;
	public float carSpeedLU = 0.007f;
	
	void Update () 
	{
		if (gameObject.name == "cars_3" || gameObject.name == "cars_3(Clone)") 
		{
			this.transform.Translate (Vector3.left * carSpeedRU);
		}
		if (gameObject.name == "cars_0" || gameObject.name == "cars_0(Clone)") 
		{
			this.transform.Translate (Vector3.left * carSpeedRD);
		}
		if (gameObject.name == "cars_1" || gameObject.name == "cars_1(Clone)") 
		{
			this.transform.Translate (Vector3.right * carSpeedLD);
		}
		if (gameObject.name == "cars_4" || gameObject.name == "cars_4(Clone)") 
		{
			this.transform.Translate (Vector3.right * carSpeedLU);
		}
	}
}
