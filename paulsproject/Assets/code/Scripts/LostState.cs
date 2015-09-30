using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
	public class LostState : IStateBase
	{
		private StateManager manager;	

		public LostState(StateManager managerRef) //constructor
		{
			manager=managerRef;
			Debug.Log(" LostState constructed.");
			
		}


		public void StateUpdate()
		{
			if (Input.GetKeyUp(KeyCode.Space))
			{
				manager.SwitchState (new BeginState (manager));
				Application.LoadLevel("BeginningScene");
			}
		}

		public void ShowIt()
		{

		}
	}
	
}
