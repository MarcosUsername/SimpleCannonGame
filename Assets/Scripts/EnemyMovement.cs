using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private int iMoveSpeed = 5;
    public Vector3 vcUserDirectionR = Vector3.right;
    public Vector3 vcUserDirectionL = Vector3.left;
    private int iCounter;

    void Start ()
    {

        iCounter = 1;

    }
	
	void Update ()
    {

        iCounter = Random.Range(1, 101);


        if (iCounter == 1) 
        {

            transform.Translate(vcUserDirectionR * iMoveSpeed * Time.deltaTime);

            Debug.Log("Enemy turns right");

        }

        if (iCounter == 50)
        {

            transform.Translate(vcUserDirectionL * iMoveSpeed * Time.deltaTime);

            Debug.Log("Enemy turns left");

        }

        else
        {

            transform.Translate(vcUserDirectionR * 0 * Time.deltaTime);
            transform.Translate(vcUserDirectionL * 0 * Time.deltaTime);

        }

    }

}
