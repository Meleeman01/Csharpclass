using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
	public class WinState : IStateBase
	{
		private StateManager manager;	

		public WinState(StateManager managerRef) //constructor
		{
			manager=managerRef;
			Debug.Log("WinState constructed.");
			
		}


		public void StateUpdate()
		{
			if(Input.GetKeyUp(KeyCode.Space))
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
