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

			if(Application.loadedLevelName != "Scene0")
			{
				Application.LoadLevel("Scene0");
			}
			
		}


		public void StateUpdate()
		{
		
		}

		public void ShowIt()
		{
			/*if(GUI.Button(new Rect((Screen.width/2)-75,(Screen.height/2)-50,150,100), "You Lost. Play Again?"))
			{
				
				manager.SwitchState (new BeginState (manager));
				Application.LoadLevel("beginningscene");

			}*/

			Debug.Log("In LostState");

			GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height),
			 manager.gameDataRef.lostStateSplash,
			  ScaleMode.StretchToFill);

			if(GUI.Button(new Rect(10,10,270, 30),"Click Here or Space key to repeat Level")||
				Input.GetKeyUp (KeyCode.Space));
			{
				manager.SwitchState(new PlayStateScene1_1(manager));
			}

			if(GUI.Button(new Rect(10,50,270, 30),"Click Here or Return Key to Restart the Game")||
				Input.GetKeyUp (KeyCode.Return));
			{
				manager.Restart();
			}
		}
	}
	
}
