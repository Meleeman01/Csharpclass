using UnityEngine;
using System.Collections.Generic;

public class PickUpItem : MonoBehaviour {
	
	public Transform player;
	public List<Collider> items;
	public int itemCount = 0, currentItem;
	bool pickUp;
	
	// if you press 'Q' it will let go of the last item.
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q) && itemCount>0) 
		{

			itemCount--;
			ShowCurrentItem(itemCount);
			items[itemCount].transform.parent = null;
			items[currentItem].gameObject.tag="Item";
			items.RemoveAt(itemCount);
			ShowCurrentItem(itemCount-1);
			
		}
		if(itemCount<1)
		{
			Debug.Log("You have No Items to drop!");
		}

		// show only 1 item
		if(Input.GetKeyDown(KeyCode.Alpha1))
			{ShowCurrentItem(0);}
		else if(Input.GetKeyDown(KeyCode.Alpha2))
			{ShowCurrentItem(1);}
		else if(Input.GetKeyDown(KeyCode.Alpha3))
			{ShowCurrentItem(2);}
		else if(Input.GetKeyDown(KeyCode.Alpha4))
			{ShowCurrentItem(3);}
		else if (Input.GetKeyDown(KeyCode.Alpha5))
			{ShowCurrentItem(4);}
		else if (Input.GetKeyDown(KeyCode.Alpha6))
			{ShowCurrentItem(5);}
		else if (Input.GetKeyDown(KeyCode.Alpha7))
			{ShowCurrentItem(6);}
		else if (Input.GetKeyDown(KeyCode.Alpha8))
			{ShowCurrentItem(7);}
		else if (Input.GetKeyDown(KeyCode.Alpha9))
			{ShowCurrentItem(8);}
		else if (Input.GetKeyDown(KeyCode.Alpha0))
			{ShowCurrentItem(9);}					
		else 
			{Debug.Log("That number is not supported.");}
	}

	// this displays a text box saying "Press 'E'".
	void OnGUI() 
	{
		if(pickUp) 
		{
			GUI.Box(new Rect(Screen.width/2,Screen.height/2, 75,25), "Press 'E'");
		}
		if(itemCount<1)
		{
			
			GUI.Box(new Rect(Screen.width/2+200,Screen.height/2,200,50), "No Items to Drop!");

		}
	}

	// if an object tagged 'Item' is inside the player sphere collider
	// if the player presses 'E' then it changes the parent to the player and adds the item to a list.
	void OnTriggerStay(Collider other) {
		if(other.gameObject.tag == "Item") {
			//Debug.Log("Press E to Pick up!");
			pickUp = true;
			if(Input.GetKeyDown(KeyCode.E)) {
				other.transform.SetParent(player);
				other.gameObject.tag="ItemBagged";
				other.transform.position=player.position+new Vector3(0,0,1); 
				items.Add(other);

				ShowCurrentItem(itemCount);
				itemCount++;

			}
		}
		

	}



	// this turns off the OnGUI text display when the item is outside of the player's reach.
	void OnTriggerExit () {
		pickUp = false;
	}

	public void ShowCurrentItem(int itemNum) {
		currentItem = itemNum;
		// set only 1 item to active.
		for(int i = 0; i < items.Count; i++) {
			if(i == itemNum){
				items[i].gameObject.SetActive(true);
				}

			else{
				items[i].gameObject.SetActive(false);
				}
		}
	}
}