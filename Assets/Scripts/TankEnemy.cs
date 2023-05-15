using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEnemy : MonoBehaviour
{

    TankHealth tTankHealth;

    public GameObject gTank;

    void Start ()
    {
		


	}
	
	void Update ()
    {

        if (tTankHealth.iHealth <= 0)
        {

            gTank.gameObject.SetActive(false);

        }

    }

}
