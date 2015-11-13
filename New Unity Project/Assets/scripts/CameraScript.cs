using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	public float cameraHeight =5.0f;
	public float cameraDistance=5.0f;


	private Transform playerPosition;
	public float cameraRotationX;
	public float carRotationX;
	private float Xlocked=5;
	private Vector3 carPosition;
	
	// Use this for initialization
	void Start () 
	{
		playerPosition=GameObject.Find("Car").transform;



	}
	
	void Update()
	{
		

		//find teh car's rotation.
		carRotationX=GameObject.Find("Car").transform.rotation.eulerAngles.y; //set car's rotation x to a float variable.
		cameraRotationX=GameObject.Find("firstpersoncam").transform.rotation.eulerAngles.y; 
		

		
	}
		
	// Update is called once per frame
	void LateUpdate () 
	{
		//find teh car's rotation.
		carRotationX=GameObject.Find("Car").transform.rotation.eulerAngles.y; //set car's rotation x to a float variable.
		cameraRotationX=GameObject.Find("firstpersoncam").transform.rotation.eulerAngles.y;
		cameraRotationX=carRotationX;
		
		

		
		transform.position=playerPosition.position +new Vector3(cameraDistance, cameraHeight,cameraDistance);
		
		transform.LookAt(playerPosition);

		transform.RotateAround(playerPosition.position,Vector3.up,cameraRotationX-130);

	}
}
