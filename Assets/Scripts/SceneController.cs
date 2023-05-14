using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour 
{

	public static string sPlayers;
	public GameObject gInput;

	void Start () 
	{
	
		

	}
	
	void Update () 
	{
	
		

	}

	public void StorePlayers()
    {

		sPlayers = gInput.GetComponent<Text>().text;

	}

}
