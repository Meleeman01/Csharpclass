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
			if(Application.loadedLevelName !="Scene0")
			{
				Application.LoadLevel("Scene0");
			}
			
		}


		public void StateUpdate()
		{
			float rightNow=Time.realtimeSinceStartup;
			countDown=(int)futureTime-(int)rightNow;

			if(countDown<= 0)
			{

				Switch();
				//manager.SwitchState(new PlayState (manager));
			}
		}

		public void ShowIt()
		{
			GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height),
			 manager.gameDataRef.beginStateSplash,
			  ScaleMode.StretchToFill);

			if(GUI.Button(new Rect((Screen.width/2)-125,(Screen.height/2)-50,250,200), "Press here or Any Key to Continue")|| Input.anyKeyDown)
			{
				
				Switch();
				//manager.SwitchState(new PlayState(manager));

			}



			GUI.Box (new Rect(Screen.width-60,10,50,25),countDown.ToString());
		}

		void Switch()
		{
			Time.timeScale=1;
			Application.LoadLevel("Scene0");  //name of scene save file
			manager.SwitchState (new SetupState (manager));
		}
	}
	
}
