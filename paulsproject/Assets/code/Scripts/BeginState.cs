using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
	public class BeginState : IStateBase
	{
		public BeginState() //constructor
		{
			Debug.Log("Constructing BeginState...");
		}
		public void StartUpdate()
		{

		}

		public void ShowIt()
		{

		}
	}
	
}
