using UnityEngine;
using System.Collections;

public class checkpointscript : MonoBehaviour {

	

	// Use this for initialization
	void Start () 
	{
		gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(){
		if(gameObject.tag=="Checkpoint")
		{
			Destroy(gameObject);
			
		}
	}
}
