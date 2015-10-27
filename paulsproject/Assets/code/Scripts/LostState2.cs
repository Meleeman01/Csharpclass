using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class LostState2 : IStateBase
	{
		private StateManager manager;

		public LostState2 (StateManager managerRef)
		{
			manager=managerRef;
			if(Application.loadedLevelName != "Scene0")
			{
				Application.LoadLevel ("Scene0");
			}
		}

		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space))
			{
				manager.SwitchState(new PlayStateScene2 (manager));
			}

			if (Input.GetKeyUp (KeyCode.Return))
			{
				manager.Restart();
			}
		}

		public void ShowIt()

		{
			Debug.Log("In LostState2");
		}
	}
}

