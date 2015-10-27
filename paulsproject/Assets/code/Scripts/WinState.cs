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
			if(Application.loadedLevelName != "Scene0")
			{
				Application.LoadLevel("Scene0");
			}
			
		}


		public void StateUpdate()
		{
			if(Input.GetKeyUp(KeyCode.Space))
			{
				 			
				manager.SwitchState (new PlayStateScene2 (manager));
				
			}
		}

		public void ShowIt()
		{
			//if(GUI.Button(new Rect((Screen.width/2)-75,(Screen.height/2)-50,150,100), "You won! Play Again?"))
			//{
				
			//	manager.SwitchState (new BeginState (manager));
			//	Application.LoadLevel("beginningscene");

			//}


			Debug.Log("In WinState");
		}
	}
	
}
