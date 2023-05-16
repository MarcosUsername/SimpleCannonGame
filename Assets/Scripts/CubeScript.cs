using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public GameObject gCube;

    private int iSpeed;

    private int iRandomNumber;

    SceneChange sSceneChange;
    [SerializeField] GameObject gObject;

    void Start ()
    {

        sSceneChange = gObject.GetComponent<SceneChange>();
        iSpeed = Random.Range(1, 5);

        iRandomNumber = Random.Range(1, 10);


    }
	
	void Update ()
    {

        transform.position = new Vector3(Mathf.PingPong(Time.time * iSpeed, iRandomNumber), transform.position.y, transform.position.z);

    }

    private void OnTriggerEnter(Collider other)
    {

        sSceneChange.iEnemyKilled++;
        Debug.Log("Cube has been hit by " + other.name + "!");
        Destroy(gameObject);

    }

}
