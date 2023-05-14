using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SceneChange : MonoBehaviour
{

    private int iMapChoice;

    void Start()
    {

        iMapChoice = 1;

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

        SceneManager.LoadScene("Start Scene");

        Debug.Log("Chaning to the 'OPTIONS SCENE'");

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

        SceneManager.LoadScene("Multiplayer Scene");

        Debug.Log("Chaning to the 'MULTI SCENE'");

    }

    public void Quit()
    {

        Application.Quit();

        Debug.Log("The game should 'QUIT'");

    }

}