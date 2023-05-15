using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour 
{

	public SceneChange sSceneChange;
	[SerializeField] GameObject gObject;
	public static string sPlayers;
	public GameObject gInput;
    public int iGameMode;

    void Start () 
	{

		sSceneChange = gObject.GetComponent<SceneChange>();

    }
	
	void Update () 
	{

		if (iGameMode == 1)
		{

            Debug.Log("Loading 'SINGLE SCENE' change");
            sSceneChange.SceneChangeSingle();

		}

		if (iGameMode == 2)
		{

            Debug.Log("Loading 'Mutli SCENE' change");
            sSceneChange.SceneChangeMulti();


        }

	}

	public void StorePlayers()
    {

		sPlayers = gInput.GetComponent<Text>().text;

	}

    public void SingleGame()
    {

        iGameMode = 1;
        Debug.Log("Chosen Singleplayer. Game mode is " + iGameMode);

    }

    public void MultiGame()
    {

        iGameMode = 2;
        Debug.Log("Chosen multiplayer, Game mode is " + iGameMode);

    }

}
