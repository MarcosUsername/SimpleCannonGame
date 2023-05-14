using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SceneChange : MonoBehaviour
{

    SceneController sSceneController;
    [SerializeField] GameObject gObject;
    public int iMapChoice;
    public int iGameMode;

    void Start()
    {

        iGameMode = 3;
        iMapChoice = 1;
        sSceneController = gObject.GetComponent<SceneController>();
        //iMapChoice = Random.Range(1, 3);
        //Debug.Log("The chosen map number is " + iMapChoice);

    }

    void Update()
    {



    }

    public void SceneChangeSplash()
    {

        SceneManager.LoadScene("Splash Scene");
        Debug.Log("Chaning to the 'SPLASH SCENE'");

    }

    public void SceneChangeStart()
    {

        SceneManager.LoadScene("Start Scene");
        Debug.Log("Chaning to the 'START SCENE'");

    }

    public void SceneChangeOptions()
    {

        SceneManager.LoadScene("Options Scene");
        Debug.Log("Chaning to the 'OPTIONS SCENE'");

    }

    public void SceneChangeLoadSingle()
    {

        iGameMode = 0;
        SceneManager.LoadScene("Load Scene");
        Debug.Log("Chaning to the 'LOAD SCENE' then 'SINGLE'");

    }

    public void SceneChangeLoadMulti()
    {

        iGameMode = 1;
        SceneManager.LoadScene("Load Scene");
        Debug.Log("Chaning to the 'LOAD SCENE' then 'MULTI'");

    }

    public void SceneChangeSingle()
    {

        iMapChoice = Random.Range(1, 3);
        Debug.Log("The chosen map number is " + iMapChoice);

        SceneManager.LoadScene("Single Scene");
        Debug.Log("Chaning to the 'SINGLE SCENE'");

    }

    public void SceneChangeMulti()
    {

        iMapChoice = Random.Range(1, 3);
        Debug.Log("The chosen map number is " + iMapChoice);

        SceneManager.LoadScene("Multi Scene");
        Debug.Log("Chaning to the 'MULTI SCENE'");

    }

    public void Quit()
    {

        Application.Quit();
        Debug.Log("The game should 'QUIT'");

    }

}