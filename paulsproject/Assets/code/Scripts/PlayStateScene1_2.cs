using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayStateScene1_2 : IStateBase
	{
		private StateManager manager;
		private GameObject player;
		private PlayerControl controller;

		public PlayStateScene1_2 (StateManager managerRef)
		{
			manager=managerRef;
			player=GameObject.Find("Player");
			controller=player.GetComponent<PlayerControl>();

			foreach( GameObject camera in manager.gameDataRef.cameras)
			{
				if(camera.name != "FollowCam")
				{
					camera.SetActive(false);
				}
				else
				{
					camera.SetActive(true);
				}
			}
			if(Application.loadedLevelName != "Scene1")
			{
				Application.LoadLevel("Scene1");
			}
		}

		public void StateUpdate()
		{
			if (manager.gameDataRef.playerLives <=0)
			{
				manager.SwitchState (new LostState(manager));

				manager.gameDataRef.ResetPlayer();
				player.GetComponent<Rigidbody>().isKinematic=true;
				player.transform.position = new Vector3(50, .5f, 40);
			}

			if(manager.gameDataRef.score>=2)
			{
				manager.SwitchState(new WinState(manager));
				player.GetComponent<Rigidbody>().isKinematic=true;
				player.transform.position=new Vector3(50, .5f, 40);
			}

			if(Input.GetKeyDown(KeyCode.LeftControl))
			{
				controller.FireEnergyPulse();
			}

		}

		public void ShowIt()
		{
			Debug.Log("In PlayStateScene1_2");
		}
	}
}
