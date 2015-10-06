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
				Debug.Log("loading BeginningScene...");
				manager.SwitchState (new BeginState (manager));
				Application.LoadLevel("beginningscene");
				Debug.Log("BeginningScene loaded.");
			}
		}

		public void ShowIt()
		{
			if(GUI.Button(new Rect((Screen.width/2)-75,(Screen.height/2)-50,150,100), "You Lost. Play Again?"))
			{
				
				manager.SwitchState (new BeginState (manager));
				Application.LoadLevel("beginningscene");

			}
		}
	}
	
}
