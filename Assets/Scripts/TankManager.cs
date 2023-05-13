using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    Tank[] tanks;
    public Transform tTankCamera;

    public static TankManager singleton;

    private int iCurrentTank;

    void Start()
    {

        if (singleton != null)
        {

            Destroy(gameObject);
            return;

        }

        singleton = this;

        tanks = GameObject.FindObjectsOfType<Tank>();
        tTankCamera = Camera.main.transform;

        for (int i = 0; i < tanks.Length; i++)
        {

            tanks[i].iTankId = i;

        }

    }

    public void NextTank()
    {

        StartCoroutine(NextTankCoroutine());

    }

    public IEnumerator NextTankCoroutine()
    {

        var vNextTank = iCurrentTank + 1;
        iCurrentTank = -1;

        yield return new WaitForSeconds(2);

        iCurrentTank = vNextTank;
        if (iCurrentTank >= tanks.Length)
        {

            iCurrentTank = 0;

        }

        tTankCamera.SetParent(tanks[iCurrentTank].transform);
        tTankCamera.localPosition = Vector3.zero + Vector3.back * 10;

    }


    public bool IsMyTurn(int i)
    {

        return i == iCurrentTank;

    }

}
