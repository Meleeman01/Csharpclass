using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
	public class BeginState : IStateBase
	{
		private StateManager manager;	

		public BeginState(StateManager managerRef) //constructor
		{
			manager=managerRef;
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
