using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class objectscript : MonoBehaviour {

private Transform playerPosition;
public Inventory listAdd;
public GameObject object1;



	// Use this for initialization
void Start () {
		playerPosition=GameObject.Find("Capsule").transform;
		listAdd=GetComponent<Inventory>();
		object1=GameObject.Find(gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
		 
 	listAdd=GetComponent<Inventory>();
		object1=GameObject.Find(gameObject.name);
   
 }
	
	
void OnTriggerEnter()
	{
		if(gameObject.tag=="Item")
		{
			Debug.Log("Item touched");
			Debug.Log(object1+"is the object's name.");
			
			AddToList(listAdd);
			

			
		}
		
	}

	public void AddToList(Inventory listAdd){
			Debug.Log(gameObject.name);
			listAdd.Items.Add(new GameObject(gameObject.name));
			gameObject.tag="ItemBagged";
			transform.position=playerPosition.position + new Vector3(5,5,5);
			
	}
}
