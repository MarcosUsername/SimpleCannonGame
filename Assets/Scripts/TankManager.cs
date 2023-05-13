using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{

    public static TankManager tmInstance;

    private Tank[] Tank;

    private Transform tTankCamera;

    private int iCurrentTank;

    private void Awake()
    {

        if (tmInstance != null)
            Destroy(this);
        else
            tmInstance = this;

    }

    private void Start()
    {

        Tank = GameObject.FindObjectsOfType<Tank>();
        tTankCamera = Camera.main.transform;

        for(int i = 0; i < Tank.Length; i++)
        {

            Tank[i].iTankID = i;

        }

        NextTank();

    }

    public bool IsMyTurn(int i)
    {

        return i == iCurrentTank;

    }

    public void NextTank()
    {

        StartCoroutine(_NextTank());

    }

    public IEnumerator _NextTank()
    {

        int nextTank = iCurrentTank + 1;
        iCurrentTank -= 1;

        yield return new WaitForSeconds(2f);

        iCurrentTank = nextTank;

        if (iCurrentTank >= Tank.Length)
            iCurrentTank = 0;

        tTankCamera.SetParent(Tank[iCurrentTank].transform);
        tTankCamera.localPosition = Vector3.zero + Vector3.back * 10f;

    }

    void Update()
    {
        


    }

}
