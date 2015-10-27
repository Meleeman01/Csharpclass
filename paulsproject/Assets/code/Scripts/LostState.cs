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
			if (Input.GetKeyUp(KeyCode.Space))
			{
				
				manager.SwitchState (new PlayStateScene1_1 (manager));
				
			}

			if(Input.GetKeyUp (KeyCode.Return))
			{
				manager.Restart();			}
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
		}
	}
	
}
