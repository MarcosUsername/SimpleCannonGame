using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

    public Transform tTarget;
    public Vector3 vcOffset;
    
    /*public Transform tPlayer1;
    public Transform tPlayer2;
    public Transform tPlayer3;
    private Vector3 vcInitalOffset1;
    private Vector3 vcInitalOffset2;
    private Vector3 vcInitalOffset3;
    private Vector3 vcCameraPosition1;
    private Vector3 vcCameraPosition2;
    private Vector3 vcCameraPosition3;

    SceneChange sSceneChange;
    [SerializeField] GameObject gObject;*/

    void Start()
    {

        /*sSceneChange = gObject.GetComponent<SceneChange>();

        //vcInitalOffset1 = transform.position - tPlayer1.position;
        Debug.Log("Player 1 camera");

        vcInitalOffset2 = transform.position - tPlayer2.position;
        Debug.Log("Player 2 camera");

        vcInitalOffset3 = transform.position - tPlayer3.position;
        Debug.Log("Player 3 camera");

        if (sSceneChange.iMapChoice == 1)//
        {

            vcInitalOffset1 = transform.position - tPlayer1.position;
            Debug.Log("Player 1 camera");

        }

        if (sSceneChange.iMapChoice == 2)
        {

            vcInitalOffset2 = transform.position - tPlayer2.position;
            Debug.Log("Player 2 camera");

        }

        if (sSceneChange.iMapChoice == 3)
        {

            vcInitalOffset3 = transform.position - tPlayer3.position;
            Debug.Log("Player 3 camera");

        }*/

    }

    void FixedUpdate()
    {

       

    }

    void Update()
    {

        transform.position = tTarget.position + vcOffset;

        /*if (sSceneChange.iMapChoice == 1)
        {

            vcCameraPosition1 = tPlayer1.position + vcInitalOffset1;
            Debug.Log("Camera following Player 1");

            transform.position = vcCameraPosition1;

        }

        if (sSceneChange.iMapChoice == 2)
        {

            vcCameraPosition3 = tPlayer1.position + vcInitalOffset2;
            Debug.Log("Camera following Player 2");

            transform.position = vcCameraPosition2;

        }

        if (sSceneChange.iMapChoice == 3)
        {

            vcCameraPosition3 = tPlayer3.position + vcInitalOffset3;
            Debug.Log("Camera following Player 3");

            transform.position = vcCameraPosition3;

        }

        //transform.position = cameraPosition;*/


    }

}
