using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour {
	public Texture2D winsplash;
	// Use this for initialization
	void Start () {
	GameObject.Find("character");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter()
	{
		GUI.DrawTexture (new Rect(0,0, Screen.width, Screen.height),
		winsplash, ScaleMode.StretchToFill);
		DestroyImmediate(this);
	}


	
}
