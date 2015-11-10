using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {

	public float speed=16.0f, rotationSpeed= 5.5f;

	private float playerRotationX;
	private float playerRotationY;
	private float playerRotationZ;
	// Use this for initialization
	void Start () 
	{
		playerRotationX=GameObject.Find("Car").transform.rotation.eulerAngles.x;
		playerRotationY=GameObject.Find("Car").transform.rotation.eulerAngles.y;
		playerRotationZ=GameObject.Find("Car").transform.rotation.eulerAngles.z;
	}
	
	// Update is called once per frame
	void Update () {
		playerRotationX=GameObject.Find("Car").transform.rotation.eulerAngles.x;
		playerRotationY=GameObject.Find("Car").transform.rotation.eulerAngles.y;

		if(this.transform.rotation.eulerAngles.z >= 180 ||this.transform.rotation.eulerAngles.z<=-180) 
		{
		
			Debug.Log("flipped over");

			
			transform.eulerAngles = new Vector3(playerRotationX,playerRotationY,0);
		}
		if(Input.GetKeyDown(KeyCode.F))
			{
				transform.eulerAngles = new Vector3(playerRotationX,playerRotationY,0);
			}
	
	}

	void FixedUpdate(){
		float foreAndAft = Input.GetAxis ("Vertical") * speed;
		float rotation =
			Input.GetAxis ("Horizontal") * rotationSpeed;
		GetComponent<Rigidbody> ().AddRelativeForce (foreAndAft, 0, 0);
		GetComponent<Rigidbody> ().AddTorque (0, rotation, 0);
	
	}
}
