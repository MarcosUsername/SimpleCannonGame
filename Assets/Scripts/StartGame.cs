using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour 
{



	void Start () 
	{

		StartCoroutine(fStartGame());
		Debug.Log("'Start Game' function has been called");

	}
	
	void Update () 
	{
	
		

	}

	public IEnumerator fStartGame()
	{

		yield return new WaitForSeconds(5);
		SceneManager.LoadScene("Start Scene");
		Debug.Log("Chaning to the 'START SCENE'");

	}

}
