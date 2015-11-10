using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	public float cameraHeight =5.0f;
	public float cameraDistance=5.0f;

	private Transform playerPosition;
	private float playerRotationY;
	private float playerRotationX;
	
	// Use this for initialization
	void Start () 
	{
		playerPosition=GameObject.Find("Car").transform;

		playerRotationX=GameObject.Find("firstpersoncam").transform.rotation.eulerAngles.x;
		playerRotationY=GameObject.Find("firstpersoncam").transform.rotation.eulerAngles.y;


	}
	
	void Update()
	{
		playerRotationX=GameObject.Find("firstpersoncam").transform.rotation.eulerAngles.x;
		playerRotationY=GameObject.Find("firstpersoncam").transform.rotation.eulerAngles.y;

		
	}
		
	// Update is called once per frame
	void LateUpdate () 
	{
		
			transform.position=playerPosition.position + new Vector3(-cameraDistance, cameraHeight, cameraDistance);
			
		transform.LookAt(playerPosition);


	
		
	}
}
