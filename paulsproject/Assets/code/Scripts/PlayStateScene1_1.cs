using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayStateScene1_1: IStateBase
	{
		private StateManager manager;

		private GameObject player;

		public PlayStateScene1_1 ( StateManager managerRef)
		{
			manager=managerRef;
			if(Application.loadedLevelName != "Scene1")
			{
				Application.LoadLevel("Scene1");
			}

			player= GameObject.Find("Player");
			player.GetComponent<Rigidbody>().isKinematic=false;

		}

		public void StateUpdate ()
		{
			if (Input.GetKeyUp (KeyCode.Space))
			{
				manager.SwitchState (new WinState (manager));
			}

			if(Input.GetKeyUp (KeyCode.Return))
			{
				manager.SwitchState (new LostState (manager));
			}
		}

		public void ShowIt()
		{
			Debug.Log("In PlayStateScene1_1");
		}
	}
} 


