using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMultiController : MonoBehaviour
{

    SceneChange sSceneChange;
    [SerializeField] GameObject gObject;
    [SerializeField] GameObject gCamera;
    [SerializeField] GameObject gForrest;
    [SerializeField] GameObject gMushroom;
    [SerializeField] GameObject gBeach;
    private int iFetchMap;

    void Start()
    {

        sSceneChange = gObject.GetComponent<SceneChange>();
        gCamera.SetActive(false);
        gMushroom.SetActive(false);
        gForrest.SetActive(false);
        gBeach.SetActive(false);

    }


    void Update()
    {

        iFetchMap = sSceneChange.iMapChoice;
        Debug.Log("The fetched map choice is " + iFetchMap);

        if (iFetchMap == 1)
        {

            gCamera.SetActive(true);
            gMushroom.SetActive(true);
            Debug.Log("Mushroom map active");

        }

        if (iFetchMap == 2)
        {

            gCamera.SetActive(true);
            gForrest.SetActive(true);
            Debug.Log("Forrest map active");

        }

        if (iFetchMap == 3)
        {

            gCamera.SetActive(true);
            gBeach.SetActive(true);
            Debug.Log("Beach map active");

        }

    }

}
