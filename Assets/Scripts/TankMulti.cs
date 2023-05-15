using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMulti : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    public Transform tCurrentCannon;

    public float fTankSpeed = 0.01f;
    public float fMaxRelativeVelocity = 1f;
    public float fMisileForce = 5f; 

    public bool IsTurn { get { return TankManager.singleton.IsMyTurn(iTankId); } }

    public int iTankId;
    TankHealth tTankHealth;
    SpriteRenderer ren;

    public GameObject gTank;

    private void Start()
    {

        gTank.gameObject.SetActive(true);
        tTankHealth = GetComponent<TankHealth>();
        ren = GetComponent<SpriteRenderer>();

    }

    private void Update()
    {

        if (!IsTurn)
            return;

        RotateGun();

        if (tTankHealth.iHealth <= 0)
        {

            gTank.gameObject.SetActive(false);

        }

        var hor = Input.GetAxis("Horizontal");
        if (hor == 0)
        {

            tCurrentCannon.gameObject.SetActive(true);

            ren.flipX = tCurrentCannon.eulerAngles.z < 180;

            if (Input.GetKeyDown(KeyCode.Space))
            {

                var p = Instantiate(bulletPrefab,
                                   tCurrentCannon.position - tCurrentCannon.right,
                                   tCurrentCannon.rotation);

                p.AddForce(-tCurrentCannon.right * fMisileForce, ForceMode2D.Impulse);

                if (IsTurn)
                    TankManager.singleton.NextTank();

            }

        }

        else
        {

            tCurrentCannon.gameObject.SetActive(false);
            transform.position += Vector3.right *
                                hor *
                                Time.deltaTime *
                                fTankSpeed;            
             ren.flipX = Input.GetAxis("Horizontal") > 0;

        }

    }

    void RotateGun()
    {

        var diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        tCurrentCannon.rotation = Quaternion.Euler(0f, 0f, rot_z + 180);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.relativeVelocity.magnitude > fMaxRelativeVelocity)
        {

            tTankHealth.ChangeHealth(-3);
            if (IsTurn)
                TankManager.singleton.NextTank();

        }  

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Explosion"))
        {

            tTankHealth.ChangeHealth(-100);
            if (IsTurn)
                TankManager.singleton.NextTank();

        }
            
    }

}
