using UnityEngine;
using System.Collections;

public class LookatPlayer : MonoBehaviour {

	private Transform playerPosition;
	// Use this for initialization
	void Start () 
	{
		playerPosition=GameObject.Find("Car").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.LookAt(playerPosition);
	}
}
