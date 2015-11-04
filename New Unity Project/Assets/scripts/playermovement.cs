using UnityEngine;
using System.Collections;

public class playermovement : MonoBehaviour {

	public float speed=16.0f, rotationSpeed= 5.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.rotation.eulerAngles.z>=180||transform.rotation.eulerAngles.z<=-180) 
		{
			Debug.Log("flipped over");
			transform.eulerAngles = new Vector3(0,0,0);
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
