	using UnityEngine;
	using System.Collections;
	
	public class Instantiate : MonoBehaviour {
		
		public Rigidbody projectile;
		
	void start()
	{
	
	}
		void FixedUpdate () {

		}
		
		public void Shoot() { 
			Rigidbody clone;
			clone = Instantiate(projectile, transform.position,transform.rotation) as Rigidbody;
		clone.isKinematic = false;
			clone.transform.Translate(0,.3f, 1.6f);
			
			clone.velocity = transform.TransformDirection(Vector3.forward * 50);
		}
	}

