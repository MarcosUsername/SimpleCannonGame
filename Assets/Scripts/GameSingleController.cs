using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSingleController : MonoBehaviour {

	SceneChange sSceneChange;
	[SerializeField] GameObject gObject;
    [SerializeField] GameObject gCamera1;
    [SerializeField] GameObject gCamera2;
    [SerializeField] GameObject gCamera3;
    [SerializeField] GameObject gForrest;
	[SerializeField] GameObject gMushroom;
	[SerializeField] GameObject gBeach;
	private int iFetchMap;

	void Start () 
	{

		sSceneChange = gObject.GetComponent<SceneChange>();
        gCamera1.SetActive(false);
        gCamera2.SetActive(false);
        gCamera3.SetActive(false);
        gMushroom.SetActive(false);
		gForrest.SetActive(false);
		gBeach.SetActive(false);

	}
	
	
	void Update () 
	{

		iFetchMap = sSceneChange.iMapChoice;
		Debug.Log("The fetched map choice is " + iFetchMap);

		if (iFetchMap == 1)
        {

            gCamera1.SetActive(true);
            gMushroom.SetActive(true);
			Debug.Log("Mushroom map active");

		}

		if (iFetchMap == 2)
		{

            gCamera2.SetActive(true);
            gForrest.SetActive(true);
			Debug.Log("Forrest map active");

		}

		if (iFetchMap == 3)
		{

            gCamera3.SetActive(true);
            gBeach.SetActive(true);
			Debug.Log("Beach map active");

		}

	}

}
