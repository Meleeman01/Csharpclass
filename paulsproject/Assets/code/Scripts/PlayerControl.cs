using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	
	public Renderer rend;
	public float setupSpinSpeed=50.0f;
	public float speed=16.0f;
	public float rotationSpeed=3.0f;
	public float hoverPower=3.5f;
	public Rigidbody projectile;

	public Color red= Color.red;
	public Color blue= Color.blue;
	public Color green= Color.green;
	public Color yellow= Color.yellow;
	public Color white= Color.white;

	private GameData gameDataRef;

	// Use this for initialization
	void Start () 
	{
	gameDataRef=GetComponent<GameData>();
	}
	
	// Update is called once per frame
	public void FixedUpdate () 
	{
		float foreAndAft = Input.GetAxis ("Vertical") * speed;
		float rotation =
			Input.GetAxis ("Horizontal") * rotationSpeed;
		GetComponent<Rigidbody> ().AddRelativeForce (foreAndAft, 0, 0);
		GetComponent<Rigidbody> ().AddTorque (0, rotation, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="GoodOrb")
		{
			gameDataRef.score+=1;
			Destroy(other.gameObject);
		}
	}

	void OnCollisionEnter(Collision collidedwith)
	{
		if(collidedwith.gameObject.tag=="BadOrb")
		{
			gameDataRef.playerLives -=1;
			Destroy(collidedwith.gameObject);
		}


	}

	public void FireEnergyPulse()
	{
		Rigidbody clone;
		clone= Instantiate(projectile,transform.position, transform.rotation) as Rigidbody;
		clone.transform.Translate(0,.5f, 2.1f);
		clone.velocity=transform.TransformDirection(Vector3.forward*50);
	}
	


	public void PickedColor (Color playerColor)
	{
		rend=GetComponent<Renderer>();
		rend.enabled=true;
		
		rend.material.color=playerColor;
		
	}
}
