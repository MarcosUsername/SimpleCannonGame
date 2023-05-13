using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public int iHealth;
    public int iMaxHealth = 100;
    public Text txHealth;

	void Start ()
    {

        iHealth = iMaxHealth;
        txHealth.text = iHealth.ToString();

    }

    public void ChangeHealth(int change)
    {

        iHealth += change;
        if (iHealth > iMaxHealth)
        {

            iHealth = iMaxHealth;

        }

        txHealth.text = iHealth.ToString();

    }

}
