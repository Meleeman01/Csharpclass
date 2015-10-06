using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States

{
	public class BeginState : IStateBase
	{
		private StateManager manager;
		private float futureTime=0;
		private int countDown =0;
		private float screenDuration =8;	

		public BeginState(StateManager managerRef) //constructor
		{
			manager=managerRef;
			futureTime=screenDuration+Time.realtimeSinceStartup;
			Debug.Log(" BeginState constructed.");
			
		}


		public void StateUpdate()
		{
			float rightNow=Time.realtimeSinceStartup;
			countDown=(int)futureTime-(int)rightNow;

			if(Input.GetKeyUp (KeyCode.Space)||countDown<= 0)
			{
				Switch();
				//manager.SwitchState(new PlayState (manager));
			}
		}

		public void ShowIt()
		{
			if(GUI.Button(new Rect((Screen.width/2)-75,(Screen.height/2)-50,150,100), "Press to Play"))
			{
				
				Switch();
				//manager.SwitchState(new PlayState(manager));

			}

			GUI.Box (new Rect(Screen.width-60,10,50,25),countDown.ToString());
		}

		void Switch()
		{
			Time.timeScale=1;
			Application.LoadLevel("gamenumber1");  //name of scene save file
			manager.SwitchState (new PlayState (manager));
		}
	}
	
}
