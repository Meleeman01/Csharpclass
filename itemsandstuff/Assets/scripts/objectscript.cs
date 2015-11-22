using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class objectscript : MonoBehaviour {

private Transform playerPosition;
public Inventory listAdd;
private GameObject object1;


	// Use this for initialization
void Start () {
		playerPosition=GameObject.Find("Capsule").transform;
		listAdd=GetComponent<Inventory>();
		object1=GameObject.Find(this.gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		 
 
   
 }
	
	

	public void OnTriggerEnter()
	{
		if(gameObject.tag=="Item")
		{
			Debug.Log("Item touched");
			Debug.Log(object1+"is the object's name.");
			object1.name.Remove(0,1);
			Debug.Log(object1);
			listAdd.Items.Add(GameObject.Find("obbyy"));
			gameObject.tag="ItemBagged";
			transform.position=playerPosition.position + new Vector3(5,5,5);


		}
		
	}

	public void AddToList(){

	}
}
