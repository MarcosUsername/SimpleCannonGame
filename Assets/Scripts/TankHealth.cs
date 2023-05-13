using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TankHealth : MonoBehaviour
{

    private int iHealth;
    public int iMaxHealth = 100;

    [SerializeField]
    private TextMeshProUGUI xHealthTxt;

    void Start()
    {

        iHealth = iMaxHealth;
        xHealthTxt.text = iHealth.ToString();

    }

    public void ChangeHealth(int change)
    {

        iHealth += change;

        if (iHealth > iMaxHealth)
            iHealth = iMaxHealth;
        else if (iHealth <= 0)
            iHealth = 0;

        xHealthTxt.text = iHealth.ToString();

    }

    void Update()
    {
       
        

    }

}
