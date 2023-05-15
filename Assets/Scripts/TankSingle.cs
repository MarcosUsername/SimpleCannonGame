using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSingle : MonoBehaviour 
{

    public Rigidbody2D bulletPrefab;
    public Transform tCurrentCannon;

    public float fTankSpeed = 0.05f;
    public float fMaxRelativeVelocity = 1f;
    public float fMisileForce = 5f;

    TankHealth tTankHealth;

    public GameObject gTank;
    public GameObject gCannon;

    void Start () 
	{

        gTank.gameObject.SetActive(true);
        tTankHealth = GetComponent<TankHealth>();

    }
	
	void Update () 
	{

        Move();

        RotateGun();

        if (Input.GetKeyDown(KeyCode.Space))
        {

            var p = Instantiate(bulletPrefab,
                               tCurrentCannon.position - tCurrentCannon.right,
                               tCurrentCannon.rotation);

            p.AddForce(-tCurrentCannon.right * fMisileForce, ForceMode2D.Impulse);

        }

        if (tTankHealth.iHealth <= 0)
        {

            gTank.gameObject.SetActive(false);

        }

    }

    void Move()
    {

        Vector2 vcPosition = transform.position;

        if (Input.GetKey(KeyCode.W))
        {

            vcPosition.y += fTankSpeed;

        }

        if (Input.GetKey(KeyCode.A))
        {

            vcPosition.x -= fTankSpeed;

        }

        if (Input.GetKey(KeyCode.S))
        {

            vcPosition.y -= fTankSpeed;

        }

        if (Input.GetKey(KeyCode.D))
        {

            vcPosition.x += fTankSpeed;

        }

        transform.position = vcPosition;

    }

    void RotateGun()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            gCannon.gameObject.transform.Rotate(0, 0, 0.5f);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            gCannon.gameObject.transform.Rotate(0, 0, -0.5f);

        }

    }

}
