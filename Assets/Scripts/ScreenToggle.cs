using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToggle : MonoBehaviour 
{

	public void Screentoggle()
    {

		Screen.fullScreen = !Screen.fullScreen;
		Debug.Log("Toggled the screen from windowed to fullscreen");

    }

	void Start () 
	{
		


	}
	
	void Update () 
	{
		


	}

}
