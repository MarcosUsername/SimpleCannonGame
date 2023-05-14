using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	SceneChange sSceneChange;
	[SerializeField] GameObject gObject;
	[SerializeField] GameObject gForrest;
	[SerializeField] GameObject gMushroom;
	[SerializeField] GameObject gBeach;
	private int iFetchMap;
	//private int iFetchMap = SceneChange.iMapChoice;
	//private int iFetchMap;

	void Start () 
	{

		sSceneChange = gObject.GetComponent<SceneChange>();
		gMushroom.SetActive(false);
		gForrest.SetActive(false);
		gBeach.SetActive(false);
		//iFetchMap = SceneChange.iMapChoice;

	}
	
	
	void Update () 
	{

		iFetchMap = sSceneChange.iMapChoice;
		Debug.Log("The fetched map choice is " + iFetchMap);

		if (iFetchMap == 1)
        {

			gMushroom.SetActive(true);
			Debug.Log("Mushroom map active");

		}

		if (iFetchMap == 2)
		{

			gForrest.SetActive(true);
			Debug.Log("Forrest map active");

		}

		if (iFetchMap == 3)
		{

			gBeach.SetActive(true);
			Debug.Log("Beach map active");

		}

	}

}
