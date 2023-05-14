using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneController : MonoBehaviour 
{

	SceneChange sSceneChange;
	[SerializeField] GameObject gObject;
	public static string sPlayers;
	public GameObject gInput;
	private int iFetchGameMode;

	void Start () 
	{

		sSceneChange = gObject.GetComponent<SceneChange>();
		iFetchGameMode = sSceneChange.iGameMode;

	}
	
	void Update () 
	{

		if (iFetchGameMode == 0)
		{

			StartCoroutine(LoadSingle());
			Debug.Log("Loading 'SINGLE SCENE' change");

		}

		if (iFetchGameMode == 1)
		{

			StartCoroutine(LoadMulti());
			Debug.Log("Loading 'Mutli SCENE' change");

		}

	}

	public void StorePlayers()
    {

		sPlayers = gInput.GetComponent<Text>().text;

	}

	public IEnumerator LoadSingle()
    {

		yield return new WaitForSeconds(5);
		sSceneChange.SceneChangeSingle();
		Debug.Log("Calling 'SINGLE SCENE' change");

	}

	public IEnumerator LoadMulti()
	{

		yield return new WaitForSeconds(5);
		sSceneChange.SceneChangeMulti();
		Debug.Log("Calling 'MULTI SCENE' change");

	}

}
