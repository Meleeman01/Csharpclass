using UnityEngine;
using System.Collections;

public class gunscript : MonoBehaviour 
{
	public GameObject P90;
	public Rigidbody projectile;

	
	public bool aiming=false;

		// Use this for initialization
		void Start ()
    	{
		 P90= GameObject.Find("P90");
		 GameObject.Find("box");
		}
		
		// Update is called once per frame
		void Update ()
		{
			if(Input.GetMouseButtonDown(0))
			{
				
				
				Debug.Log("pew! pew!");
				FireWeapon();

				
				
				
				
			}	

			if(Input.GetMouseButtonDown(1))
			{
				Debug.Log("Aim!...");
				aiming=true;
				{
					if(aiming==true)
					{
						ShoulderWeapon();
					}
					else
					{
						
					}
				}

			}
		}


void ShoulderWeapon ( )
{
	

	
}

void FireWeapon ()
{
	Rigidbody clone;
	clone= Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
	clone.transform.Translate(0,.3f, 1.6f);
	clone.velocity=transform.TransformDirection(Vector3.forward*50);
}

}