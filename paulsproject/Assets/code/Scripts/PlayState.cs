using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
	public class PlayState : IStateBase
	{
		private StateManager manager;	

		public PlayState(StateManager managerRef) //constructor
		{
			manager=managerRef;
			Debug.Log("PlayState constructed.");
			
		}


		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space))
			{
				manager.SwitchState (new WinState (manager));
			}
		}

		public void ShowIt()
		{

		}
	}
	
}
