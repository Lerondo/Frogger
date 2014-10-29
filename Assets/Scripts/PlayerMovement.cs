using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float movelr = 0.16f;
	public float moveud = 0.19f;

	public int PlayerTimer = 0;
	public GameObject Player;
	public Transform playerspawn;

	private Animator anim;
	public int lives = 3;

	private bool turtleCol = false;
	private bool logCol = false;
	private bool logUpCol = false;

	public bool deathh = false;
	private bool gameover;
	private int DeathTimer = 0;
	private BoxCollider2D boxcoll;

	void Start()
	{
		anim = GetComponent<Animator> ();
		gameover = false;
		boxcoll = GetComponent<BoxCollider2D> ();
	}

	void Update ()
	{
		Debug.Log (logCol);
		Debug.Log (turtleCol);
		Debug.Log (gameover);
		if (gameover == false) 
		{
			Debug.Log (lives);
			if (deathh == false)  
			{
				if (Input.GetKeyDown (KeyCode.A)) 
				{
					transform.Translate (Vector3.left * movelr);
				}
				if (Input.GetKeyDown (KeyCode.D)) 
				{
					transform.Translate (Vector3.right * movelr);
				}
				if (Input.GetKeyDown (KeyCode.W)) 
				{
					transform.Translate (Vector3.up * moveud);
				}
				if (Input.GetKeyDown (KeyCode.S)) 
				{
					transform.Translate (Vector3.down * moveud);
				}
			}
			if (PlayerTimer >= 1) 
			{
				PlayerTimer++;
				if (PlayerTimer >= 220) 
				{
					anim.SetBool ("isDead", false);
					PlayerTimer = 0;
					deathh = false;
					if (lives >= 0) 
					{
						transform.position = playerspawn.position;
						boxcoll.enabled = true;
					}
				}
			}
			if (lives == 0 && deathh == true) 
			{
				gameover = true;
			}

			if (turtleCol == true) 
			{
				transform.Translate(Vector3.left * 0.005f);
			}
			if (logCol == true) 
			{
				transform.Translate(Vector3.right * 0.003f);
			}
			if (logUpCol == true) 
			{
				transform.Translate(Vector3.right * 0.0065f);
			}
		}
		if (gameover == true) 
		{
			DeathTimer++;
			if (DeathTimer >= 200) 
			{
				Application.LoadLevel("MainMenu");
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (gameover == false) 
		{
			//if(deathh = false)
			//{
				if (other.gameObject.tag == "cars") 
				{
					PlayerTimer++;
					deathh = true;
					anim.SetBool ("isDead", true);
					Debug.Log ("why wont you work ;_;");
					lives -= 1;
					boxcoll.enabled = false;
				}
			//}
		}
		if (other.gameObject.tag == "log") 
		{
			logCol = true;
		}
		if (other.gameObject.tag == "logup") 
		{
			logUpCol = true;
		}
		if (other.gameObject.tag == "turtle") 
		{
			turtleCol = true;
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		logCol = false;
		logUpCol = false;
		turtleCol = false;
	}
}
