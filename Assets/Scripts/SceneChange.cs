using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SceneChange : MonoBehaviour
{

    public int iMapChoice;
    public int iEnemyKilled;

    void Start()
    {

        iEnemyKilled = 0;
        iMapChoice = Random.Range(1, 4);

    }

    void Update()
    {

        //fail safe to make sure map is in correct range
        if (iMapChoice == 4)
        {

            iMapChoice = Random.Range(1, 4);

        }

        //Game win condition
        if(iEnemyKilled >= 5)
        {

            SceneChangeEnd();
            Debug.Log("Game has been won!");

        }

    }

    // ----- Here we will load all the difference scenes ----- //

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

    public void SceneChangeSingle()
    {

        iMapChoice = Random.Range(1, 4);
        Debug.Log("The chosen map number is " + iMapChoice);

        SceneManager.LoadScene("Single Scene");
        Debug.Log("Chaning to the 'SINGLE SCENE'");

    }

    public void SceneChangeMulti()
    {

        iMapChoice = Random.Range(1, 4);
        Debug.Log("The chosen map number is " + iMapChoice);

        SceneManager.LoadScene("Multi Scene");
        Debug.Log("Chaning to the 'MULTI SCENE'");

    }

    public void ResetTheGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("The game will restart");

    }

    public void SceneChangeEnd()
    {

        SceneManager.LoadScene("End Scene");
        Debug.Log("Chaning to the 'END SCENE'");

    }

    public void Quit()
    {

        Application.Quit();
        Debug.Log("The game should 'QUIT'");

    }

}