using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class WinState2 : IStateBase
	{
		private StateManager manager;

		public WinState2 (StateManager managerRef)
		{
			manager=managerRef;
			if(Application.loadedLevelName != "Scene0")
			{
				Application.LoadLevel("Scene0");
			}
		}

		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space))
			{
				manager.Restart();
			}
		}

		public void ShowIt()
		{
			Debug.Log("In WinState2");
		}
	}
}

