using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Inventory : MonoBehaviour {

	public List <GameObject> Items = new List<GameObject>(10);



	// Use this for initialization
	void Start () {
	Items.Add(GameObject.Find("Pen"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	


}
